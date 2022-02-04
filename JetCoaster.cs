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
            int goukei = 0;
            int youso = 0;
            int i = 1;//回数
            int j = 0;//配列の数
            int s =0;

            for (i = 1; i <= r; i++) //動作回数
            {

                for (j = 0; j <= g.Length-1; j++)　//定員人数
                {

                    if (goukei <= k)　//定員人数判定
                    {
                        goukei += g[youso];
                      

                        if (goukei > k)
                        {
                            goukei -= g[youso];
                            s += goukei;
                            goukei = 0;
                            break;
                        }
                        youso = youso + 1;
                        if(youso == g.Length)
                        {
                            youso = 0;
                        }
                     
                    }

                }
               
              
            }
            return s;
        }
    }
}

