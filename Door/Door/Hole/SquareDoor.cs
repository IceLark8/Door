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
    public class SquareDoor : IHole
    {
        double Height { get; set; }
        double Width { get; set; }

        public SquareDoor()
        {
            double h, w;
            SquareDoorConstruct:
            Console.WriteLine("Enter your square door parameters:");
            try
            {
                Console.Write("\tHeight = ");
                h = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tWidth = ");
                w = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You should write positive numbers!!!!");
                goto SquareDoorConstruct;
            }
            Height = h;
            Width = w;
        }

        public bool Fit(Figure obj)
        {
            switch (obj.GetType().ToString())
            {
                case "Parallelepiped":
                    double figureA = Double.MaxValue;
                    double figureB = Double.MaxValue;

                    List<double> sides = new List<double>() { ((Parallelepiped)obj).Length, ((Parallelepiped)obj).Height, ((Parallelepiped)obj).Length };

                    foreach (double c in sides)
                    {
                        if (c < figureA)
                        {
                            figureB = figureA;
                            figureA = c;
                        }
                        else if (c < figureB)
                        {
                            figureB = c;
                        }
                    }

                    if ((figureA < Height && figureB < Width ) || (figureB < Height && figureA < Width))
                    {
                        return true;
                    }

                    return false;
                
                case "Cylinder":
                    if (((Cylinder)obj).Radius < ((Cylinder)obj).Height)
                    {
                        if (((Cylinder)obj).Radius < Width && ((Cylinder)obj).Radius < Height)
                        {
                            return true;
                        }
                    }
                    if((((Cylinder)obj).Radius*2 < Height && ((Cylinder)obj).Height < Width) || (((Cylinder)obj).Radius*2 < Width && ((Cylinder)obj).Height < Height))
                    {
                        return true;
                    }

                    return false;
                
                case "Sphere":
                    if (((Sphere) obj).Radius * 2 < Height && ((Sphere) obj).Radius * 2 < Width)
                    {
                        return true;
                    }

                    return false;
            }

            return false;
        }
    }
}
