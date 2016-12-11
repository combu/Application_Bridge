using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ApplicationBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("path.txt", Encoding.GetEncoding("Shift_JIS"));
                string path = sr.ReadToEnd();
                sr.Close();
                System.Diagnostics.Process PS = System.Diagnostics.Process.Start(path);
                PS.WaitForExit();
            }
            catch
            {
                Console.WriteLine("path.txtが存在しないか、指定されたパスが見つかりません。");
                Console.WriteLine("Enterキーを押してください。");
                Console.ReadLine();
                return;
            }
        }
    }
}
