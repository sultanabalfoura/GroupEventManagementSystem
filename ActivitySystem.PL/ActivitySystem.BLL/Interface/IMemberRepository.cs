using System;
using ActivitySystem.DAL.Model;

namespace ActivitySystem.BLL.Interface
{
	public interface IMemberRepository : IGenericRepository<Members>
	{
		public Members GetByEmail(int id);

    }
}

