using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Base obj = new Base();
            obj.Print();
            //Gọi phương thức Print() bằng  interface  ITest
            ITest ib = (ITest)obj;
            ib.Print();
            //Gọi phuong thức Print() bằng cách ép kiểu Interface ITest về lớp Base
            Base ojB = (Base)ib;
            ojB.Print();
            Console.ReadLine();

        }
    }
}
