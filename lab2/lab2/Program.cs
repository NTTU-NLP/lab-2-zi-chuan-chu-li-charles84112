using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"D:\大數據\lab-2-zi-chuan-chu-li-charles84112\Data\Input.txt"))
            {
                while (sr.Peek() != -1)
                {
                    string line = sr.ReadLine();
                    foreach (var ch in line)
                    {
                        if (!Char.IsWhiteSpace(ch))
                        {
                            if (Char.IsPunctuation(ch))
                            {
                                if (ch == '.')
                                {
                                    Console.Write("." + "\n");
                                }
                                if(ch == '?')
                                {
                                    Console.Write("?" + "\n");
                                }
                                if (ch == '!')
                                {
                                    Console.Write("!" + "\n");
                                }
                            }
                            else
                            {
                                Console.Write(ch);
                            }
                        }
                        else
                            Console.Write(" ");
                    }Console.Write("\n");
                }
            }
        }
    }
}
