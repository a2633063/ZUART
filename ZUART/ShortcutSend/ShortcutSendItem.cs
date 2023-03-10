using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZUART.ShortcutSend
{
    public class ShortcutSendItem
    {
        public bool ishex
        {
            get;
            set;
        }
        public string dat
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }
        public ShortcutSendItem( bool ishex, string dat, string name)
        {

            this.ishex = ishex;
            this.dat = dat;
            this.name = name;
        }

        public string getSerializeStr(int index)
        {
            string context = "";
            context = context + (ishex ? "1" : "0") + "|";
            context = context + "0" + "|";
            context = context + index + "|";
            context = context + dat.Replace("\r", "\u0003").Replace("\n", "\u0002");
            return context;
        }

        static public ShortcutSendItem ShortcutSendItemFromOneStr(string str)
        {
            Regex regex = new Regex(@"^(.+)\=([01])\|(\d+)\|(\d+)\|(.*)$");
            //搜索匹配的字符串 
            MatchCollection matches;
            try
            {
                matches = regex.Matches(str);
                if (matches.Count != 1) return null;
                Match match = matches[0];
                if (match.Groups.Count != 6) return null;

                string name = match.Groups[1].Value;
                bool ishex = Convert.ToInt32(match.Groups[2].Value) == 1 ? true : false;
                string dat = match.Groups[5].Value.Replace("\u0003", "\r").Replace("\u0002", "\n");

                //byte[] gb = Encoding.GetEncoding("gbk").GetBytes(name);       //导入编码确认
                //gb = Encoding.Convert(Encoding.GetEncoding("gbk"), Encoding.UTF8, gb);
                //name = Encoding.UTF8.GetString(gb);
                //addItem(new ShortcutSendItem(delay, ishex, dat, name));

                return new ShortcutSendItem(ishex, dat, name);
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
