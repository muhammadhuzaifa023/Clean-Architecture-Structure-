using AutoMapper;
using BrandApplication.Business.DTOs;
using BrandApplication.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApplication.Business.Mappings
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Brand, BrandDto>()
				.ReverseMap(); // This will allow mapping in both directions
			CreateMap<Model, ModelDto>()
				.ReverseMap();
		}
	}
}
