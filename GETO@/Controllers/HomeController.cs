using GETO_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GETO_.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HttpClient client = new HttpClient();
        Utils util = new Utils();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [ServiceFilter(typeof(ActionFIlter))]
        public IActionResult  DonateO2()
        {
            ViewBag.Success = false;
            ViewBag.Error = false;
            return View();
        }
        [HttpPost]
        public IActionResult DonateO2(OxyDonator Model)
        {

            Model.CreatedOn = DateTime.Now;
            Model.UpdatedOn = DateTime.Now;
            try
            {
                var _db = new dbContext();
                _db.OxyDonator.Add(Model);
                _db.SaveChanges();
                ViewBag.Success = true;
                return View(new OxyDonator());
            }
            catch (Exception ex)
            {
            ViewBag.Error = true;
            }
            
            return View(Model);
        }
        public IActionResult DonatePlasma()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DonatePlasma(PlasmaDonor Model)
        {
            Model.CreatedOn = DateTime.Now;
            Model.UpdatedOn = DateTime.Now;
            try
            {
                var _db = new dbContext();
                _db.PlasmaDonor.Add(Model);
                _db.SaveChanges();
                ViewBag.Success = true;
                return View(new OxyDonator());
            }
            catch (Exception ex)
            {
                ViewBag.Error = true;
            }

            return View(Model);
        }
        public IActionResult GetO2()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult GetO2(string State)
        {
            var _db = new dbContext();
            var data = _db.OxyDonator.Where(x => x.State == State).ToList();
            return Json(data);
        }
        public IActionResult GetPlasma()
        {

            return View();
        }
        [HttpPost]
        public IActionResult GetPlasma(string State,string BGroup)
        {
            var _db = new dbContext();
            var data = _db.PlasmaDonor.Where(x => x.State == State && x.BGroup == BGroup).ToList();
            return Json(data);
        }
        public List<MenuItems> FilterValues(List<MenuItems> Menus,int ParentId = 0)
        {
            List<MenuItems> MenuItemsList = new List<MenuItems>();
            List<MenuItems> MenuItem = new List<MenuItems>(); ;
            if(ParentId == 0)
            {
                MenuItem = Menus.Where(x => x.ParentId == 0).ToList();
            }
            else
            {
                MenuItem = Menus.Where(x => x.ParentId == ParentId).ToList();
            }
            foreach(var m in MenuItem)
            {
                var model = new MenuItems();
                MenuItemsList.Add(new MenuItems()
                {
                    Id = m.Id,
                    Name=m.Name,
                    ParentId=m.ParentId,
                    ChildMenu= FilterValues(Menus, m.Id)
            }) ;
                  
                
            }
            return MenuItemsList;
        }
        public IActionResult Test()
        {
            var _db = new dbContext();
            List<Menu> MenuModel = _db.Menu.Select(x => x).ToList();

            List<MenuItems> RespMenu = new List<MenuItems>();

            foreach (var i in MenuModel)
            {
                var m = new MenuItems();
                m.Id = i.Id;
                m.Name = i.Name;
                m.ParentId = i.parentId;
                m.ChildMenu = new List<MenuItems>();
                RespMenu.Add(m);
            }
            var data = FilterValues(RespMenu);
            //foreach (var m in MenuModel)
            //{
            //    var s = new MenuItems();
            //    if (m.parentId != 0)
            //    {
            //        foreach (var b in RespMenu)
            //        {
            //            if (b.Id == m.parentId)
            //            {
            //                s.Id = m.Id;
            //                s.Name = m.Name;
            //                s.ChildMenu = new List<MenuItems>();
            //                b.ChildMenu.Add(s);
            //            }
            //        }
            //    }
            //}



            return View(data);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
