using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Electricar_Board
{
    public class DiziParse
    {
        public static double[] konumdizi;
        public static String isaret="+";
        public static void diziParse(string s, double[] dest)
        {
            isaret = s[0].ToString();
            int j = 1;
            try
            {
                for (int i = 1; i < s.Length; i++)
                {

                    if ((i + 1) < s.Length)
                    {
                        if (s[i + 1] == '0')
                        {
                            dest[j] = ((Convert.ToInt32(s[i]) - 33)  + ((Convert.ToInt32(s[i + 2]) - 33)) / 100.0);
                            i += 2;
                        }
                        else
                        {
                            dest[j] = (System.Convert.ToInt32(s[i]) - 33);
                        }
                        j++;
                    }
                    else
                    {
                        dest[j] = (System.Convert.ToInt32(s[i]) - 33);
                        j++;
                    }

                }
            }
            catch (Exception)
            {             
            }         
        }
        public void konumParse(string s)
        {
            foreach (var item in s.Split(','))
            {
                konumdizi[0] =item[0];
                konumdizi[1] =item[1];
                konumdizi[2]=item[2];
            }
        }
    }
}
