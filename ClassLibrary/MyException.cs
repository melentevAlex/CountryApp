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
                return "Страны с таким названием не существует";
            }
        }
    }

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
}