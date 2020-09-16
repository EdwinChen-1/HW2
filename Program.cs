using System;

namespace HW2
{
    class Program
    {
        //Edwin Chen
        static void Main(string[] args)
        {
            string AccLG;
            string MktLG;
            string EcoLG;
            string MISLG;

            double AccGPA;
            double MktGPA;
            double EcoGPA;
            double MISGPA;

            Console.WriteLine("What is your grade percentage for Accounting");
            double AccPerc = Convert.ToDouble(Console.ReadLine());
            if (AccPerc >= 90.0)
            {
                AccLG = "A";
                AccGPA = 4;
            }
            else if (AccPerc >= 80.0)
            {
                AccLG = "B";
                AccGPA = 3;
            }
            else if (AccPerc >= 70.0)
            {
                AccLG = "C";
                AccGPA = 2;
            }
            else if (AccPerc >= 60.0)
            {
                AccLG = "D";
                AccGPA = 1;
            }
            else
            {
                AccLG = "F";
                AccGPA = 0;
            }

            Console.WriteLine("What is your grade percetnage for Marketing?");
            double MktPerc = Convert.ToDouble(Console.ReadLine());
            if (MktPerc >= 90.0)
            {
                MktLG = "A";
                MktGPA = 4;
            }
            else if (AccPerc >= 80.0)
            {
                MktLG = "B";
                MktGPA = 3;
            }
            else if (AccPerc >= 70.0)
            {
                MktLG = "C";
                MktGPA = 2;
            }
            else if (AccPerc >= 60.0)
            {
                MktLG = "D";
                MktGPA = 1;
            }
            else
            {
                MktLG = "F";
                MktGPA = 0;
            }

            Console.WriteLine("What is your grade percentage for Economics?");
            double EcoPerc = Convert.ToDouble(Console.ReadLine());
            if (EcoPerc >= 90.0)
            {
                EcoLG = "A";
                EcoGPA = 4;
            }
            else if (AccPerc >= 80.0)
            {
                EcoLG = "B";
                EcoGPA = 3;
            }
            else if (AccPerc >= 70.0)
            {
                EcoLG = "C";
                EcoGPA = 2;
            }
            else if (AccPerc >= 60.0)
            {
                EcoLG = "D";
                EcoGPA = 1;
            }
            else
            {
                EcoLG = "F";
                EcoGPA = 0;
            }

            Console.WriteLine("What is your grade percentage for MIS?");
            double MISPerc = Convert.ToDouble(Console.ReadLine());
            if (MISPerc >= 90.0)
            {
                MISLG = "A";
                MISGPA = 4;
            }
            else if (MISPerc >= 80.0)
            {
                MISLG = "B";
                MISGPA = 3;
            }
            else if (MISPerc >= 70.0)
            {
                MISLG = "C";
                MISGPA = 2;
            }
            else if (MISPerc >= 60.0)
            {
                MISLG = "D";
                MISGPA = 1;
            }
            else
            {
                MISLG = "F";
                MISGPA = 0;
            }

            Console.WriteLine("\t Your letter grade for Accouting is " + AccLG);
            Console.WriteLine("\t Your letter grade for Marketing is " + MktLG);
            Console.WriteLine("\t Your letter grade for Economics is " + EcoLG);
            Console.WriteLine("\t Your letter grade for MIS is " + MISLG);

            double totalGPA = (AccGPA + MktGPA + EcoGPA + MISGPA) * 3;
            int credits = 12;

            double GPA = totalGPA / credits;

            Console.WriteLine("Your GPA for the semester is " + GPA);

            Console.ReadKey();

        }
    }
}
