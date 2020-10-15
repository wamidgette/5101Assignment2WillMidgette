using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _5101Assignment2WillMidgette.Controllers
{
    public class J3Controller : ApiController
    {
        public int Get(string word)
        {
            int i = 0;
            string currLetter = Char.ToString(word[i]);
            string prevLetter = Char.ToString(word[i-1]);
            List<int> numberList = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> number2 = new List<string> { "a", "b", "c" };
            string message = "";
            int Index = FindIndex()
            return numberlist;
        }
    }
}
