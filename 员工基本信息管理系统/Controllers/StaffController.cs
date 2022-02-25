using Microsoft.SqlServer.Server;
using Repostory;
using Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 员工基本信息管理系统.Controllers
{
	public class StaffController : Controller
	{

		private StaffRepository staffRepository;
		private int PageSize { get; set; }
		public StaffController()
		{
			staffRepository = new StaffRepository(new SqlDbContext());
		}
		public ActionResult Index(List<StaffModel> model)
		{
			PageSize = 5;
			int pageIndex = 1;
			model = staffRepository.Get(pageIndex, PageSize);

			return View(model);
		}

		[HttpPost]
		public ActionResult Index(int pageindex)
		{
			return View();
		}

		public ActionResult Add()
		{

			return View();
		}
		[HttpPost]
		public ActionResult Add(StaffModel model)
		{

			staffRepository.Save(model);
			return View();
		}

		public ActionResult Delete()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Delete(int? id)
		{
			if (id != null)
			{
				staffRepository.Delete(id);

			}//else nothing
			return View();
		}	
		[HttpPost]
		public ActionResult Delete(string name)
		{
			if (name != null)
			{
				staffRepository.Delete(name);

			}//else nothing
			return View();
		}

		public ActionResult Change()
		{

			return View();
		}	
		[HttpPost]
		public ActionResult Change(int? id ,StaffModel model)
		{
			if (id!=null)
			{
				staffRepository.Change(id.Value, model);

			}//else nothing
			return View();
		}
	}
}