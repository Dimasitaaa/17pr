using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new File { Permissions = FileAccess.Read | FileAccess.Write };
            Console.WriteLine(f.CanRead());
            Console.WriteLine(f.CanWrite());
        }
    }
    [Flags] enum FileAccess { None = 0, Read = 1, Write = 2, Execute = 4}
    struct File
    {
        public FileAccess Permissions;
       
        public bool CanRead()
        {
            if (Permissions.HasFlag(FileAccess.Read)) return true;
            else
            {
                return false;
            }
        }
        public bool CanWrite()
        {
            if (Permissions.HasFlag(FileAccess.Write)) return true;
            else
            {
                return false;
            }
        }
    }
}
