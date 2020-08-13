using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace dll_issue
{
    public class Class1
    {
        public void WriteMe()
        {
            System.Console.WriteLine(RuntimeInformation.FrameworkDescription);
        }
    }
}
