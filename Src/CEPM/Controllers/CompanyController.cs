using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CEPMBL.Entities;
using CEPMBL.Manager;

namespace CEPM.Controllers
{
    public class CompanyController : Controller
    {
        //
        // GET: /Company/
        private CompanyManager manager;

        public CompanyController()
        {
            manager = new CompanyManager("Admin");
        }

        public ActionResult Index()
        {
            return View(manager.GetCompanies());
        }

        //
        // GET: /Company/Details/5

        public ActionResult Details(int id = 0)
        {
            Company company = manager.GetCompany(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        //
        // GET: /Company/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Company/Create

        [HttpPost]
        public ActionResult Create(Company company)
        {
            try
            {
                // TODO: Add insert logic here
                manager.SaveCompany(company);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Company/Edit/5

        public ActionResult Edit(int id = 0)
        {
            //return View();
            Company company = manager.GetCompany(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        //
        // POST: /Company/Edit/5

        [HttpPost]
        public ActionResult Edit(Company company)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    manager.SaveCompany(company);
                    return RedirectToAction("Index");
                }
                return View(company);
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Company/Delete/5

        public ActionResult Delete(int id)
        {
            Company company = manager.GetCompany(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        //
        // POST: /Company/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                manager.DeleteCompany(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
