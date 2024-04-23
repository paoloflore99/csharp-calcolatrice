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

            int ValoreI()
            {
               return  Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("cosa vuoi fare?");
            Console.WriteLine("1 Somma di due numeri interi");
            Console.WriteLine("2 Somma di due numeri double");
            Console.WriteLine("3 Differenza tra due numeri interi");
            Console.WriteLine("4 Differenza tra due numeri double");
            Console.WriteLine("5 Moltiplicazione di due numeri interi");
            Console.WriteLine("6 Moltiplicazione di due numeri double");
            Console.WriteLine("7 Valore assoluto di un numero intero");
            Console.WriteLine("8 Valore assoluto di un numero double");
            Console.WriteLine("9 Minimo tra due numeri interi");
            Console.WriteLine("10 Minimo tra due numeri double");
            Console.WriteLine("11 Massimo tra due numeri interi");
            Console.WriteLine("12 Massimo tra due numeri double");
            string scelta = Console.ReadLine();
            if (scelta == "1")
            {

                stampa();
                int ValoreUnoInt = ValoreI();
                Console.Write("+");
                stampa();
                int ValoreDueInt = ValoreI();

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
                int ValoreUnoInt = ValoreI();
                Console.Write("-");
                stampa();
                int ValoredueInt = ValoreI(); ;
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
                int ValoreUnoInt = ValoreI(); ;
                Console.Write("*");
                stampa();
                int ValoredueInt = ValoreI();
                int MoltiplicareInt =CalcoliHelper.MoltiplicareInt(ValoreUnoInt, ValoredueInt);
                Console.WriteLine($" = {MoltiplicareInt}");
            }
            else if (scelta == "6")
            {
                stampa();
                double ValoreDoubleUNo = Convert.ToDouble(Console.ReadLine());
                Console.Write("*");
                stampa();
                double ValoreDoubleDue = Convert.ToDouble(Console.ReadLine());
                double MoltiplicareDou = CalcoliHelper.MoltiplicareDou(ValoreDoubleUNo, ValoreDoubleDue);
                Console.WriteLine($" = {MoltiplicareDou}");
            }
            else if (scelta == "7")
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
            else if (scelta == "8") 
            {
                stampa();
                double ValoreDoubleUNo = Convert.ToDouble(Console.ReadLine());
                if(ValoreDoubleUNo < 0)
                {
                    string negativo = ValoreDoubleUNo.ToString();
                    string risultato = "+" + negativo;
                    Console.WriteLine($" = {risultato}");
                }
            }
            else if (scelta == "9")
            {
                stampa();
                int ValoreUnoInt = ValoreI();
                stampa();
                int ValoredueInt = ValoreI(); 
                if (ValoreUnoInt > ValoredueInt)
                {
                    Console.WriteLine($" = {ValoredueInt}");
                }
                else
                { Console.WriteLine($" = {ValoreUnoInt}");
                }
            }
            else if (scelta == "10")
            {
                stampa();
                double ValoreDoubleUNo = Convert.ToDouble(Console.ReadLine());
                stampa();
                double ValoreDoubleDue = Convert.ToDouble(Console.ReadLine());
                if (ValoreDoubleUNo > ValoreDoubleDue)
                {
                    Console.WriteLine($" = {ValoreDoubleDue}");
                }
                else
                {
                    Console.WriteLine($" = {ValoreDoubleUNo}");
                }
            }
            else if (scelta == "11")
            {

                stampa();
                int ValoreUnoInt = ValoreI();
                stampa();
                int ValoredueInt = ValoreI();
                if (ValoreUnoInt > ValoredueInt)
                {
                    Console.WriteLine($" = {ValoreUnoInt}");
                }
                else
                {
                    Console.WriteLine($" = {ValoredueInt}");
                }
            }
            else if (scelta == "12")
            {
                stampa();
                double ValoreDoubleUNo = Convert.ToDouble(Console.ReadLine());
                stampa();
                double ValoreDoubleDue = Convert.ToDouble(Console.ReadLine());
                if (ValoreDoubleUNo > ValoreDoubleDue)
                {
                    Console.WriteLine($" = {ValoreDoubleUNo}");
                }
                else
                {
                    Console.WriteLine($" = {ValoreDoubleDue}");
                }
            }
            else if (scelta != "1"  )
            {

            }
        }
    }
}
