using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZUART.BatchSend
{
    internal class BatchSendItem
    {
        private int _delay;
        [Description("延时时间,多长时间后发送此命令"), Browsable(false)]
        public int delay
        {
            get
            {
                return _delay;
            }
            set
            {
                _delay = value;
            }

        }

        private bool _ishex;
        public bool ishex
        {
            get
            {
                return _ishex;
            }
            set
            {
                _ishex = value;
            }
        }
        private string _dat;
        public string dat
        {
            get
            {
                return _dat;
            }
            set
            {
                _dat = value;
            }
        }

        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public BatchSendItem(int delay,bool ishex,string dat,string name)
        {
            this._delay = delay;
            this._ishex = ishex;
            this._dat = dat;
            this._name = name;
        }

    }
}
