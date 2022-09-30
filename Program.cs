using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class program
    {

        static void Main(string[] args)
        {
            store s = new store();
            s.Id = 1;
            s.Name = "abc";
            s.Noofbrances = 3;
            s.Noofmanager = 4;
            s.employe = 7;
            s.Location = "HSR";
            Console.WriteLine(s.Id);
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Noofbrances);
            Console.WriteLine(s.Noofmanager);
            Console.WriteLine(s.employe);
            Console.WriteLine(s.Location);
            s.totalemploye();
        }

    }

}