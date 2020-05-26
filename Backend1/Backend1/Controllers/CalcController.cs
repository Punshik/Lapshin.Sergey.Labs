using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Backend1.Models;
using Backend1.Services;

namespace Backend1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View("/Index");
        }

        public IActionResult UsingModelCalc()
        {

            DataBase db = Calculate();

            return View(db);

        }

        public IActionResult ViewDataCalc()
        {

            ViewData["data"] = Calculate();

            return View();


        }

        public IActionResult ViewBagCalc()
        {
            ViewBag.data = Calculate();

            return View();

        }

        public IActionResult ServiceInjectionCalc()
        {

            return View();
        }

        public DataBase Calculate()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            (var value1, var value2) = (rnd.Next() % 10, rnd.Next() % 10);

            int divResult;
            try
            {
                divResult = value1 / value2;
            }
            catch (DivideByZeroException)
            {
                divResult = -1;
            }

            return new DataBase
            {
                first = value1,
                second = value2,
                summResult = value1 + value2,
                substrResult = value1 - value2,
                divResult = divResult,
                multResult = value1 * value2
            };
        }

    }


}