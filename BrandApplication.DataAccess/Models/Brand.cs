using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace BrandApplication.DataAccess.Models
{
	public class Brand
	{
		[Key]
		public int BrandId { get; set; }
		public string BrandName { get; set; }

		public ICollection<Model> Models { get; set; }
	}
}
