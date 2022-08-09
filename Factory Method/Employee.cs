using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_DP
{
    public class Lead: EmplyeeBase
    {
        public override void DoWork()
        {
            Console.WriteLine("Do work");
        }
    }
    public class Programmer : EmplyeeBase
    {
        public override void DoWork()
        {
            Console.WriteLine("Do work");
        }
    }

    public class EmplyeeBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual void DoWork()
        {
            throw new NotImplementedException();
        }
    }
}
