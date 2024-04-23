namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
             static void stampa()
            {
                Console.Write($" ");
            }



            Console.WriteLine("cosa vuoi fare?");
            Console.WriteLine("1 per addizioni int");
            Console.WriteLine("2 per addizioni double");
            string scelta = Console.ReadLine();
            if (scelta == "1")
            {

                stampa();
                int ValoreUnoInt = Convert.ToInt32(Console.ReadLine());
                Console.Write("+");
                stampa();
                int ValoreDueInt = Convert.ToInt32(Console.ReadLine());

                int somma = CalcoliHelper.SommaInt(ValoreUnoInt, ValoreDueInt); ;
                Console.Write($" = {somma}");
            } 
            else if (scelta == "2")
            {
                stampa();
                double ValoreDoubleUNo = Convert.ToDouble(Console.ReadLine());
                Console.Write("+");
                stampa();
                double ValoreDoubleDue = Convert.ToDouble(Console.ReadLine());
                double sommaDouble = CalcoliHelper.SommaDouble(ValoreDoubleUNo, ValoreDoubleDue);
                Console.Write($" = {sommaDouble}");
            }
            else if (scelta == "3")
            {
                stampa();
                int ValoreUnoInt = Convert.ToInt32(Console.ReadLine());
                Console.Write("-");
                int ValoredueInt = Convert.ToInt32(Console.ReadLine());
                int DifferenzeINt = CalcoliHelper.DifferenzeINt(ValoreUnoInt, ValoredueInt);
                Console.WriteLine($" = {DifferenzeINt}");


            }
        }
    }
}
