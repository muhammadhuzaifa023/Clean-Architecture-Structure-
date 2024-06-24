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
	public class GenericServiceAsync<TEntity, TDto> : ReadServiceAsync<TEntity, TDto>, IGenericServiceAsync<TEntity, TDto>
		where TEntity : class
		where TDto : class
	{
		private readonly IGenericRepository<TEntity> _genericRepository;
		private readonly IMapper _mapper;

		public GenericServiceAsync(IGenericRepository<TEntity> genericRepository, IMapper mapper)
			: base(genericRepository, mapper)
		{
			_genericRepository = genericRepository;
			_mapper = mapper;
		}

		public async Task AddAsync(TDto dto)
		{
			var entity = _mapper.Map<TEntity>(dto);
			await _genericRepository.AddAsync(entity);
		}

		public async Task DeleteAsync(int id)
		{
			await _genericRepository.DeleteAsync(id);
		}

		public async Task UpdateAsync(TDto dto)
		{
			var entity = _mapper.Map<TEntity>(dto);
			await _genericRepository.UpdateAsync(entity);
		}
	}
}
