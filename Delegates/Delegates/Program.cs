using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public delegate void Divisbythree(List<int> list);
    internal class Program
    {
        public void check(List<int >l)
        {
            foreach(int i in l)
            {
                if(i%3==0)
                {
                    Console.WriteLine(i);
                }
            }

        }

        public void doit(Divisbythree obj)
        {
            List<int> NumList = new List<int>() { 1, 4, 7, 3, 6, 15, 27, 18 };
            obj(NumList);
            
        }
        static void Main(string[] args)
        {
           /* Program p=new Program();
            p.doit(p.check);*/
            List<int> NumList = new List<int>() { 1, 4, 7, 3, 6, 15, 27, 18 };
            List<int> result = NumList.FindAll(i => i % 3 == 0);
            foreach(var r in result)
             { 
                Console.WriteLine(r);
          }
        }
    }
}
