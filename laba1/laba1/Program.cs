using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace laba1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\\Users\\ыае\\Desktop\\INPUT.txt");
            List<int> intset = new List<int>();

            try

            {
                
                foreach(string s in text)
                {
                    intset.Add(Int32.Parse(s));
                    
                }
                //intset[0] >= 1;
            }
            catch 
            {
                Console.WriteLine("Введіть число!");
            }
            List<char> bukawi = new List<char>(); 
            for (int i = 65; i <= intset[0] + 64; i++)
            {
                bukawi.Add((char)  i);
            }

            List<string> slovawi = new List<string>();
            for (int i = 0; i < bukawi.Count; i++)
            {
                
                for (int j = i + 1; j < bukawi.Count; j++)
                {
                    slovawi.Add(bukawi[i] + " " + bukawi[j]);
                    
                }
            }
            foreach(string s in slovawi)
            {
                Console.WriteLine(s);
            }

            
            using (StreamWriter sw = File.CreateText(@"C:\\Users\\ыае\\Desktop\\OUTPUT.txt"))
            {
                sw.WriteLine(slovawi[intset[2]-1]);
            }

            Console.ReadLine();

            //String line;

            //try
            //{
            //    StreamReader sr = new StreamReader("C:\\Users\\ыае\\Desktop\\INPUT.txt");
            //    //Read the first line of text
            //    line = sr.ReadLine();

            //    //Continue to read until you reach end of file
            //    while (line != null)
            //    {
            //        //write the line to console window
            //        Console.WriteLine(line);
            //        //Read the next line
            //        line = sr.ReadLine();
            //    }
            //    //Pass the filepath and filename to the StreamWriter Constructor
            //    StreamWriter sw = new StreamWriter("C:\\Users\\ыае\\Desktop\\OUTPUT.txt");
            //    //Write a line of text
            //    sw.WriteLine("Hello World!!");
            //    //Write a second line of text
            //    sw.WriteLine("From the StreamWriter class");
            //    //Close the file
            //    sw.Close();
            //    //close the file
            //    sr.Close();
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception: " + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Executing finally block.");
            //}
        }
    }
}
