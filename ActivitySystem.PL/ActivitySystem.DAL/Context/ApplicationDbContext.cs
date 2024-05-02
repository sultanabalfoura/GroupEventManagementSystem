using System;
using System.Text.RegularExpressions;
using ActivitySystem.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace ActivitySystem.DAL.Context
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<Groups> Groups { set; get; }
        public DbSet<Members> Members { set; get; }
        public DbSet<MemberShip> MemberShip { set; get; }
        public DbSet<GroupPosition> GroupPosition { set; get; }
        public DbSet<Event> Events { set; get; }
        public DbSet<Sponsors> Sponsors { set; get; }
        public DbSet<SponsorShip> SponsorShips { set; get; }
        public DbSet<TypeOfEvents> TypeOfEvents { set; get; }
    }
}

