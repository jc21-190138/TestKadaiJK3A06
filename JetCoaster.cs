using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jet
{
    public class JetCoaster
    {
        public static int ride(int k, int[] g, int r)
        {
            int[] hako = new int[g.Length];
            Array.Copy(g, hako, g.Length);

            int goukei = 0;
            int p;
            int teisu = k;

            for (int i = 0; i <r;i++)
            {
                k = teisu;
                int count = 0;



                for (int j = 0; j < g.Length; j++)
                {
                    if (k >= g[j])
                    {
                        k = k - g[j];
                        goukei = goukei + g[j];
                        count = count + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                for (int n = 0; n < count; n++)
                {
                    p = g[0];
                    for (int m = 0; m < g.Length; m++)
                    {
                        if (m == g.Length - 1)
                        {
                            g[m] = p;
                        }
                        else
                        {
                            g[m] = g[m + 1];
                        }

                    }

                }


            }
            Array.Copy(hako, g, hako.Length);
            return goukei;
        }
    }
}

    


