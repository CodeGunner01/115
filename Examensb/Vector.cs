using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Examensb
{
    class Vector
    {
        const int MAX = 50;
        private int[] v;
        private int n;

        public Vector()
        {
            n = 0;
            v = new int[MAX];
        }

        public void Cargar(int n1, int a, int b)
        {
            Random r = new Random();
            int i;
            n = n1;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b);
            }
        }

        public void Cargar(int ele)
        {
            n++;
            v[n] = ele;
        }

        public void cargardato(int nele)
        {
            n = nele;
            int num = n;
            for (int i = 1; i <= num; i++)
            {
                v[i] = Conversions.ToInteger(Interaction.InputBox(" ", " "));
            }
        }

        public string Descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + v[i] + " | ";
            }
            return s;
        }
        //PREGUNTA 1
        public void UnionEle(Vector ve, Vector vr)
        {

            for (int i = 1; i <= n; i++)
            {

                if (!(vr.SeEncuentra(v[i])))
                {

                    vr.Cargar(v[i]);
                }
            }

            for (int i = 1; i <= ve.n; i++)
            {

                if (!(vr.SeEncuentra(ve.v[i])))
                {

                    vr.Cargar(ve.v[i]);
                }
            }

            vr.OrdBurbuja();
        }

        public bool SeEncuentra(int nbus)
        {
            int i = 1;
            bool b = false;
            while ((i <= n) && (b == false))
            {
                if (v[i] == nbus)
                {
                    b = true;
                }
                i++;
            }
            return b;
        }

        public void OrdBurbuja()
        {
            int num = n;
            checked
            {
                for (int i = 1; i <= num; i++)
                {
                    int num2 = i + 1;
                    int num3 = n;
                    for (int j = num2; j <= num3; j++)
                    {
                        if (v[i] > v[j])
                        {

                            Intercambio(i, j);
                        }
                    }
                }
            }
        }

        public void Intercambio(int a, int b)
        {
            int aux;

            aux = v[a];
            v[a] = v[b];
            v[b] = aux;
        }


        //PREGUNTA 2

        public void ejercicio2()
        {
            NEnt n1 = new NEnt();
            NEnt n2 = new NEnt();

            for (int p = 1; p <= n; p++)
            {
                for (int d = p + 1; d <= n; d++)
                {
                    n1.Cargar(v[d]);
                    n2.Cargar(v[p]);

                    if (n1.verifcapi() && (!(n2.verifcapi())) ||
                        n1.verifcapi() && n1.verifcapi() && (v[p] > v[d]) ||
                        (!(n1.verifcapi()) && !(n2.verifcapi())) && (v[p] < v[d]))
                    {
                        Intercambio(p, d);

                    }

                }

            }

        }

    }
}
