using System;
using System.Collections.Generic;
using System.Text;

namespace Week2Challenge1
{
    public class Greeter
    {
       public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void SayGoodbye(string name)
        {
            Console.WriteLine("Have a nice day " + name);
        }
        public void ProperSalutation(string name)
        {
            DateTime timeOfDay = DateTime.Now;

            //* int ifHour = 3;

            int ifHour = timeOfDay.Hour;

            if (ifHour > 21)
                Console.WriteLine("Have a nice night " + name);
            else if (ifHour > 17)
                Console.WriteLine("Have a nice evening " + name);
            else if (ifHour > 12)
                Console.WriteLine("Have a nice afternoon " + name);
            else if (ifHour > 7)
                Console.WriteLine("Have a nice morning " + name);
            else
                Console.WriteLine("You need to go back to bed " + name);

       } 
    }
}
