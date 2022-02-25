using System.Web;
using System.Web.Mvc;

namespace 员工基本信息管理系统
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
