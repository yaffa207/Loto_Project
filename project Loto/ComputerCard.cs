using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Loto
{
    class ComputerCard
    {
        int[] arC = new int[6];
        bool b;
        private int index = 0;

        public ComputerCard()//constractor
        {
            for (int i = 0; i < arC.Length; i++)
            {
                arC[i] = 0;
            }
        }




        public bool ExistsNum(int num)
        {
            for (int i = 0; i < arC.Length; i++)
            {
                if (num == arC[i])
                {
                    b = true;
                    break;
                }
                else
                { b = false; }      
            }
            return b;
        }
        
        
        public void GenerateValue()
        {
            Random r = new Random();
            int num = r.Next(1, 46);

            Console.WriteLine("random number selected{0}",num);

            if (ExistsNum(num)==false) //randumNum exists in existsNum?
            {
                arC[index] = num;
                index++;
            }
        }


    }
}
