using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace ZUART
{


    /*
     *Form:https://stackoverflow.com/questions/217902/reading-writing-an-ini-file 
     *
     *
     *通过以下 3 种方式之一打开 INI 文件：
     *var MyIni = new IniFile();// named EXE.ini (where EXE is the name of your executable)
     *var MyIni = new IniFile("Settings.ini");
     *var MyIni = new IniFile(@"C:\Settings.ini");
     *
     *你可以像这样写一些值：
     *MyIni.Write("DefaultVolume", "100");
     *MyIni.Write("HomePage", "http://www.google.com");
     *创建------------
     *[MyProg]
     *DefaultVolume=100
     *HomePage=http://www.google.com
     *----------------
     *
     *要从 INI 文件中读取值：
     *var DefaultVolume = MyIni.Read("DefaultVolume");
     *var HomePage = MyIni.Read("HomePage");
     *
     *
     *写值()：
     *MyIni.Write("DefaultVolume", "100", "Audio");
     *MyIni.Write("HomePage", "http://www.google.com", "Web");
     *创建--------------
     *[Audio]
     *DefaultVolume=100
     *[Web]
     *HomePage=http://www.google.com
     **----------------
     *
     *您还可以检查密钥是否存在，如下所示：
     *if(!MyIni.KeyExists("DefaultVolume", "Audio")) MyIni.Write("DefaultVolume", "100", "Audio");
     *
     *您可以像这样删除密钥：
     *MyIni.DeleteKey("DefaultVolume", "Audio");
     *
     *您还可以像这样删除整个部分（包括所有键）：
     *MyIni.DeleteSection("Web");

     */
    class IniFile   // revision 11
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            FileInfo fileInfo = new FileInfo(IniPath ?? EXE + ".ini");
            if (Directory.Exists(fileInfo.DirectoryName))
            {
            }
            else
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(fileInfo.DirectoryName);
                directoryInfo.Create();
            }
            
            Path = fileInfo.FullName;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            int len=GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            if (len < 1) return null;
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section) == null;

        }



        /// <summary>
        /// 序列化保存
        /// </summary>
        /// <returns></returns>
        public bool Serialize<T>(T Value)
        {
            Type tInfo = Value.GetType();
            string section = tInfo.Name;
            foreach (PropertyInfo p in tInfo.GetProperties())
            {
                string key = p.Name;
                object value = p.GetValue(Value, null);
                string v = value == null ? "" : value.ToString();

                //IniWriteValue(path, section, key, v);
                Write(key, v, section);
            }
            return true;
        }

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <returns></returns>
        public T Deserialize<T>(ref T Value, string path)
        {
            Type tInfo = Value.GetType();
            string section = tInfo.Name;
            foreach (PropertyInfo p in tInfo.GetProperties())
            {
                string key = p.Name;
                string iniValue = Read(key, section);
                if (iniValue == null) continue;
                if (iniValue == string.Empty)
                {
                    PropertyInfo pd = Value.GetType().GetProperty(key);
                    iniValue = pd.GetValue(Value, null) as string;
                }
                //string v = p.PropertyType == null ? "" : p.PropertyType.ToString();
                //object value = iniValue.Format(p.PropertyType);
                object value = Convert.ChangeType(iniValue, p.PropertyType);
                p.SetValue(Value, value, null);
            }
            return Value;
        }
    }
}
