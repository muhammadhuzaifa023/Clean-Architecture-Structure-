using AutoMapper;
using BrandApplication.Business.Services.Interface;
using BrandApplication.DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrandApplication.Business.Services.Implementation
{
	public class ReadServiceAsync<TEntity, TDto> : IReadServiceAsync<TEntity, TDto>
		where TEntity : class
		where TDto : class
	{
		private readonly IGenericRepository<TEntity> _genericRepository;
		private readonly IMapper _mapper;

		public ReadServiceAsync(IGenericRepository<TEntity> genericRepository, IMapper mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

		public async Task<IEnumerable<TDto>> GetAllAsync()
		{
			var result = await _genericRepository.GetAllAsync();
			return _mapper.Map<IEnumerable<TDto>>(result);
		}

		public async Task<TDto> GetByIdAsync(int id)
		{
			var result = await _genericRepository.GetByIdAsync(id);
			return _mapper.Map<TDto>(result);
		}
	}
}
