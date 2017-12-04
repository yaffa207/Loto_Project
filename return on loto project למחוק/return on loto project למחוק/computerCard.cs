using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_on_loto_project_למחוק
{
    class ComputerCard
    {
        int[] arComputer = new int[6];
        bool b;
        int index = 0;


        public ComputerCard()
        {
            for (int i = 0; i < arComputer.Length; i++)
            {
                arComputer[i] = 0;
            }
        }


        public bool ExistsNum(int num)
        {
            for (int i = 0; i < arComputer.Length; i++)
            {
                if (num == arComputer[i])
                {
                    b = true;
                    break;
                }
                else
                { b = false; }
            }
            return b;
        }


        public int[] GetarComputer()
        {
            return arComputer;
        }





        public void GeneralValue()
        {
            Random R = new Random();

            int somenumber = 1;
            while (somenumber > 0)
            {
                int numRandom = R.Next(1, 46);
                if (ExistsNum(numRandom) == false)
                {
                    if (numRandom > 0 && numRandom < 47)
                    {
                        if (index < arComputer.Length)
                        {
                            arComputer[index] = numRandom;
                          // Console.WriteLine("random number in arComputer[{0}] = {1}", index, numRandom);
                            index++;
                        }
                        else
                        {
                            break;//only in loop we can do break
                        }
                    }

                }
            }
        }

    }
}
