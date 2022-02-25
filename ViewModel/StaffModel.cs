using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace Service.ViewModel
{
	public class StaffModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int cellPhoneNumber { get; set; }
		public string IDNumber { get; set; }
		public int? Age { get; set; }
		public bool? Gender { get; set; }
		public string GraduateInstitutions { get; set; }
		public string HomeAddress { get; set; }
		public string HobbiesAndInterests { get; set; }


	}
}