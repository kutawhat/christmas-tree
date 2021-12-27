using System.Threading;
using System.Text;
using System.IO;
using System;

namespace christmas_tree
{
    internal class Program
    {
        static ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
        
        public static void PrintTreeAnimated(string tree)
        {
            bool check = true;
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(700);

                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] == '*')
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '"')
                    {
                        Console.ForegroundColor = colors[3];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = colors[4];
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = colors[7];
                        Console.Write(tree[i]);
                    }
                }

                Thread.Sleep(700);
                
                for (int i = 0; i < tree.Length; i++)
                {
                    if (tree[i] == '*')
                    {
                        Console.ForegroundColor = colors[14];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == '"')
                    {
                        Console.ForegroundColor = colors[3];
                        Console.Write(tree[i]);
                    }
                    else if (tree[i] == 'o')
                    {
                        Console.ForegroundColor = colors[8];
                        Console.Write(tree[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = colors[7];
                        Console.Write(tree[i]);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            string path = "/.../.../tree.txt";
            string tree = File.ReadAllText(path);

            PrintTreeAnimated(tree);
        }
    }
}
