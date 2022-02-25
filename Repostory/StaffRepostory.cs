using Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.ViewModel;

namespace Repostory
{
	public class StaffRepository : BaseRepository<Staff>
	{
		private List<StaffModel> staffRepostory;
		private Staff staff;
		public StaffRepository(SqlDbContext context) : base(context)
		{
			staffRepostory = new List<StaffModel>();
			staff = new Staff();
		}
		public List<StaffModel> Get(int pageIndex, int pageSize)
		{
			var db = context.Staffs.ToList();

			staffRepostory = mapper.Map<List<StaffModel>>(db);
			return staffRepostory.Skip((pageIndex - 1) * pageSize)
				.Take(pageSize).ToList();
			//return Articles;
		}

		public void Save(StaffModel model)
		{
			staff = mapper.Map<Staff>(model);
			Add(staff);
		}

		/// <summary>
		/// 根据id删除一名员工
		/// </summary>
		/// <param name="id"></param>
		public void Delete(int? id)
		{
			if (id != null)
			{
				staff = Find(id.Value);

			}//else
			Delete();
		}

		public void Delete(string name)
		{
			if (name != null)
			{
				staff = context.Staffs.Where(s => s.Name == name).SingleOrDefault();
				Delete();
			}//else
		}
		public void Delete()
		{
			context.Staffs.Remove(staff);
			context.SaveChanges();
		}
		/// <summary>
		/// 根据姓名修改属性
		/// </summary>
		/// <param name="name"></param>
		public void Change(int id,StaffModel model)
		{

			staff = Find(id);
			staff = mapper.Map<Staff>(model);
			context.SaveChanges();
		}
	}
}
