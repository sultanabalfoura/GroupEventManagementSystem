using System;
using ActivitySystem.BLL.Interface;
using ActivitySystem.DAL.Context;

namespace ActivitySystem.BLL.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
        private readonly ApplicationDbContext _context;
        public IGroupsRepository groupsRepository { get; set; }
		public IMemberRepository memberRepository { get; set; }
        public IMemebershipRepository memebershipRepository { get; set; }
        public IEventRepository eventRepository { get; set; }
        public IGroupPossionRepository groupPossionRepository { get; set; }

        public UnitOfWork(ApplicationDbContext context)
		{
			_context = context;
			groupsRepository = new GroupRepository(_context);
			memberRepository = new MemberRepository(_context);
			memebershipRepository = new MembershipRepository(_context);
            eventRepository = new EventRepository(_context);
            groupPossionRepository = new GroupPossionRepository(_context);

        }

    }
}

