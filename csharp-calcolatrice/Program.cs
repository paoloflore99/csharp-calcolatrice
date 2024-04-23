using System.Security;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
             static void stampa()
            {
                Console.Write($"inserisci numero  ");
            }

            static void ValoreI()
            {
                int ValoreUnoInt = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("cosa vuoi fare?");
            Console.WriteLine("1 per addizioni int");
            Console.WriteLine("2 per addizioni double");
            Console.WriteLine("3 per sotrazione double");
            Console.WriteLine("4 per sotrazione double");
            Console.WriteLine("5 per moltiplicare double");
            Console.WriteLine("6 per moltiplicare double");
            Console.WriteLine("7 per moltiplicare double");
            Console.WriteLine("8 per moltiplicare double");
            Console.WriteLine("9 ottieni valore assoluto");
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
                stampa();
                int ValoredueInt = Convert.ToInt32(Console.ReadLine());
                int DifferenzeINt = CalcoliHelper.DifferenzeINt(ValoreUnoInt, ValoredueInt);
                Console.WriteLine($" = {DifferenzeINt}");
            } 
            else if (scelta == "4")
            {
                stampa();
                double ValoreDoubleUNo = Convert.ToDouble(Console.ReadLine());
                Console.Write("-");
                stampa();
                double ValoreDoubleDue = Convert.ToDouble(Console.ReadLine());
                double DifferenzeDouble = CalcoliHelper.DifferenzeDouble(ValoreDoubleUNo, ValoreDoubleDue);
                Console.WriteLine($" = {DifferenzeDouble}");
            }
            else if(scelta == "5")
            {
                stampa();
                int ValoreUnoInt = Convert.ToInt32(Console.ReadLine());
                Console.Write("*");
                stampa();
                int ValoredueInt = Convert.ToInt32(Console.ReadLine());
                int MoltiplicareInt =CalcoliHelper.DifferenzeINt(ValoreUnoInt, ValoredueInt);
                Console.WriteLine($" = {MoltiplicareInt}");
            }
            else if (scelta == "6")
            {
                stampa();
                double ValoreDoubleUNo = Convert.ToDouble(Console.ReadLine());
                Console.Write("*");
                stampa();
                double ValoreDoubleDue = Convert.ToDouble(Console.ReadLine());
                double MoltiplicareDou = CalcoliHelper.DifferenzeDouble(ValoreDoubleUNo, ValoreDoubleDue);
                Console.WriteLine($" = {MoltiplicareDou}");
            }
            else if (scelta == "9")
            {
                stampa();
                int ValoreUnoInt = Convert.ToInt32(Console.ReadLine());
                if (ValoreUnoInt > 0)
                {
                   string positivo = ValoreUnoInt .ToString();
                   string risultato= "+" +  positivo ;
                    Console.WriteLine($" = {risultato}");
                }

                
            }
            else if (scelta == "10") 
            {
                stampa();
                double ValoreDoubleUNo = Convert.ToDouble(Console.ReadLine());
                if(ValoreDoubleUNo < 0)
                {
                    string negativo = ValoreDoubleUNo.ToString();
                    string risultato = "-" + negativo;
                    Console.WriteLine($" = {risultato}");
                }
            }
            else if (scelta == "11")
            {

            }
        }
    }
}
