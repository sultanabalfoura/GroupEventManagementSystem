using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivitySystem.BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ActivitySystem.BLL.Repository;
using ActivitySystem.PL.Models;
using ActivitySystem.DAL.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ActivitySystem.PL.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public StudentController(IUnitOfWork uniteOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = uniteOfWork;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet("{id}")]
        public IActionResult Myprofile(int id)
        {
            // in _layout I use (asp-route-id="10") to test the function 
            var member = _unitOfWork.memberRepository.GetByEmail(id);
            if (member == null)
            {
                return NotFound();
            }

            //Map the Member model to view model MembersVM
                var viewModel = new MembersVM
                {
                    MemberId = member.MemberId,
                    FullName = member.FullName,
                    Email = member.Email,
                    PhoneNo = member.PhoneNo
                   
                };
            
            return View(viewModel);
            
        }

        
        public ActionResult MyGroups(int memberId)
        {

            List<Groups> groupNames = _unitOfWork.groupsRepository.GetGroupNamesForMember(1);
            

            ViewBag.GroupName = groupNames;
            //ViewBag.GroupPosition = _unitOfWork.groupPossionRepository.GetAll(); 

            return View(groupNames);
        }




    }
}

