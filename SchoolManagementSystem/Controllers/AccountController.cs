using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        private SchoolMgtDbEntities db = new SchoolMgtDbEntities();

        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult LoginUser(string email, string password)
        {
            try
            {
                if (email != null && password != null)
                {
                    var finduser = db.UserTables.Where(u => u.EmailAddress == email && u.Password == password).ToList();
                    if (finduser.Count() == 1)
                    {
                        Session["UserID"] = finduser[0].UserID;
                        Session["UserTypeID"] = finduser[0].UserTypeID;
                        Session["FullName"] = finduser[0].FullName;
                        Session["UserName"] = finduser[0].UserName;
                        Session["Password"] = finduser[0].Password;
                        Session["ContactNo"] = finduser[0].ContactNo;
                        Session["EmailAddress"] = finduser[0].EmailAddress;
                        Session["Address"] = finduser[0].Address;
                        string url = string.Empty;
                        if (finduser[0].UserTypeID == 2)
                        {
                            return RedirectToAction("About", "Account");
                        }
                        else if (finduser[0].UserTypeID == 3)
                        {
                            return RedirectToAction("About", "Account");
                        }

                        else if (finduser[0].UserTypeID == 4)
                        {
                            return RedirectToAction("About", "Account");
                        }

                        else if (finduser[0].UserTypeID == 1)
                        {
                            url = "About";
                        }
                        else
                        {
                            url = "About";
                        }
                        return RedirectToAction(url);
                    }

                    else
                    {
                        Session["UserID"] = string.Empty;
                        Session["UserTypeID"] = string.Empty;
                        Session["FullName"] = string.Empty;
                        Session["UserName"] = string.Empty;
                        Session["Password"] = string.Empty;
                        Session["ContactNo"] = string.Empty;
                        Session["EmailAddress"] = string.Empty;
                        Session["Address"] = string.Empty;
                        ViewBag.message = "UserName and Password is Incorrect";
                    }
                }
                else
                {
                    Session["UserID"] = string.Empty;
                    Session["UserTypeID"] = string.Empty;
                    Session["FullName"] = string.Empty;
                    Session["UserName"] = string.Empty;
                    Session["Password"] = string.Empty;
                    Session["ContactNo"] = string.Empty;
                    Session["EmailAddress"] = string.Empty;
                    Session["Address"] = string.Empty;
                    ViewBag.message = "An Unexpected Issue Occured";
                }
            }
            catch(Exception ex)
            {
                Session["UserID"] = string.Empty;
                Session["UserTypeID"] = string.Empty;
                Session["FullName"] = string.Empty;
                Session["UserName"] = string.Empty;
                Session["Password"] = string.Empty;
                Session["ContactNo"] = string.Empty;
                Session["EmailAddress"] = string.Empty;
                Session["Address"] = string.Empty;
                ViewBag.message = "An Unexpected Issue Occured";
            }
            return View("Login");
            
        }
        public ActionResult Logout()
        {
            Session["UserID"] = string.Empty;
            Session["UserTypeID"] = string.Empty;
            Session["FullName"] = string.Empty;
            Session["UserName"] = string.Empty;
            Session["Password"] = string.Empty;
            Session["ContactNo"] = string.Empty;
            Session["EmailAddress"] = string.Empty;
            Session["Address"] = string.Empty;

            return RedirectToAction("Login");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to Unified School Management System";

            return View();
        }
    }
}