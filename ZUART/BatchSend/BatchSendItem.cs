using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZUART.BatchSend
{
    public class BatchSendItem
    {

        [Description("是否选中"), Browsable(false)]
        public bool ischeck
        {
            get;
            set;
        }
        [Description("延时时间,多长时间后发送此命令"), Browsable(false)]
        public int delay
        {
            get;
            set;

        }
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
        public BatchSendItem(int delay, bool ishex, string dat, string name)
        {
            this.ischeck = true;
            this.delay = delay;
            this.ishex = ishex;
            this.dat = dat;
            this.name = name;
        }
        public BatchSendItem(bool ischeck, int delay, bool ishex, string dat, string name)
        {
            this.ischeck = ischeck;
            this.delay = delay;
            this.ishex = ishex;
            this.dat = dat;
            this.name = name;
        }


        public string getSerializeStr()
        {
            string context = "";
            context = context + (ischeck ? "1" : "0") + "|";
            context = context + delay + "|";
            context = context + (ishex ? "1" : "0") + "|";
            context = context + name + "|";
            context = context + dat.Replace("\r", "\u0003").Replace("\n", "\u0002");
            return context;
        }

        static public BatchSendItem BatchSendItemFromOneStr(string str)
        {
            Regex regex = new Regex(@"^(\d+)\=([01])\|(\d+)\|([01])\|(.*?)\|(.*)$");
            //搜索匹配的字符串 
            MatchCollection matches;
            try
            {
                matches = regex.Matches(str);
                if (matches.Count != 1) return null;
                Match match = matches[0];
                if (match.Groups.Count != 7) return null;

                bool ischeck = Convert.ToInt32(match.Groups[2].Value) == 1 ? true : false;
                int delay = Convert.ToInt32(match.Groups[3].Value);
                bool ishex = Convert.ToInt32(match.Groups[4].Value) == 1 ? true : false;
                string name = match.Groups[5].Value;
                string dat = match.Groups[6].Value.Replace("\u0003", "\r").Replace("\u0002", "\n");

                //byte[] gb = Encoding.GetEncoding("gbk").GetBytes(name);       //导入编码确认
                //gb = Encoding.Convert(Encoding.GetEncoding("gbk"), Encoding.UTF8, gb);
                //name = Encoding.UTF8.GetString(gb);
                //addItem(new BatchSendItem(delay, ishex, dat, name));

                return new BatchSendItem(ischeck,delay, ishex, dat, name);
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
