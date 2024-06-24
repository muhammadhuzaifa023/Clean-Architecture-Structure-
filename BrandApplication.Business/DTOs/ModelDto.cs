using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApplication.Business.DTOs
{
	public class ModelDto
	{
		public int ModelId { get; set; }
		public string ModelName { get; set; }

		public int BrandId { get; set; }
		// Avoid circular references in DTOs.
		// You might include a reference to the parent DTO if necessary, but often it's better to avoid this.
		public BrandDto Brand { get; set; }
	}
}
