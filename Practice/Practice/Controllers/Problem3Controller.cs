using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class Problem3Controller : Controller
    {
        //
        // GET: /Problem3/

        public ActionResult Index()
        {
            long original = 600851475143;
            //int original = 125;
            int stevilo = 2;
            int rezultat = 0;
            ViewData["bla"] = original % stevilo;

            while (original != 1)
            {
                while (original % stevilo != 0)
                {
                    stevilo++;
                }
                while (original % stevilo == 0)
                {
                    rezultat = stevilo;
                    original /= stevilo;
                }
            }
            //6857
            /*
            while (original != 1)
            {
                while (!IsItDivisor(original, stevilo))
                {
                    stevilo++;
                }
                while (IsItDivisor(original, stevilo))
                {
                    rezultat = stevilo;
                    original /= stevilo;
                }
                original--;
            }*/
            ViewData["result"] = rezultat;
            ViewData["bla"] = original;
            return View();
        }


    }
}
