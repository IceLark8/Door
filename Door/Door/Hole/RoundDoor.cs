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
    public class RoundDoor : IHole
    {
        public double Radius {get; set;}

        public RoundDoor()
        {
            double r;
            RoundDoorConstruct:
            Console.WriteLine("Enter your round door parameters:");
            try
            {
                Console.Write("\tRadius = ");
                r = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You should write positive numbers!!!!");
                goto RoundDoorConstruct;
            }
            Radius = r;
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

                    if (figureA*figureA + figureB*figureB < Radius*Radius)
                    {
                        return true;
                    }

                    return false;
                
                case "Cylinder":
                    
                    if (((Cylinder)obj).Radius < Radius)
                    {
                        return true;
                    }
                    
                    if(Math.Pow(((Cylinder)obj).Radius, 2) + Math.Pow(((Cylinder)obj).Height, 2) < Radius*Radius)
                    {
                        return true;
                    }

                    return false;
                
                case "Sphere":
                    if (((Sphere) obj).Radius < Radius)
                    {
                        return true;
                    }

                    return false;
            }

            return false;
        }
    }
}