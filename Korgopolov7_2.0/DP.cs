using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Korgopolov7_2._0
{
    internal class DP
    {
        public static void DP1(string path)
        {
            string name = Console.ReadLine();
            File.Create(path + "\\" + name).Close();
        }
        public static void DP2(string path)
        {
            string name = Console.ReadLine();
            Directory.CreateDirectory(path + "\\" + name);

        }
        public static void DP3(string path)
        {
            string name = Console.ReadLine();
            Directory.Delete(path + "\\" + name, true);

        }
        public static void DP4(string path)
        {
            string name = Console.ReadLine();
            File.Delete(path + "\\" + name );

        }
    }
}
