using Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostory
{
	 public class SqlDbContext :DbContext
	{
		public DbSet<Staff> Staffs { get; set; }
		public SqlDbContext():base("员工基本信息")
		{

		}
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			base.OnModelCreating(modelBuilder);	
		}
	}
}
