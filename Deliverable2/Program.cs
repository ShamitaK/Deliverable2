using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            String message = "";
            int checksum = 0; 
          
            Console.Write("What is your message? ");
            input = Console.ReadLine();
            input = input.ToUpper().Trim();
            // Console.WriteLine(input);

            int number = 0;
            foreach (char c in input) {
                number = c - 64;
                checksum += c;
                message += number + "-";
                 //Console.WriteLine(message);
            }
            message = message.TrimEnd(message[message.Length - 1]);

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);





            }
    }
}
