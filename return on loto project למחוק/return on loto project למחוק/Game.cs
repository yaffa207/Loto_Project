using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_on_loto_project_למחוק
{
    class Game
    {
        public Game()//constractor
        {
            UserCard user = new UserCard();//mofa
            Console.WriteLine("enter your name:");
            string str1 = Console.ReadLine();
            user.Name = str1;
            Console.WriteLine("Hi {0}", str1);


            Input input = new Input(user);//input 6 numbers
            input.GetUserValues();

            Console.WriteLine("********************************************");
            ComputerCard computer = new ComputerCard();//mofa
            computer.GeneralValue();//the computer select general numbers


            CheckPlay Check = new CheckPlay(user, computer);//comper
            

            Output.Write(Check.Compare());//you Guessed righ

            
            Console.ReadLine();
        }

        

    }
}
