using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mud_Maker.Data;

namespace Mud_Maker.Controllers
{
    public class EventController : Controller
    {
        private ApplicationDbContext repo;

        public EventController(ApplicationDbContext repo)
        {
            this.repo = repo;
        }

        // GET: Event
        public ActionResult Index(int id)
        {
            var project = id == 0 ? repo.Events
                                  : repo.Events.Where(x => x.MudId == id);

            //var viewModel = new ProjectsIndexViewModel { ClientId = id, Projects = project };
            //if (customer == null)
            //{
            //    return NotFound();
            //}
            //Project model = new Project { ProjectID = customer.ProjectID, CompanyName = customer.CompanyName, CompanyPhone = customer.CompanyPhone, CompanyPoc = customer.CompanyPoc };
            return View();//viewModel
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Event/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}