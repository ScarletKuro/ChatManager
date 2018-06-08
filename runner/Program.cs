using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ChatManager;

namespace runner
{
    class Program
    {

        static void Main(string[] args)
        {


            var l = new ChatManager.ChatManager();
            l.OnButtonClick();
            
            
            Console.ReadLine();
        }
    }
}
