using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Speaker.Default;
using Viewer;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultSynthetizer syn = new DefaultSynthetizer();
            Console.WriteLine("Ready to say Hola mundo...");
            Console.ReadKey();
            //syn.SpeakText("Hola mundo");
            Console.WriteLine("Spoke finished.");
            Console.ReadKey();
        }
    }
}
