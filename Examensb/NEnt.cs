using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examensb
{
    class NEnt
    {
    
        private int n;


        public NEnt()
        {
            n = 0;
        }


        public void Cargar(int dato)
        {
            n = dato;
        }

        public bool verifcapi()
        {
            bool b = false;
            int nu = 0;
            int aux = n;
            while (n > 0)
            {
                int dig = n % 10;
                n /= 10;
                nu = (nu * 10 + dig);
            }
            if (nu == aux)
            {
                b = true;
            }
            n = aux;
            return b;
        }
    }
}
