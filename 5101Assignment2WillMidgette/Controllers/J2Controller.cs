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
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>total # of combinations by which the 2 dice can together roll the number 10</returns>
        [Route ("api/J2/DiceGame/{m}/{n}")]
        public string Get(int m, int n)
        {
            int i = 1;
            int comboCount = 0;
            string message = "";
            //Only positive integers are valid 
            if(n<=0 || m<=0)
            {
                message = "Invalid dice entry";
            }
            //if the # sides of the dice add to 10, there will always be 1 combination 
            else if (n + m == 10)
            {
                message = "There is 1 way to get the sum 10";
            }
            //for all other valid entries, the code below calculates the # combinations. Since whichever
            //n or m is lower will be the limiting factor in # combinations, use Math.Min/Max functions in for loop
            else 
            {
               for (i = 1; i <= Math.Min(n,m); i++)
               {
                  int remainder = 10 - i;
                  if (remainder <= Math.Max(n,m))
                  {
                     comboCount = comboCount + 1;
                  }
               }
               message = "There are " + comboCount + " ways to get the sum 10";
            }
           
            return message;
        }

    }
}
