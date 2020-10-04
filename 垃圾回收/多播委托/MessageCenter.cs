using System;
namespace 多播委托
{
    public delegate void DelMessage();
    public class MessageCenter
    {
        public MessageCenter()
        {
        }
        public void ShowMessage(DelMessage del)
        {
            if (del != null)
                del();
        }
    }
}
