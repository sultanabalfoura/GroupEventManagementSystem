using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text.RegularExpressions;
using ActivitySystem.BLL.Interface;
using ActivitySystem.DAL.Context;
using ActivitySystem.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace ActivitySystem.BLL.Repository
{
	public class GroupRepository : GenericRepository<Groups>, IGroupsRepository
	{
        private readonly ApplicationDbContext _context;

        public GroupRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }


        public List<Groups> GetGroupNamesForMember(int memberId)
        {
            Members member = _context.Members.Include(m=> m.MemberShips).ThenInclude(m=> m.Group).FirstOrDefault(m => m.MemberId == memberId);
            List<Groups> s = new List<Groups>();
            //s.Add("memberId " + memberId + " ");
            // Check if the member exists and has participated in any groups
            if (member != null)
            {
                //s.Add(" member: " + member.MemberId + " ");

                if (member.MemberShips != null)
                {
                    foreach (var membership in member.MemberShips)
                    {
                        s.Add(membership.Group);
                       // s.Add("\n MemberID " + membership.MemberID + " " + " GroupID " + membership.GroupID + " " + "GroupName : " + membership.Group.GroupName);
                    }
                }
                // Iterate through the groups and extract their names
                //List<string> groupNames = member.Groups.Select(group => group.GroupName).ToList();

                //
                return s;// groupNames;
            }
            else
            {

                // Handle the case where the member does not exist or has not participated in any groups
                return s;
            }
        }

        //public ICollection<Groups> GetGroupsByMember(Members member ,MemberShip membership)
        //{

        //    if (member != null && membership != null && membership.Members != null)
        //    {
        //        var memberships = member.Groups.Where(g => g.Members != null && g.Members.Contains(member)).ToList();
        //        return memberships;
        //    }

        //    else
        //    {

        //        return new List<Groups>();

        //    }
        //}




    }
}




//if (member != null && member.Groups != null)
//{
//    var memberGroups = member.Groups.Where(g => g.Members != null && g.Members.Contains(member));
//    return memberGroups;
//}
//else
//{
//    return Enumerable.Empty<Groups>();
//}



//if (member.Groups != null)
//{
//    List<Groups> g = member.Groups.ToList();
//    return g[0].GroupName;
//}
//else
//    return " hello ";
/*
var memberGroups = member.Groups.Where(g => g.Members != null && g.Members.Contains(member));
return memberGroups;*/

