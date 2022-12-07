using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba2
{
    class Program
    {
        static public void mnogo(string s, int step, int n)
        {
            
            if(step < 27)
            {
                char newletter = (char)(64 + step);
                
                if (s != null)
                {
                    s = newletter + s + s;
                }
                else
                {
                    s = newletter.ToString();
                }
                mnogo(s, step + 1, n);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(@"C:\\Users\\ыае\\Desktop\\OUTPUT2.txt"))
                {
                    sw.WriteLine(s[n-1]);
                };
            }
        }
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\\Users\\ыае\\Desktop\\INPUT2.txt");
            List<int> intset = new List<int>();

            try

            {

                foreach (string s in text)
                {
                    intset.Add(Int32.Parse(s));

                }

            }
            catch
            {
                Console.WriteLine("Введіть число!");
            }



            mnogo("", 1, intset[0]);
        }
    }
}
