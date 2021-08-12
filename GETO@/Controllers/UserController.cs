using GETO_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETO_.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var UserName = User.Identity.Name;
                var _db = new dbContext();
                ApiKeyModel Model = _db.ApiKeyModel.Where(x => x.User == UserName).FirstOrDefault();
                if (Model != null)
                {
                    return View(Model);
                }
                else
                {
                    return View();
                }
            }
            ViewBag.Error = true;
            return View();
            
        }
        public IActionResult GetApiKey()
        {
            if (User.Identity.IsAuthenticated)
            {
                var UserName = User.Identity.Name;
                var ApiModel = new ApiKeyModel();
                var _db = new dbContext();
                try
                {
                    string GuidKey = Guid.NewGuid().ToString();
                    ApiModel.AddPlasmaData = false;
                    ApiModel.GetPlasmaData = false;
                    ApiModel.Key = GuidKey;
                    ApiModel.GetO2Data = false;
                    ApiModel.O2Add = false;
                    ApiModel.CreatedAt = DateTime.Now;
                    ApiModel.UpdatedAt = DateTime.Now;
                    ApiModel.User = UserName;
                    _db.ApiKeyModel.Add(ApiModel);
                    _db.SaveChanges();
                    ViewBag.Success = true;
                    return Redirect("/User/Index");
                }
                catch (Exception ex)
                {


                }
            }
            return Redirect("/User/Index");

        }
        public IActionResult GetPlasmaData(string Key,string State)
        {
            var ResponseModel = new ApiResponseModelPlasma();
            if (!String.IsNullOrEmpty(Key))
            {
                var _db = new dbContext();
                bool IsKeyValid = _db.ApiKeyModel.Any(x => x.Key == Key);
                var ApiData = _db.ApiKeyModel.Where(x => x.Key == Key).FirstOrDefault();
                if (IsKeyValid)
                {
                    if (ApiData.GetPlasmaData)
                    {
                        if (!String.IsNullOrEmpty(State))
                        {
                            ResponseModel.DonorList = _db.PlasmaDonor.Where(x => x.State == State).ToList();
                            ResponseModel.success = true;
                            ResponseModel.msg = "success";
                        }
                        else
                        {
                            ResponseModel.DonorList = _db.PlasmaDonor.Select(x => x).ToList();
                            ResponseModel.success = true;
                            ResponseModel.msg = "success";
                        }
                    }
                    else
                    {
                        ResponseModel.success = false;
                        ResponseModel.msg = "You dont Have permission to get Data";
                    }
                }
                else
                {
                    ResponseModel.success = false;
                    ResponseModel.msg = "Invalid Key";
                  
                }
            }
            else
            {
                ResponseModel.success = false;
                ResponseModel.msg = "Invalid Key";
              
            }
           
            return Json(ResponseModel);
        }
        public IActionResult GetO2Data(string Key, string State)
        {
            var ResponseModel = new ApiResponseModelO2();
            if (!String.IsNullOrEmpty(Key))
            {
                var _db = new dbContext();
                bool IsKeyValid = _db.ApiKeyModel.Any(x => x.Key == Key);
                var ApiData = _db.ApiKeyModel.Where(x => x.Key == Key).FirstOrDefault();
                if (IsKeyValid)
                {
                    if (ApiData.GetO2Data)
                    {
                        if (!String.IsNullOrEmpty(State))
                        {
                            ResponseModel.DonorList = _db.OxyDonator.Where(x => x.State == State).ToList();
                            ResponseModel.success = true;
                            ResponseModel.msg = "success";
                        }
                        else
                        {
                            ResponseModel.DonorList = _db.OxyDonator.Select(x => x).ToList();
                            ResponseModel.success = true;
                            ResponseModel.msg = "success";
                        }
                    }
                    else
                    {
                        ResponseModel.success = false;
                        ResponseModel.msg = "You dont Have permission to get Data";
                    }
                }
                else
                {
                    ResponseModel.success = false;
                    ResponseModel.msg = "Invalid Key";

                }
            }
            else
            {
                ResponseModel.success = false;
                ResponseModel.msg = "Invalid Key";

            }
           
            return Json(ResponseModel);
        }
        [HttpPost]
        public IActionResult AddO2Donor(OxyDonator Model,string Key)
        {
            ApiResponseModeAddlO2 ResponseModel = new ApiResponseModeAddlO2();
            if (!String.IsNullOrEmpty(Key))
            {
                var _db = new dbContext();
                var IsKeyValid = _db.ApiKeyModel.Any(x => x.Key == Key);
                var ApiData = _db.ApiKeyModel.Where(x => x.Key == Key).FirstOrDefault();
                if (IsKeyValid)
                {
                    if (ApiData.O2Add)  
                    {
                        if (ModelState.IsValid)
                        {
                            try
                            {
                                Model.AddedBy = ApiData.User;
                                Model.CreatedOn = DateTime.Now;
                                Model.UpdatedOn = DateTime.Now;
                                _db.OxyDonator.Add(Model);
                                _db.SaveChanges();
                                ResponseModel.msg = "Success";
                                ResponseModel.success = true;
                            }
                            catch (Exception ex)
                            {
                                ResponseModel.msg = "Server Error";
                                ResponseModel.success = false;
                            }
                        }
                        else
                        {
                            ResponseModel.msg = "Wrong Data";
                            ResponseModel.success = false;
                        }
                    }
                    else
                    {
                        ResponseModel.msg = "You dont't have permissions to write data";
                        ResponseModel.success = false;
                    }
                }
                else
                {
                    ResponseModel.msg = "Invalid Api Key";
                    ResponseModel.success = false;
                }

            }
            else
            {
                ResponseModel.msg = "Invalid Api Key";
                ResponseModel.success = false;
            }
            return Json(ResponseModel);
        }
        [HttpPost]
        public IActionResult AddPlasmaDonor(PlasmaDonor Model, string Key)
        {
            ApiResponseModeAddlO2 ResponseModel = new ApiResponseModeAddlO2();
            if (!String.IsNullOrEmpty(Key))
            {
                var _db = new dbContext();
                var IsKeyValid = _db.ApiKeyModel.Any(x => x.Key == Key);
                var ApiData = _db.ApiKeyModel.Where(x => x.Key == Key).FirstOrDefault();
                if (IsKeyValid)
                {
                    if (ApiData.AddPlasmaData)
                    {
                        if (ModelState.IsValid)
                        {
                            try
                            {
                                Model.AddedBy = ApiData.User;
                                Model.CreatedOn = DateTime.Now;
                                Model.UpdatedOn = DateTime.Now;
                                _db.PlasmaDonor.Add(Model);
                                _db.SaveChanges();
                                ResponseModel.msg = "Success";
                                ResponseModel.success = true;
                            }
                            catch (Exception ex)
                            {
                                ResponseModel.msg = "Server Error";
                                ResponseModel.success = false;
                            }
                        }
                        else
                        {
                            ResponseModel.msg = "Wrong Data";
                            ResponseModel.success = false;
                        }
                    }
                    else
                    {
                        ResponseModel.msg = "You dont't have permissions to write data";
                        ResponseModel.success = false;
                    }
                }
                else
                {
                    ResponseModel.msg = "Invalid Api Key";
                    ResponseModel.success = false;
                }

            }
            else
            {
                ResponseModel.msg = "Invalid Api Key";
                ResponseModel.success = false;
            }
            return Json(ResponseModel);
        }


    }
}
