using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a, double b)
        {
            bool risposta = false;
            if (a != 0)
                risposta = true;
            return risposta;
        }
        public static bool IsInconsisted(double a, double b)
        {
            bool risposta2 = false;
            if (a == 0)
                risposta2 = true;
            return false;
        }
    }
}
