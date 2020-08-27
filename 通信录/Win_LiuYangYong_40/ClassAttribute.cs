using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Win_LiuYangYong_40
{
    class ClassAttribute
    {
        private string _Name;
        private string _Number;
        private string _Phone;
        private string _Address;  

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Number
        {
            get { return _Number; }
            set { _Number = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        string str = "";  
        public override string ToString()
        {
            return str;
        }
        public bool CheckEmpty(string number, string name, string phone, string address)
        {
            if (number == "" || name == "" || phone == "" || address == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckName(string regex1, string regex2,string sname)
        {
            Regex re1= new Regex(regex1);
            Regex re2 = new Regex(regex2);
            bool b1 = re1.IsMatch(sname);
            bool b2 = re2.IsMatch(sname);
            if (b1)
            {
                str = _Number.PadRight(18) + _Name.PadRight(18 - _Name.Length) + _Phone.PadRight(18) + _Address;
                return true;
            }
            else if (b2)
            {
                str = _Number.PadRight(18) + _Name.PadRight(18) + _Phone.PadRight(18) + _Address;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckInput(string regex,string input)
        {
            Regex re = new Regex(regex);
            bool b = re.IsMatch(input);
            if (!b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       
    }
    
}
