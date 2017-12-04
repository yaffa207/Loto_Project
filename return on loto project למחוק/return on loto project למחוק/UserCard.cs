using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_on_loto_project_למחוק
{
    class UserCard
    {
        bool b;
        private string name;
        int numberAlreadyInserted;
        private int index = 0;
        int[] arUser = new int[6];


        public UserCard()//constractor
        {
            for (int i = 0; i < arUser.Length; i++)
            {
                arUser[i] = 0;
            }
        }

        

        //set get name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }



        //number exists ? true,false bool b;
        public bool ExistsNum(int num)
        {
            for (int i = 0; i < arUser.Length; i++)
            {
                if (num == arUser[i])
                { b = true; 
                    break;
                }
                else
                { b = false; }
            }
            return b;
        }



        //int numberAlreadyInserted;
        //private int index=0;
        public void AddNum(int newNum)
        {
            if (numberAlreadyInserted < 6)
            {
                if (ExistsNum(newNum) == false)
                {
                    arUser[index] = newNum;
                    numberAlreadyInserted++;//counter
                    index++;
                }
            }
        }

        public int[] GetarUser()
        { return arUser; }
    }
}
