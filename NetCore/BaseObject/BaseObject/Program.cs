using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Letter l = new Letter('a');
            //Console.WriteLine(l.c);
            //ChangeObjectValue.change(l);
            //Console.WriteLine(l.c);

            //int n = 0;
            //Console.WriteLine(n);
            //ChangeObjectValue.change(out n);
            //Console.WriteLine(n);

            Letter ll = new Letter('c');
            ChangeObjectValue.getLetter(ref ll);
            Console.WriteLine(ll.c);
            Letter lll = new Letter('c');
            ChangeObjectValue.getLetter2(out lll);
            Console.WriteLine(lll.c);
        }
    }

    public class Letter
    {
        public char c;

        public Letter() { }

        public Letter(char c)
        {
            this.c = c;
        }
    }

    public class ChangeObjectValue
    {
        public static void change(Letter l)
        {
            l.c = 'z';
        }

        public static void change(out int n)
        {
            n = 100;
        }

        public static void getLetter(ref Letter l)
        {
            char test = l.c;
            l.c = 'y';
        }

        public static void getLetter2(out Letter l)
        {
            //char test = l.c;
            l = new Letter('x');
            l.c = 'y';
        }
    }
}
