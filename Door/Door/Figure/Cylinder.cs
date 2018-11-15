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
    public class Cylinder : Figure
    {
        public double Height { get; set; }
        public double Radius { get; set; }

        public Cylinder()
        {
            double h, r;
            CylynderStruct:
            Console.WriteLine("Enter your cylinder parameters");
            try
            {
                Console.Write("\tHeight = ");
                h = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tRadius = ");
                r = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You should write positive numbers!!!!");
                goto CylynderStruct;
            }
            Height = h;
            Radius = r;
        }
    }
}