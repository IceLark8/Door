using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Door
{
    public class Parallelepiped : Figure
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Parallelepiped()
        {
            double l, w, h;
            ParallelepipedConstruct:
            Console.Write("Enter your parallelepiped parameters:");
            try
            {
                Console.Write("\tLength = ");
                l = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tWidth = ");
                w = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tHeight = ");
                h = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You should write positive numbers!!!!");
                goto ParallelepipedConstruct;
            }
            Length = l;
            Width = w;
            Height = h;
        }
    }
}
