using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_ex2
{
   public interface IHuman
    {
        void Speak(string Message);
        string Name
        {
            get;
            set;
        }
    }
}
