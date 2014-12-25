using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList_test
{
    class Program
    {

        
        static void Main(string[] args)
        {
            ArrayList lsitsize = new ArrayList();
          
            //Console.WriteLine("arraylist size" + lsitsize.Count);
            lsitsize.Add(6);
            lsitsize.Add(8);
            foreach (var list in lsitsize)
            {
                Console.WriteLine(list);
                
            }
            int count = lsitsize.Count;
            Console.WriteLine("Number of count" + count);
            Console.WriteLine("index out" + lsitsize[1]);
            Console.ReadKey();
        }
    }
}
