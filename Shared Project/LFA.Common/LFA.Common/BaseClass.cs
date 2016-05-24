using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.Common
{
    public class BaseClass
    {
        public DateTime SysCreate { get; set; }

        public virtual void Display()
        {
            Console.WriteLine("Base Class");
        }
    }

    public class Derived : BaseClass
    {
        public void Display()
        {
            Console.WriteLine("From Derived Class");
        }
    }

    public class DerivedOveride : BaseClass
    {
        public override void Display()
        {
            Console.WriteLine("From DerivedOveride Class");
        }
    }
}
