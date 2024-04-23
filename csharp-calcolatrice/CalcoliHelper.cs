using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal static class CalcoliHelper
    {

        public static int ValoreUnoInt;
        public static int ValoreDueInt;

        public static double ValoreDoubleUNo;
        public static double ValoreDoubleDue;



        public static int SommaInt(int ValoreUnoInt, int ValoredueInt)
        {
            return ValoreUnoInt + ValoredueInt;
        }

        public static double SommaDouble(double ValoreDoubleUNo, double ValoreDoubleDue)
        {
            return ValoreDoubleUNo + ValoreDoubleDue;
        }




        public static int DifferenzeINt(int ValoreUnoInt, int ValoredueInt)
        {
            return ValoreUnoInt - ValoredueInt;
        }

        public static double DifferenzeDouble(double ValoreDoubleUNo, double ValoreDoubleDue)
        {
            return ValoreDoubleUNo - ValoreDoubleDue;
        }



    }






}
