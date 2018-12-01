using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp10
{
    delegate void Func(string str);
    class Myclass
    {
        private string str;
        public Myclass(string str)
        {
            this.str = str;
        }       
        public void Space(string str)
        {
            int counter = 0;
            string new_str = "";
            foreach (var item in str)
            {
                new_str += item;
                if (counter < str.Length - 1)
                {
                    new_str += "_";
                    counter++;
                }
            }

            Console.WriteLine(new_str);
        }
        public void Reverse(string str)
        {
            int counter = str.Length - 1;
            char[] new_str = new char[str.Length];
            foreach (var item in str)
            {
                new_str[counter] = item;
                counter--;
            }
            string tmp = "";
            for (int i = 0; i < new_str.Length; i++)
            {
                tmp += new_str[i];
            }
            Console.WriteLine(tmp);

        }
    }
    class Run
    {
        public void runFunc(Func func, string str) => func(str);
    }

    class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Enter string");
              string  str = Console.ReadLine();
            Myclass cls = new Myclass(str);
            Func funcDell = new Func(cls.Space);
            funcDell += cls.Reverse;
            Run run = new Run();
            run.runFunc(funcDell, str); 
        }
    }
}
