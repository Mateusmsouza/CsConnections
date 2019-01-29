using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsConnections
{
    class FormatLine
    {
        public static String FormatString(String line)
        {
            string[] index = line.Split(' ');
            
            index = index.Where((value, indx) => index[indx].Length > 1).ToArray();


            return ConvertString(index);
        }

        private static String ConvertString(String[] line)
        {
            try
            {
                return ("Tempo de acesso: "+CalcString(line[2].ToString(), line[4].ToString())+" ID Acessada: "+line[0]+" Data "+line[1]);
            }catch(Exception exception)
            {
                return "Um problema na conversão de tempo ocorreu nesta linha";
            }
        }

        public static String CalcString(String time1, String time2)
        {
            String h1 = time1.Split(':')[0];
            String m1 = time1.Split(':')[1];
            String s1 = time1.Split(':')[2];

            String h2 = time2.Split(':')[0];
            String m2 = time2.Split(':')[1];
            String s2 = time2.Split(':')[2];

            int segundosIniciais = makeItSecond(Convert.ToInt32(h1), Convert.ToInt32(m1), Convert.ToInt32(s1));
            int segundosFinais = makeItSecond(Convert.ToInt32(h2), Convert.ToInt32(m2), Convert.ToInt32(s2));


            int segundos = segundosFinais - segundosIniciais;
            return makeItHour(segundos);

        }

        public static int makeItSecond(int h, int m, int s)
        {
            return ((h * 3600) + (m * 60) + s);
        }

        public static String makeItHour(int segundos)
        {
            int horas = (segundos - (segundos % 3600)) / 3600;
            segundos = (segundos % 3600);
            int minutos = (segundos - (segundos % 60)) / 60;
            segundos = segundos % 60;

            String strHoras = horas.ToString().Length == 1 ? "0" + horas.ToString() : horas.ToString();
            String strMinutos = minutos.ToString().Length == 1 ? "0" + minutos.ToString(): minutos.ToString();
            String strSegundos = segundos.ToString().Length == 1 ? "0" + segundos.ToString() : segundos.ToString();

            return (strHoras + ":" + strMinutos + ":" + strSegundos);
        }
    }
}
