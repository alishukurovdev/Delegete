using System.Diagnostics;

namespace UlviMyazdiqi
{
     class Program
    {
        static int Num;

        static void Main(string[] args)
        {
            #region  Concurrrency
            //Loop2();
            //Loop1();
            //Thread t1= new Thread(Loop2);
            //Thread t2= new Thread(Loop1);
            //t1.Join();
            //t1.Start();
            //t2.Start();
            //Console.WriteLine("Salam");
            #endregion
            #region paralellism
            //Parallel.Invoke(Loop1, Loop2);
            //Console.WriteLine("Salam");
            #endregion
            #region Rase condition
            //Thread t1 = new Thread(Increase);
            //Thread t2 = new Thread(Decrease);
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //Console.WriteLine("Salam");
            //Increase();
            //Decrease();
            //Console.WriteLine(Num);
            #endregion
            // SeherYemeyi();
            #region Task
            SeherYemeyiAsync().Wait();

            #endregion
        }
        
        static async Task SeherYemeyiAsync()
        {
            Stopwatch sw = Stopwatch.StartNew();
           await Task.WhenAll(BoilSassuageAsync(), BoilSassuageAsync(),SufreHazirlamaAsync());
           //await BoilSassuageAsync();
           // await PreparaTeaAsync();
           // await SufeHazirlaAsync();
            Console.WriteLine(sw.ElapsedMilliseconds);

        }
        static async Task BoilSassuageAsync()
        {
           await Task.Delay(3000);
            Console.WriteLine("Saussage boiled");
        }
        static async Task PreparaTeaAsync()
        {
            Console.WriteLine("Caydan doldu");
           await Task.Delay(3000);
            Console.WriteLine("Su qaynadi");
            Console.WriteLine("CAy hazirdi");
        }
        static async Task SufreHazirlamaAsync()
        {
           await Task.Delay(1500);
            Console.WriteLine("Sufe hazir");
        }
        static void SeherYemeyi()
        {
            Stopwatch sw= Stopwatch.StartNew();
            PreparaTea();
            BoilSassuage();
            SufreHazirlama();
            Console.WriteLine(sw.ElapsedMilliseconds);

        }
        static void BoilSassuage()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Saussage boiled");
        }
        static void PreparaTea()
        {
            Console.WriteLine("Caydan doldu");
            Thread.Sleep(3000);
            Console.WriteLine("Su qaynadi");
            Console.WriteLine("CAy hazirdi");
        }
        static void SufreHazirlama()
        {
            Thread.Sleep(1500);
            Console.WriteLine("Sufe hazir");
        }


        static void Loop1()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("loop1 bitdi");
        }
        static void Loop2()
        {
            for (int i = -500; i < 0; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("loop");
        }
        static void Increase()
        {
            for (int i = 0; i < 500; i++)
            {

                Num++;
        } }
        static void Decrease()
        {
            for (int i = 0; i < 500; i++)
            {

                Num--;
            }
        }
    }
}
