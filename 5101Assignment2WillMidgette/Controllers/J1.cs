using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;

namespace _5101Assignment2WillMidgette.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Enter menu item number for each part of meal 
        /// </summary>
        /// <param name="burger"></param>
        /// <param name="drink"></param>
        /// <param name="side"></param>
        /// <param name="desert"></param>
        /// <returns>Returns the total calorie count of meal</returns>
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{desert}")]
        public int Get(int burger, int drink, int side, int desert)
        {
            List<int> burCal = new List<int> { 461, 431, 420, 0 };
            int calSum1 = burCal[(burger - 1)];

            List<int> drinkCal = new List<int> { 130, 160, 118, 0 };
            int calSum2 = drinkCal[(drink - 1)];

            List<int> sideCal = new List<int> { 100, 57, 70, 0 };
            int calSum3 = sideCal[(side - 1)];

            List<int> dessertCal = new List<int> { 167, 266, 75, 0 };
            int calSum4 = dessertCal[(desert - 1)];

            int TotalCalories = calSum1 + calSum2 + calSum3 + calSum4;

            return TotalCalories;
        }
    }
}
