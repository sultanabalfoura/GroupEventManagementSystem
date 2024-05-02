using System;
using ActivitySystem.BLL.Interface;
using ActivitySystem.DAL.Context;
using ActivitySystem.DAL.Model;

namespace ActivitySystem.BLL.Repository
{
	public class EventRepository : GenericRepository<Event> ,IEventRepository
	{
        private readonly ApplicationDbContext _context;

        public EventRepository(ApplicationDbContext context) : base(context)
		{
			_context = context;
		}
	}
}

