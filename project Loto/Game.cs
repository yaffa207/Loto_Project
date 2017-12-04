using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Loto
{
    class Game
    {
        //UserCard user;
        //ComputerCard computer;

        public Game()
        {
            
            UserCard U = new UserCard();
            Input I = new Input(U);//the constractor take all from the object of usercard
            ComputerCard C = new ComputerCard();
            CheckPlay check = new CheckPlay(U, C);



            //input name from user
            Console.WriteLine("enter your name");
            string str = Console.ReadLine();
            U.NamePlayer=str;
            Console.WriteLine("Hi {0}", U.NamePlayer);



            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("enter integer number from 1-46 (do not enterd twice the same number)");
                string str1 = Console.ReadLine();
                int a;
                if (int.TryParse(str1, out a) &&  a>0  &&   a<47 )
                {
                    if (U.ExistsNum(a) == false)//if the number dosent exist
                    {
                        I.GetUserValues(a);
                    }
                    else
                    {
                        Console.WriteLine("you already entered this number");
                    }
                }
                else
                {
                    Console.WriteLine("Error! enter only integer numbers between 1-46");
                }
            }
            Output.Write(check.Compare());
            
            Console.ReadLine();
        }
    }
}
