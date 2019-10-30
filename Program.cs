using System;

namespace Encapulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person1 = new Person();

            //Q​: Try to ​instantiate ​a ​new person​​in ​program.cs​.Can you directly access thevariables​?

            //A: yes we can directly access the private variables as we do with public variables
            //we need to use get set methods

            //person1.Fname = "Robert";
            //person1.Lname = "scott";
            //person1.Age = 22;
            //person1.Height = 175;
            //person1.Weight = 58;

            //Console.WriteLine($" the {person1.Fname} , { person1.Lname} has age  { person1.Age}");

            var personhandler1 = new PersonHandler();

            person1 = personhandler1.createperson("Mike", "herold", 44, 178, 66.6);
                     

            personhandler1.SetAge(person1,33);
            Console.WriteLine(person1.getage());

            personhandler1.UpdateHeightWeight(person1, 180, 70);
            Console.WriteLine(person1.getheight());
            Console.WriteLine(person1.getweight());




        }  
    }
}
