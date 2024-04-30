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
            ViewBag.studentId = id;
            return View(viewModel);
            
        }

        //private int GetCurrentMemberId()
        //{
        //    // Assuming you store member ID as an integer
        //    var memberIdString = _httpContextAccessor.HttpContext.Session.GetString("CurrentMemberId");
        //    if (int.TryParse(memberIdString, out var memberId))
        //    {
        //        return memberId;
        //    }
        //    return -1; // or any default value indicating failure to retrieve the member ID
        //}

        //public IActionResult MyGroups(Members member)
        //{

        //    var memberGroups = _unitOfWork.groupsRepository.GetGroupsForMembers(member);
        //    return View(memberGroups);

        //}
        //var student = _unitOfWork.memberRepository.Get(id);
        //var membership = _unitOfWork.memebershipRepository.Get(id);

        //if (student == null)
        //{
        //    return NotFound(); // Return a 404 if student is not found
        //}

        //// Retrieve the groups associated with the student
        ////var participatedGroups = _unitOfWork.groupsRepository.GetGroupsByMember(student);
        //String listOfGroups = "";
        //String listOfMembers = "";
        //String listOfMembership = "";

        //List<Groups> l = _unitOfWork.groupsRepository.GetAll().ToList();
        //foreach (Groups lst in l)
        //{
        //    listOfGroups += lst.GroupID + " ";
        //}

        //List<Members> l2 = _unitOfWork.memberRepository.GetAll().ToList();
        //foreach (Members lst in l2)
        //{
        //    //listOfMembers += lst.MemberId + " MemberShip:" + lst.MemberShip + lst.MembershipID;
        //    listOfMembers += lst.MemberId + " ";
        //}

        //List<MemberShip> l3 = _unitOfWork.memebershipRepository.GetAll().ToList();
        //foreach(MemberShip lst in l3)
        //{
        //    listOfMembership += " membership ID: " +lst.membershipID + " " ;
        //}

        //ViewBag.studentId = listOfGroups + " " + student.Email + " " + listOfMembers + " " + listOfMembership;
        //ViewBag.ParticipatedGroups = _unitOfWork.groupsRepository.GetGroupsByMember(student , membership);
        //return View();




        public ActionResult MyGroups(int memberId)
        {

            List<Groups> groupNames = _unitOfWork.groupsRepository.GetGroupNamesForMember(1);
            

            ViewBag.GroupName = groupNames;


            return View(groupNames);
        }




    }
}

