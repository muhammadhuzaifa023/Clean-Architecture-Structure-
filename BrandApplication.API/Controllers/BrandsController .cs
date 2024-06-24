using BrandApplication.Business.DTOs;
using BrandApplication.Business.Services.Implementation;
using Microsoft.AspNetCore.Mvc;

namespace BrandApplication.API.Controllers
{
	public class BrandsController : ControllerBase
	{
		private readonly BrandServiceAsync _brandService;

		public BrandsController(BrandServiceAsync brandService)
		{
			_brandService = brandService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<BrandDto>>> GetAll()
		{
			var brands = await _brandService.GetAllAsync();
			return Ok(brands);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<BrandDto>> GetById(int id)
		{
			var brand = await _brandService.GetByIdAsync(id);
			if (brand == null)
			{
				return NotFound();
			}
			return Ok(brand);
		}

		[HttpPost]
		public async Task<ActionResult> Create(BrandDto brandDto)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			await _brandService.AddAsync(brandDto);
			return CreatedAtAction(nameof(GetById), new { id = brandDto.BrandId }, brandDto);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult> Update(int id, BrandDto brandDto)
		{
			if (id != brandDto.BrandId)
			{
				return BadRequest();
			}

			await _brandService.UpdateAsync(brandDto);

			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			await _brandService.DeleteAsync(id);
			return NoContent();
		}

	}
}
