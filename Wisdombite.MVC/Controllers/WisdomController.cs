using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Wisdombite.Models;

namespace Wisdombite.MVC.Controllers
{
    [Authorize]
    public class WisdomController : Controller
    {
        //Create general
        //GET: Wisdom/Create
        public ActionResult Create()
        {
            return View();
        }
        //Create confirm
        //POST: Wisdom/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WisdomBasicItem wisdomToCreate)
        {
            if (ModelState.IsValid)
            {
                //Do service stuff
                //redirect to index with temp data
            }
            return View(wisdomToCreate);
        }

        //Read General
        // GET: Wisdom
        public ActionResult Index()
        {
            var wisdomListItem = new WisdomListItem[0];
            return View(wisdomListItem);
        }
        //Read Detail
        //GET: Wisdom/Details/{id}
        [ActionName("Details")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return no no no 
            }
            //New wisdom detail item (use service)
            //if ()//wisdom is null)
            //{
            //    //say not found
            //}
            return View();//wisdom);
        }

        //Update general
        //GET: Wisdom/Edit/{id}
        public ActionResult Edit(int? id)
        {
            var wisdomToEdit = 0; //replace this with wisdom to edit item
            return View(wisdomToEdit);
        }
        //Update confirm
        //POST:  Wisdom/Edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public ActionResult Edit(WisdomBasicItem wisdomToEdit)
        {
            return View();
            //Call update service with wisdomToEdit as parameter
            //return temp data 
        }

        //Delete general
        //GET: Wisdom/Delete/{id}
        public ActionResult Delete(int? id)
        {
            //Replace this with get wisdom by id service
            var wisdomToRemove = 0;
            return View(wisdomToRemove);
        }
        //Delete confirm
        //POST: Wisdom/Delete/{id}
        public ActionResult Delete(WisdomBasicItem wisdomToRemove)
        {
            //Check Eleven Note for how to do this
            //Guess:
            //1. call remove service
            //2. provide temp data
            //3. Return view
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}