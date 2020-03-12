using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_ex3
{
    class Listener
    {
        public void GetNotified(string sInfo)
        {
            Console.WriteLine("I got notified with the following information {0}", sInfo);
        }
        public static void GetNotifiedAgain(string sInfo)
        {
            Console.WriteLine("I got notified with the following information:{0}", sInfo);
        }
        static void InvokeDelegate(NotifyMe d)
        {
            d("You are late paying your bills!");
        }
    }
}
