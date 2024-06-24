using AutoMapper;
using BrandApplication.Business.DTOs;
using BrandApplication.DataAccess.Interface;
using BrandApplication.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApplication.Business.Services.Implementation
{
	public class BrandServiceAsync : GenericServiceAsync<Brand, BrandDto>
	{
		public BrandServiceAsync(IGenericRepository<Brand> genericRepository, IMapper mapper)
			: base(genericRepository, mapper)
		{
		}
	}

	public class ModelServiceAsync : GenericServiceAsync<Model, ModelDto>
	{
		public ModelServiceAsync(IGenericRepository<Model> genericRepository, IMapper mapper)
			: base(genericRepository, mapper)
		{
		}
	}
}
