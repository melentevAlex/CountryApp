using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ThatCountryDoesNotExist : Exception
    {

        public override string Message
        {
            get
            {
                return "A country with that name does not exist";
            }
        }
    }

    public class AlreadyExistInDB : Exception
    {

        public override string Message
        {
            get
            {
                return "Such a country is already in the database. Information about it will not be saved";
            }
        }

    }
    public class InputMustContainsOnlyLetters : Exception
    {

        public override string Message
        {
            get
            {
                return "Country name can only contain latin letters";
            }
        }

    }
    public class MyException : Exception
    {

        public override string Message
        {
            get
            {
                return "You must enter at least 3 characters";
            }
        }

    }
}