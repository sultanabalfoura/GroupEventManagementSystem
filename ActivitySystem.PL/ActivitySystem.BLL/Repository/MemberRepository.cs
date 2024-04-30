using System;
using ActivitySystem.BLL.Interface;
using ActivitySystem.DAL.Context;
using ActivitySystem.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace ActivitySystem.BLL.Repository
{
	public class MemberRepository : GenericRepository<Members>, IMemberRepository
	{
        private readonly ApplicationDbContext _context;

        public MemberRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}

        public Members GetByEmail(int id) =>
            _context.Members.FirstOrDefault(m => m.MemberId == id);

        //public async Task<Members> GetStudentWithGroupsAndPositionsAsync(int studentId)
        //{

        //        return await _context.Members.Include(m => m.Groups).ThenInclude(g => g.GroupPositions).FirstOrDefaultAsync(m => m.MemberId == studentId);

        //}
    }
}


