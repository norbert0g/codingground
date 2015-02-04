using System;
namespace BMI
{
    class BMI
    {
        static void Main()
        {
            //liczmy BMI
            // BMI = masa ciała / (wzrost)kwadrat
            double b; //BMI
            double m; //masa
            double w; //wzrost
            double wm; //wzrost w metrach
            //przedzialy BMI
            double bnmax; //niedowaga max BIM <= 18,5
            bnmax = 18.5;
            //norma min BIM > 18,5
            double bomax; //norma max BIM <= 25
            bomax = 25;
            //nadwaga min BIM > 25
            double bdmax; //nadwaga max BIM <= 30
            bdmax = 30;
            //otylosc min BIM > 30
            //otylosc max BIM sky is the limit
            
            Console.WriteLine ("Podaj swoja wage w kilogramach:");
            m=Convert.ToInt64 (Console.ReadLine());
            Console.WriteLine ("Podaj swoj wzrost w centymetrach:");
            wm=Convert.ToInt64 (Console.ReadLine());
            w=wm/100;
            b=m/(w*w);
            Console.WriteLine ("Wskaznik BMI dla podanej przez Ciebie wagi:");
            Console.WriteLine (m);
            Console.WriteLine ("oraz wzrostu:");
            Console.WriteLine (w);
            Console.WriteLine ("wynosi:");
            Console.WriteLine (b);
            if (b<=bnmax)
            {
                Console.WriteLine ("UWAGA!");
                Console.WriteLine ("masz niedowage");
                Console.WriteLine ("Swoja codzienna diete wzbogac o paczek po kazdym posiluku");
            }
            else
            {
                if (b<=bomax)
                {
                    Console.WriteLine ("Jestes zajebisty / zajebista");
                    Console.WriteLine ("Tak trzymaj a twoja zajebistosc nie przeminie");
                }
                else
                {
                if (b<=bdmax)
                {
                    Console.WriteLine ("Jest do czego sie przytulic");
                    Console.WriteLine ("Przyda Ci sie wiecej ruchu");
                }
                else
                {
                    Console.WriteLine ("UWAGA!");
                    Console.WriteLine ("Jestes otyly / otyla");
                    Console.WriteLine ("WHO zakwalifikowala Twoj stan jako chorobe");
                    Console.WriteLine ("a GreenPeace zaniesie Cie do wody przy najblizszym spotkaniu na plazy");
                }
                }
            }
            Console.ReadLine();
        }
    }
}