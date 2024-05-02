using System;
namespace ActivitySystem.BLL.Interface
{
	public interface IUnitOfWork
	{
        public IGroupsRepository groupsRepository { get; set; }
        public IMemberRepository memberRepository { get; set; }
        public IMemebershipRepository memebershipRepository { get; set; }
        public IEventRepository eventRepository { get; set; }
        public IGroupPossionRepository groupPossionRepository { get; set; }
    }
}

