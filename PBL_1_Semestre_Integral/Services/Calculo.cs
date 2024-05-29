using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL_1_Semestre_Integral.Services
{
    public class Calculo
    {
        public static double FuncaoSegundoGrau(double x, double a, double b, double c)
        {
            return a * x * x + b * x + c;
        }
        public static double FuncaoSeno(double x, double a, double b, double c, double d)
        {
            return a * Math.Pow(Math.Sin(b * x), d) + c;
        }
        public static double FuncaoCosseno(double x, double a, double b, double c, double d)
        {
            return a * Math.Pow(Math.Cos(b * x), d) + c;
        }
        public static double FuncaoLog(double x, double a, double b, double c, double d)
        {
            return a * Math.Pow(Math.Log10(b * x), d) + c;
        }
        public static double FuncaoLN(double x, double a, double b, double c, double d)
        {
            return a * Math.Pow(Math.Log(b * x), d) + c;
        }
    }
}
