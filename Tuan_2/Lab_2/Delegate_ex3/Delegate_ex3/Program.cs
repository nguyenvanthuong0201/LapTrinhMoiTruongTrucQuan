using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_ex3
{
    class Program
    {
        static void InvokeDelegate(NotifyMe d)
        {
            d("You are late paying your bills!");
        }

        static void Main(string[] args)
        {
           
           NotifyMe d = new NotifyMe(Listener.GetNotifiedAgain);
            InvokeDelegate(d);
            Listener lsnr = new Listener();
            NotifyMe d2 = new NotifyMe(lsnr.GetNotified);
            InvokeDelegate(d2);
        }
    }
}
