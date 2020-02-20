using System;
using System.Collections.Generic;
using System.Text;

namespace Eventer.Classes
{
    class User
    {
        private long id;
        string name;
        string surname;
        string email;
        string password;
        string nick;
        string state;  //user, moderator, admin
        Rate rate;
    }
}
