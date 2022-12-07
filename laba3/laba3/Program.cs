using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba3
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\\Users\\ыае\\Desktop\\INPUT.txt");
            List<int> intset = new List<int>();
            
            string[] a = text[0].Split(' ');
            if(a.Length != 3)
            {
                return;
            }
            try

            {


                foreach (string s1 in a)
                {
                    intset.Add(Int32.Parse(s1));

                }

            }
            catch
            {
                Console.WriteLine("Введіть число!");
            }
            int n = intset[0], s = intset[1], f = intset[2];
            if (text.Length != n + 1)
            {
                return;
            }
            List<List<int>> x = new List<List<int>>();
            for (int i = 1; i < text.Length; i++)
            {
                List<int> x1 = new List<int>();
                x.Add(x1);
                //try

                //{


                    foreach (string s1 in text[i].Split(' '))
                    {
                        x[i-1].Add(Int32.Parse(s1));

                    }

                //}
                //catch
                //{
                //    Console.WriteLine("Введіть число!");
                //}
            }
            foreach(List<int> y in x)
            {
                Console.WriteLine();
                foreach(int w in y)
                {
                    Console.Write(w + " ");
                }
            }





            //using (StreamWriter sw = File.CreateText(@"C:\\Users\\ыае\\Desktop\\OUTPUT.txt"))
            //{
            //    sw.WriteLine();
            //}
        }
    }
}
