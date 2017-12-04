using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_on_loto_project_למחוק
{
    class Input
    {
        UserCard user;
        //int inputUser;


        public Input(UserCard _user)//constractor
        { user = _user; }

        
        //enter 6 numbers from the user
        public void  GetUserValues()
        {
            for (int i = 0; i < 6;)
            {
                Console.WriteLine("enter integer number between 1-46");
                string str = Console.ReadLine();
                int a;
                if (int.TryParse(str, out a) && a > 0 && a < 46)
                {
                    if (user.ExistsNum(a)==false)
                    {
                        user.AddNum(a);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("you alreay entered this number");
                    }
                }
                else
                {
                    Console.WriteLine("error! plase enter number between 1-46");
                }
            }
            
        }




    }
}
