using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Loto
{
    class Input
    {
        UserCard card;
        int InputUser;

        public Input(UserCard _card)//constractor
        {
            card = _card;
        }

        //enter in program 6 numbers
        public void GetUserValues(int _InputUser)//corect input
        {
            InputUser = _InputUser;
            card.AddNum(InputUser);
        }


    }
}
