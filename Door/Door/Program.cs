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
    public class Program
    {
        public static void Main(string[] args)
        {
            StartProgram:
            
            Console.WriteLine("1.Start the program\n2.Exit");
            switch (Console.ReadLine())
            {
                default:
                    Console.WriteLine("You should input number 1 or 2!");
                    goto StartProgram;
                    
                case "1":
                    goto CreateHole;
                
                case "2":
                    return;
            }
            
            CreateHole:
            
            Console.WriteLine("Choose door type:\n\t1. Square door\n\t2. Round door");
            IHole hole;
            switch (Console.ReadLine())
            {
                default:
                    Console.WriteLine("You should input number 1 or 2!");
                    goto CreateHole;
                    
                case "1":
                    
                    hole = new SquareDoor();

                    break;
                
                case "2":

                    hole = new RoundDoor();

                    break;
            }
            
            CreateFigure:
            
            Console.WriteLine("Choose figure type:\n\t1. Parallelepiped\n\t2. Cylinder\n\t3.Sphere");
            Figure fig;
            switch (Console.ReadLine())
            {
                default:
                    Console.WriteLine("You should input number 1, 2 or 3!");
                    goto CreateFigure;
                    
                case "1":
                    
                    fig = new Parallelepiped();

                    break;
                
                case "2":

                    fig = new Cylinder();

                    break;
                
                case "3":
                    
                    fig = new Sphere();

                    break;
            }

            switch (hole.Fit(fig))
            {
                case true:
                    Console.WriteLine("Your figure fits in door");
                    break;
                
                case false:
                    Console.WriteLine("Your figure fits in door");
                    break;
            }
        }
    }
}
