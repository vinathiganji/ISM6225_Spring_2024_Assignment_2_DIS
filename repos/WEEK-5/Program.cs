using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace ConsoleApp4_6mar

{

    internal class Person

    {

        public static string salutationMr = "Mr.";

        public static string salutationMs = "Ms.";

        public string FirstName;

        public string LastName;

        public string salutation;

        public string getname()

        {

            return FirstName + " " + LastName;

        }

    }

}