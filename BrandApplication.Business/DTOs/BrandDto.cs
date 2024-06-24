using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApplication.Business.DTOs
{
	public class BrandDto
	{
		public int BrandId { get; set; }
		public string BrandName { get; set; }

		// Avoid directly exposing entities through DTOs to maintain separation of concerns.
		public ICollection<ModelDto> Models { get; set; } = new List<ModelDto>();
	}

}
