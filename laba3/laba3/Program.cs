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

            //foreach (List<int> y in x)
            //{

            //    Console.WriteLine();
            //    foreach (int w in y)
            //    {
            //        Console.Write(w + " ");
            //    }
            //}
            List<int> allWeight = new List<int>();
            
            for (int i = 0; i < x[s-1].Count; i++)
            {
                
                    allWeight.Add(x[s - 1][i]);
                    
               

            }
            int allWeightW = 0;
            while (true)
            {
                int min = 500000000, w = 0;

                for (int i = 0; i < allWeight.Count; i++)
                {
                    if (allWeight[i] != -1 && allWeight[i] != 0)
                    {

                        if (Math.Min(min, allWeight[i]) != min)
                        {
                            w = i;
                        }
                        min = Math.Min(min, allWeight[i]);
                    }


                }
                allWeightW = allWeight[w];
                allWeight[w] = -1;
                for (int i = 0; i < allWeight.Count; i++)
                {
                    if (allWeight[i] != -1 && allWeight[i] != 0)
                    {

                        for (int j = 0; j < x[w].Count; j++)
                        {
                            if (j == i)
                            {
                                
                                allWeight[i] = Math.Min(allWeight[i], allWeightW + x[w][j]);
                                
                            }

                        }

                    }

                    if (i == f - 1 && allWeight[i] != -1 && allWeight[i] != 0)
                    {
                        allWeightW = allWeight[i];
                    }
                }
                int count = 0;
                foreach(int r in allWeight)
                {
                    
                    if (r == -1 || r == 0)
                    {
                        count++;
                    }
                }
                
                if (count == allWeight.Count)
                {
                    break;
                }
            }




            using (StreamWriter sw = File.CreateText(@"C:\\Users\\ыае\\Desktop\\OUTPUT.txt"))
            {
                sw.WriteLine(allWeightW);
            }
        }
    }
}
