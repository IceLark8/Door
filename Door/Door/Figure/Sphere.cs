using System;
namespace Door
{
    public class Sphere : Figure
    {
        public double Radius { get; set; }

        public Sphere()
        {
            double r;
            SphereConstruct:
            Console.WriteLine("Enter your sphere parameters:");
            try
            {
                Console.Write("\tRadius = ");
                r = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("You should write positive numbers!!!!");
                goto SphereConstruct;
            }
            Radius = r;
        }
    }
}
