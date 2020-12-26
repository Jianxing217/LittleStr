using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace LittleStar
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //接收控制台的按键值
                ConsoleKeyInfo ck =  Console.ReadKey(true);
                char c = ck.KeyChar;
                Console.WriteLine(c);

                WindowsMediaPlayer wm = new WindowsMediaPlayer();
                wm.URL = @"C:\Users\Jaden\source\repos\LittleStar\note\"+c+".mp3";
                //Console.Beep(300,500);
            }
        }
    }
}
