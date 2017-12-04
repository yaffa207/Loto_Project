using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_on_loto_project_למחוק
{
    class CheckPlay
    {
        UserCard user;
        ComputerCard Computer;
       

        public CheckPlay(UserCard _user,ComputerCard _Computer)
        {
            user = _user;
            Computer = _Computer;
        }

        


        int success = 0;
        public int Compare()
        {
          //  int[] arComputer = Computer.GetarComputer();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (Computer.GetarComputer()[i] == user.GetarUser()[j])
                    { success++; }                 
                }
            }
            return success;
        }
    }
}
