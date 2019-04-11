using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoloCombinatori
    {
        static public double Fattoriale(double numero)
        {
            double fattoriale = 1;

            for (int i = 1; i <= numero; i++)
            {
                fattoriale = fattoriale * i;
            }

            return fattoriale;
        }
    }
}
