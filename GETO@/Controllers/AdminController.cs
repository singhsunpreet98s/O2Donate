
using GETO_.Data;
using GETO_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETO_.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            try
            {
                var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
                if (Admin != null)
                {
                    bool IsAdmin = Admin.role == "Admin";
                    if (IsAdmin)
                    {
                        return View();
                    }
                    
                }
                
               
            }
            catch (Exception)
            {

            }
            return Redirect("/Home/Index");

        }
      
        public IActionResult Oxyzen()
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
            //var IsAdmin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault().role == "Admin";
            if (Admin != null)
            {
                bool IsAdmin = Admin.role == "Admin";
                if (IsAdmin)
                {

                    try
                    {
                        var Model = _db.OxyDonator.Select(x => x).ToList();
                        return View(Model);
                    }
                    catch (Exception ex)
                    {
                        return View(ex.Message);
                    }
                }
            }
            
            
            return Redirect("/Home/Index");

        }
        
        public IActionResult VerifyOxy(int Id)
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
            if (Admin != null)
            {
                bool IsAdmin = Admin.role == "Admin";
                if (IsAdmin)
                {


                    try
                    {
                        var Model = _db.OxyDonator.Where(x => x.Id == Id).FirstOrDefault();
                        Model.IsVerified = true;
                        Model.UpdatedOn = DateTime.Now;
                        _db.Entry(Model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        _db.SaveChanges();
                        return Json("success");
                    }
                    catch (Exception ex)
                    {
                        return Json("error");
                    }
                }
                else
                {
                    return Json("error");
                }
            }



            return Json("error");
        }
        public IActionResult Plasma()
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
            if (Admin != null)
            {
                bool IsAdmin = Admin.role == "Admin";
                if (IsAdmin)
                {


                    try
                    {
                        var Model = _db.PlasmaDonor.Select(x => x).ToList();
                        return View(Model);
                    }
                    catch (Exception ex)
                    {
                        return View(ex.Message);
                    }
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            return Redirect("/Home/Index");


        }

        public IActionResult VerifyPlasma(int Id)
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
            //var IsAdmin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault().role == "Admin";
            if (Admin != null)
            {
                bool IsAdmin = Admin.role == "Admin";
                if (IsAdmin)
                {

                    try
                    {
                        var Model = _db.PlasmaDonor.Where(x => x.Id == Id).FirstOrDefault();
                        Model.IsVerified = true;
                        Model.UpdatedOn = DateTime.Now;
                        _db.Entry(Model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        _db.SaveChanges();
                        return Json("success");
                    }
                    catch (Exception ex)
                    {
                        return Json("error");
                    }
                }
                else
                {
                    return Json("error");
                }
            }

            return Json("error");

        }
        public IActionResult ThirdParties()
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
            if (Admin != null)
            {
                bool IsAdmin = Admin.role == "Admin";
                if (IsAdmin)
                {

                    var Model = _db.ApiKeyModel.Select(x => x).ToList();
                    return View(Model);
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            return Redirect("/Home/Index");



        }
        public IActionResult EditApiKey(int Id)
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
            if (Admin != null)
            {
                bool IsAdmin = Admin.role == "Admin";
                if (IsAdmin)
                {
                    var Model = _db.ApiKeyModel.Where(x => x.Id == Id).FirstOrDefault();
                    return View(Model);
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            return Redirect("/Home/Index");
        }
        [HttpPost]
        public IActionResult EditApiKey(ApiKeyModel Model)
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
            if (Admin != null)
            {
                bool IsAdmin = Admin.role == "Admin";
                if (IsAdmin)
                {
                    try
                    {
                        var NewModel = _db.ApiKeyModel.Where(x => x.Id == Model.Id).FirstOrDefault();
                        NewModel.O2Add = Model.O2Add;
                        NewModel.AddPlasmaData = Model.AddPlasmaData;
                        NewModel.GetO2Data = Model.GetO2Data;
                        NewModel.GetPlasmaData = Model.GetPlasmaData;
                        NewModel.UpdatedAt = DateTime.Now;
                        _db.Entry(NewModel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                        _db.SaveChanges();
                        ViewBag.Success = true;
                        return View(NewModel);

                    }
                    catch (Exception)
                    {

                    }
                    return View(Model);
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            return Redirect("/Home/Index");
        }
        public IActionResult DeleteApiKey(int Id)
        {
            var UserName = User.Identity.Name;
            var _db = new dbContext();
            var Admin = _db.RolesUsers.Where(x => x.UserId == UserName).FirstOrDefault();
            if (Admin != null)
            {
                bool IsAdmin = Admin.role == "Admin";
                if (IsAdmin)
                {
                    try
                    {
                        var Model = _db.ApiKeyModel.Where(x => x.Id == Id).FirstOrDefault();
                        _db.Entry(Model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                        _db.SaveChanges();
                        ViewBag.User = Model.User;
                        ViewBag.Success = true;
                        return Redirect("/Admin/ThirdParties");
                    }
                    catch (Exception)
                    {
                        ViewBag.Error = true;
                    }
                    return Redirect("/Admin/ThirdParties");
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            return Redirect("/Home/Index");
        }
    }
}
