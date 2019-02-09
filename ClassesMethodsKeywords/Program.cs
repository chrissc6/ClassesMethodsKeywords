using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMethodsKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //var pk = new ParamsKeyword();
            //pk.PK(1, 2, 3, 4, 5, 6, 7, 8, 9);
            //pk.PK();
            //pk.PK(1000, 212, 3155, 4841, 11);

            //var op = new OutParameter();
            //op.OP();

            var vr = new valueVSreference();
            vr.ValueType();
            vr.ValueTypeRef();
            vr.ReferenceType();

        }
    }
}
