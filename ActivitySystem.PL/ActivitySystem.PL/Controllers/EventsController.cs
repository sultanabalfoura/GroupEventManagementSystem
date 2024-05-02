using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivitySystem.BLL.Interface;
using ActivitySystem.DAL.Model;
using Microsoft.AspNetCore.Mvc;

namespace ActivitySystem.PL.Controllers
{
    public class EventsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public EventsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: /<controller>/
        public IActionResult AddEvents()
        {
            ViewBag.Groups = _unitOfWork.groupsRepository.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult AddEvents(Event events)
        {
            if (!ModelState.IsValid)
            {
                _unitOfWork.eventRepository.Create(events);
                return RedirectToAction("AddEvents");
            }
            else
            {
                return View();
            }
        }

        
    }
}

