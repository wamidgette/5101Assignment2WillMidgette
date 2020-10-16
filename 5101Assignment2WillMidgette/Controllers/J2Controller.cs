using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5101Assignment2WillMidgette.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Method takes 2 positive integers - m and n, each representing the # sides of a die 
        /// the code in this method calculates the total # of combinations by which the 2 dice can 
        /// together roll the number 10 using a for loop. 
        /// 
        /// </summary>
        /// <param name="M"></param>
        /// <param name="N"></param>
        /// <returns>total # of combinations by which the 2 dice can together roll the number 10</returns>
        [Route ("api/J2/DiceGame/{M}/{N}")]
        public string Get(int M, int N)
        {
            int i = 1;
            string message = "";
            int comboCount = 0;
            
            //Only positive integers are valid 
            if(N<=0 || M<=0)
            {
                message = "Invalid dice entry";
            }
            
            //for all other valid entries, the code below calculates the # combinations. Since whichever
            //n or m is lower will be the limiting factor in # combinations, use Math.Min/Max functions in for loop.
            //Also running condition i<=9 because after a die roll becomes larger than 9 there exists
            //no roll with the other die that will make the two of them add to 10.
            
            else 
            {
               for (i = 1; i <= Math.Min(N,M) && i<=9; i++)
               {
                  int remainder = 10 - i;
                  if (remainder <= Math.Max(N,M))
                  {
                     comboCount = comboCount + 1;
                  }
               }
               //distinguish 1 or many combinations and adjust message language
               if (comboCount < 2)
               {
                    message = "There is " + comboCount + " way to get the sum of 10";
               }
               else
               {
                    message = "There are " + comboCount + " ways to get the sum 10";
               }
            }
           
            return message;
        }

    }
}
