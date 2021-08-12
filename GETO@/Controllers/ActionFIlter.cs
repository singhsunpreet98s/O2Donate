using GETO_.Data;
using GETO_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GETO_.Controllers
{
    public class ActionFIlter:IActionFilter
    {
        private readonly ApplicationDbContext _context;
        private readonly dbContext _db;
        public ActionFIlter(ApplicationDbContext context,dbContext db)
        {
            _context = context;
            _db = db;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
           
            try
            {
                string UserName = context.HttpContext.User.Identity.Name;
              
                var User = _context.Users.Where(x => x.UserName == UserName).FirstOrDefault();
                var UserDetailModel = _db.UserDetails.Where(x => x.UserId == User.Id).FirstOrDefault();
                if (UserDetailModel != null)
                {
                    if (String.IsNullOrEmpty(UserDetailModel.Address))
                    {
                        // When User hasnt entered detailed inforemationC
                        context.Result = new RedirectToRouteResult(
                            new RouteValueDictionary
                            {
                                {"conroller","Home"},
                                {"action","GetO2"}
                            });

                    }

                }
            }
            catch (Exception ex)
            {

            }
            
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
