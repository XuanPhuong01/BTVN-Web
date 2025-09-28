using System;
using Personal.CubicLib;


class Program
{
    static void Main()
    {
        Console.WriteLine("=== Phuong Ngu Cubic Console ===");
        Console.WriteLine("Enter coefficients for a*x^3 + b*x^2 + c*x + d = 0");
        try
        {
            Console.Write("a: "); double a = Double.Parse(Console.ReadLine());
            Console.Write("b: "); double b = Double.Parse(Console.ReadLine());
            Console.Write("c: "); double c = Double.Parse(Console.ReadLine());
            Console.Write("d: "); double d = Double.Parse(Console.ReadLine());


            CubicSolver solver = new CubicSolver();
            solver.A = a; solver.B = b; solver.C = c; solver.D = d;
            string message = solver.Solve();


            Console.WriteLine("\nResult:\n" + message);
            double[] roots = solver.Roots;
            if (roots != null && roots.Length > 0)
            {
                Console.WriteLine("Roots:\"");
            for (int i = 0; i < roots.Length; i++)
                    Console.WriteLine(" x{0} = {1:0.######}", i + 1, roots[i]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }


        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}