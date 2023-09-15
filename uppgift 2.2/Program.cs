using System;

class Program
{
    static void Main()
    {
        Console.Write("Ange längden Elin hoppade (i meter): ");
        double elinLängd = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ange längden Alma hoppade (i meter): ");
        double almaLängd = Convert.ToDouble(Console.ReadLine());

        double längreHopp = elinLängd - almaLängd;

        if (längreHopp > 0)
        {
            Console.WriteLine($"Elin hoppade {längreHopp:F2} meter längre än Alma.");
        }
        else if (längreHopp < 0)
        {
            Console.WriteLine($"Alma hoppade {-längreHopp:F2} meter längre än Elin.");
        }
        else
        {
            Console.WriteLine("Elin och Alma hoppade lika långt.");
        }
    }
}
