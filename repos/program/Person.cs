using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace program

{

    internal class Person

    {

        public static string salutationMr = "Mr.";

        public static string salutationMs = "Ms.";

        public string FirstName;

        public string LastName;

        public string salutation;

        public Person()
        {
            FirstName = "ABC";
            LastName = "QWE";
            salutation = salutationMs;
        }
        public Person( string firstName, string lastName, string salutation)
        {
            FirstName = firstName;
            LastName = lastName;
            this.salutation = salutationMs;
        }
        public string getname()

        {

            return FirstName + " " + LastName;

        }

    }

}