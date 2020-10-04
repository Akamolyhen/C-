using System;
using System.Diagnostics;

namespace 事件
{
    public delegate void DelSum();
    public class Tool
    {
        public event DelSum Myevent;
        public DelSum del;
        public Tool()
        {
        }
        public void ShowResult()
        {
            if(del!=null)
            {
                del();
            }
        }
        public void Showevent()
        {
            if(Myevent!=null)
            {
                Myevent();
            }
        }
    }
}
