using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoAboutCountryApp
{
    public class MyException : Exception
    {

        public override string Message
        {
            get
            {
                return "Необходимо ввести не менее 3-х символов";
            }
        }

    }
    public class InputMustContainsOnlyLetters : Exception
    {

        public override string Message
        {
            get
            {
                return "Название страны может содержать только латинские буквы";
            }
        }

    }


}
