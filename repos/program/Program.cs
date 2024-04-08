using System;

    namespace program

    {

        internal class Program

        {

            static void Main(string[] args)

            {

                Console.WriteLine("Hello, World!");
                Person student = new Person { FirstName = "abc", LastName = "efg" };
                Console.WriteLine(student.getname());

                Student mystudent = new Student();
                Console.WriteLine(mystudent.StudentNumber + " " + mystudent.getname());
                mystudent.setSSN("123");
                Console.WriteLine("The Student SSN is :" + mystudent.getSSN());

                GraduateStudent myGrad = new GraduateStudent();
                Console.WriteLine("Grad student need to" + myGrad.Study() + " and " + myGrad.Rest());
            }

        }

    }

   