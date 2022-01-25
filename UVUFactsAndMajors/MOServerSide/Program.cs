using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOServerSide
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mitchell's UVU Fact/Major Server");
            Console.WriteLine("-----------------------------------");
            //create a new process so we can open two apps at the same time
            Process process = new Process();
            // Assign the executable path tot he filename property of the process
            //process.StartInfo.FileName = @"C:\Code\INFO-2200\MOClientServer2\MOClientSide\bin\Debug\MOClientSide.exe";
            //open the client form
            //process.Start();

            //create an instance of synchonousSocketListener so we can start listening for client requests
            SynchronousSocketListener ssl = new SynchronousSocketListener();
            ssl.StartListening();
        }
    }
}
