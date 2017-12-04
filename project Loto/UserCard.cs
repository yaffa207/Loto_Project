using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Loto
{
    class UserCard
    {

        int[] ar = new int[6];
        private int index = 0;//arry
        private bool b;
        private int NumbersAlreadyInserted;
        

        public UserCard()//constractor
        {
            for (int i = 0; i < ar.Length; i++)
            {
                 ar[i]=0;
            }
        }


        private string name; //name set get
        public string NamePlayer
        {
            get { return name; }
            set { name = value; }
        }




        public int GetUserInput(int _index)
        {
            return ar[_index];
        }





        public bool ExistsNum(int num)//funcation number exists
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (num == ar[i])
                {
                    b = true;
                    break;
                }
                else
                { b = false; } 
            }
            return b;
        }
       

        public void AddNum(int newNum)
        {
            if(ExistsNum(newNum) == false)//if not exists enter the new num
            {             
                ar[index] = newNum;
                NumbersAlreadyInserted++;
                index++;
            }
            
        }


    }
}
