using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication16.Models;

namespace WebApplication16.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CarTwistDb db = new CarTwistDb(Properties.Settings.Default.ConStr);
            IEnumerable<Car> cars = db.GetCars();
            return View(cars);
        }

        public ActionResult ShowAddForm()
        {
            return View();
        }


        public ActionResult AddCar(Car car)
        {
            CarTwistDb db = new CarTwistDb(Properties.Settings.Default.ConStr);
            db.AddCar(car);
            return Redirect("/");
        }
    }
}