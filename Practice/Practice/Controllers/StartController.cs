﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class StartController : Controller
    {
        //
        // GET: /Start/
        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult Problem3()
        {
            long original = 600851475143;
            //int original = 125;
            int stevilo = 2;
            int rezultat = 0;

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
            ViewData["result"] = rezultat;
            return View("Problem3");
        }
        public ActionResult Problem4()
        {
            int fx = -1;
            int fy = -1;
            int konRezultat = -1;
            ViewData["bla"] = "SUU";
            bool tBrake = false;
            for (int x = 999; x > 99; x--)
            {
                for (int y = 999; y > 99; y--)
                {
                    int rezultat = x * y;
                    int dolzina = rezultat.ToString().Length;
                    for (int i = 0; i < rezultat.ToString().Length; i++)
                    {
                        if (rezultat.ToString().ToCharArray()[i] != rezultat.ToString().ToCharArray()[dolzina - i - 1])
                        {
                            tBrake = true;
                            break;
                        }
                    }
                    if (tBrake)
                    {
                        tBrake = false;
                        continue;
                    }
                    else
                    {
                        if (konRezultat < rezultat)
                        {
                            fx = x;
                            fy = y;
                            konRezultat = rezultat;
                        }
                        break;
                    }
                }

            }
            ViewData["x"] = fx;
            ViewData["y"] = fy;
            ViewData["result"] = konRezultat;
            return View("Problem4");
        }
        public ActionResult Problem5()
        {
            int i;
            for (i = 10; true; i++)
            {
                if (divides(i, 20))
                    break;
            }
            ViewData["result"] = i;
            return View("Problem5");
        }
        private bool divides(int number,int numberOfDividors)
        {
            for (int i = 1; i <= numberOfDividors;i++ )
            {
                if (number % i != 0)
                    return false;
            }
            return true;
        }
        public ActionResult Problem6()
        {
            double bigger = 0;
            double smaller = 0;
            for (int i = 1; i <= 100; i++)
            {
                smaller += Math.Pow(i, 2);
                bigger += i;
            }
            bigger = Math.Pow(bigger, 2);

            ViewData["result"] = bigger-smaller;

            return View("Problem6");
        }
        public ActionResult Problem8()
        {
            string whole = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            //string whole = "12345";
            int[] fiveNumbers = new int[5];
            int bestMultiplie = 0;
            for (int i = 0; i < whole.Length; i++) {
                
                if (i < 5)
                {
                    fiveNumbers[i] = whole[i]-48;

                }
                else
                {
                    for (int j = 1; j < 5; j++)
                    {
                        fiveNumbers[j - 1] = fiveNumbers[j];
                    }
                    fiveNumbers[4]=whole[i]-48;
                    
                }
                int multiplie = 1;
                for (int j = 0; j < 5 && i >= 4; j++)
                {
                    multiplie *= fiveNumbers[j];
                }
                if(bestMultiplie<multiplie)
                    bestMultiplie = multiplie;

            }
            ViewData["result"] = bestMultiplie;
            

            return View("Problem8");
        }
        public ActionResult Problem9()
        {
            double result=-1;
            for (double a = 1; a < 1000; a++)
            {
                for (double b = 1; b < 1000; b++)
                {
                    double c = Math.Sqrt(a * a + b * b);
                    if (c + a + b == 1000)
                    {
                        ViewData["a"] = a;
                        ViewData["b"] = b;
                        ViewData["c"] = c;
                        result = a * b * c;
                        break;
                    }
                }
                if (result != -1)
                    break;
            }
            //double g = Math.Sqrt(3 * 3 + 4 * 4);
            //ViewData["c"] = g;
            ViewData["result"] = result;
            return View("Problem9");
        }
        public ActionResult Problem11()
        {
            int[,] tabel = {{08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08},
                            {49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00},
                            {81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65},
                            {52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91},
                            {22, 31, 16, 71, 51, 67, 63, 89 ,41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80},
                            {24, 47, 32, 60, 99, 03, 45, 02 ,44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50},
                            {32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38 ,64, 70},
                            {67, 26, 20, 68, 02 ,62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49 ,94, 21},
                            {24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72},
                            {21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95},
                            {78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14 ,09, 53, 56, 92},
                            {16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24 ,36, 29, 85, 57},
                            {86, 56, 00, 48, 35, 71, 89, 07 ,05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58},
                            {19, 80, 81, 68, 05, 94, 47, 69, 28, 73 ,92, 13, 86, 52, 17, 77, 04, 89, 55, 40},
                            {04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66},
                            {88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69},
                            {04, 42, 16, 73, 38, 25, 39, 11, 24, 94 ,72, 18, 08, 46, 29, 32, 40, 62, 76, 36},
                            {20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16},
                            {20, 73, 35, 29, 78 ,31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54},
                            {01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48} };
            int bestMultiplie=-1;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    //vertical
                    if (i < 17)
                    {
                        int multiplie = 1;
                        for (int k = 0; k < 4; k++)
                        {
                            multiplie *= tabel[i+k, j];
                        }
                        if (multiplie > bestMultiplie)
                            bestMultiplie = multiplie;
                    }

                    //horizontal
                    if (j < 17)
                    {
                        int multiplie = 1;
                        for (int k = 0; k < 4; k++)
                        {
                            multiplie *= tabel[i, j+k];
                        }
                        if (multiplie > bestMultiplie)
                            bestMultiplie = multiplie;
                    }

                    //diagonal-right
                    if (i < 17 && j < 17)
                    {
                        int multiplie = 1;
                        for (int k = 0; k < 4; k++)
                        {
                            multiplie *= tabel[i+k, j + k];
                        }
                        if (multiplie > bestMultiplie)
                            bestMultiplie = multiplie;
                    }

                    //diagonal-left
                    if (i < 17 && j > 2)
                    {
                        int multiplie = 1;
                        for (int k = 0; k < 4; k++)
                        {
                            multiplie *= tabel[i + k, j - k];
                        }
                        if (multiplie > bestMultiplie)
                            bestMultiplie = multiplie;
                    }
                }
            }

            //int[,] tabel={{02, 3, 2},{1,2,1}};
            ViewData["result"] = bestMultiplie;
            return View("Problem11");
        }
    }
}
