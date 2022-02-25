using AutoMapper;
using Entitys;
using Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repostory
{
	public class BaseRepository<T> where T : Entitys.Staff
	{
		protected SqlDbContext context;
		private readonly static MapperConfiguration config;
		static BaseRepository()
		{
			config = new MapperConfiguration(
				cfg =>
				{
					cfg.CreateMap<StaffModel, Staff>().ReverseMap();
				});
		}
		protected IMapper mapper { get { return config.CreateMapper(); } }
		public BaseRepository(SqlDbContext context)
		{
			this.context = context;
		}
		/// <summary>
		/// 将一名新的员工添加到数据库中
		/// </summary>
		/// <param name="entity">用户的信息</param>
		/// <returns>返回用户的id</returns>
		public int Add(T entity)
		{
			context.Set<T>().Add(entity);
			context.SaveChanges();
			return entity.Id;
		}
		/// <summary>
		/// 根据id查找某一名员工
		/// </summary>
		/// <param name="id">员工的id</param>
		/// <returns>返回员工的完整信息</returns>
		public T Find(int id)
		{
			return context.Set<T>().Find(id);
		}
	}
}
