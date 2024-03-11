using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net209
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so nguyen i = ");
            int i = int.Parse(Console.ReadLine());

            //int i = 10;
            /*if ( i%2 == 0) 
            {
                Console.WriteLine("Day la so chan ");
            }
            else
            {
                Console.WriteLine("Day la so le ");
            };*/

            //dung toan tu 3 ngoi

            Console.WriteLine(i % 3 == 0 ? "So chia het cho 3" : "So khong chia het cho 3" ); // ? = if, : = else
            
            Console.ReadKey();
        }
    }
}
