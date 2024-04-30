using System;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using ActivitySystem.DAL.Model;

namespace ActivitySystem.BLL.Interface
{
	public interface IGroupsRepository : IGenericRepository<Groups>
	{
        //public ICollection<Groups> GetGroupsByMember(Members member , MemberShip membership);
        //public List<(Members member, List<Groups> groups)> GetGroupsForMembers();
        //public List<(Members member, List<Group> groups)> GetGroupsForMembers(Members member);
        public List<Groups> GetGroupNamesForMember(int memberId);

    }
}

