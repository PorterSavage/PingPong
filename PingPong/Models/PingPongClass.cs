using System;
using System.Collections.Generic;
namespace PingPong
{
    public class PingPongClass
    {
        public static string Number(int userNumber)
        {
            if(userNumber % 3 == 0 && userNumber % 5 == 0)
            {
                return "ping-pong";
            }
            else if(userNumber % 3 == 0)
            {
                return "ping";
            }
            else if(userNumber % 5 == 0)
            {
                return "pong";
            }
            else
            {
                return userNumber.ToString();
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter a number and we will return a range from 1, up to your number:");
            int numberRange = int.Parse(Console.ReadLine());
            for(int i = 1; i<= numberRange; i ++)
            {
                string check = Number(i);
                Console.WriteLine(check);
            }
        }
    }
}