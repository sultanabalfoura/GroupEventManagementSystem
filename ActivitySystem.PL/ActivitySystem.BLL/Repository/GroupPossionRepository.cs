using System;
using ActivitySystem.BLL.Interface;
using ActivitySystem.DAL.Context;
using ActivitySystem.DAL.Model;

namespace ActivitySystem.BLL.Repository
{
	public class GroupPossionRepository : GenericRepository<GroupPosition> , IGroupPossionRepository
	{
        private readonly ApplicationDbContext _context;

        public GroupPossionRepository(ApplicationDbContext context): base(context)
		{
			_context = context;
		}
	}
}

