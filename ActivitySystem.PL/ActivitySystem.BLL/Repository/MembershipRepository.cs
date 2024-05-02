using System;
using ActivitySystem.BLL.Interface;
using ActivitySystem.DAL.Context;
using ActivitySystem.DAL.Model;

namespace ActivitySystem.BLL.Repository
{
	public class MembershipRepository : GenericRepository<MemberShip>, IMemebershipRepository

    {
        private readonly ApplicationDbContext _context;

        public MembershipRepository(ApplicationDbContext context) : base (context)
		{
            _context = context;

        }
    }
}

