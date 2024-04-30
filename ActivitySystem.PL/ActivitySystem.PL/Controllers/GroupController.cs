using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ActivitySystem.BLL.Interface;
using ActivitySystem.DAL.Model;
using ActivitySystem.PL.Helper;
using ActivitySystem.PL.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ActivitySystem.PL.Controllers
{
    public class GroupController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public GroupController(IUnitOfWork uniteOfWork)
        {
            _unitOfWork = uniteOfWork;
        }
        // GET: /<controller>/
        public IActionResult AddGroups()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGroups(Groups group, GroupsVM model)
        {
            if (!ModelState.IsValid)
            {
                //_unitOfWork.groupsRepository.Create(group);

                if (model.ImageFile != null && model.ImageFile.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        model.ImageFile.CopyTo(memoryStream);
                        group.Image = memoryStream.ToArray();
                        byte[] imageData = ImageHelper.ImageToByteArray(memoryStream.ToArray());
                    }
                }

                // Save the model object to the database
                _unitOfWork.groupsRepository.Create(group);
                //_unitOfWork.Save();

                return RedirectToAction("AddGroups");
            }
            else
            {
                return View(group);
            }
        }

    }
}

