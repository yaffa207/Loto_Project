using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Loto
{
    class CheckPlay
    {
        UserCard user;
        ComputerCard computer;
        int corectAnswer;


        public CheckPlay(UserCard _user,ComputerCard _computer)
        {
            user = _user;
            computer = _computer;
        }



        public int Compare()
        {
            for (int i = 0; i < 6; i++)//Length of both arry
            {
                int userInput = user.GetUserInput(i);

                if (computer.ExistsNum(userInput))
                {
                    corectAnswer++;
                }
            }
            return corectAnswer; 
        }


    }
}
