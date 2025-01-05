using dressed_backend.Models.DTOs;
using dressed_backend.Models.Entities;
using dressed_backend.Repositories;

namespace dressed_backend.Services
{
    public class DesignService
    {
        private readonly DesignRepository _repository;

        public DesignService(DesignRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<GetDesignDto>> GetAllAsync()
        {
            var designs = await _repository.GetAllAsync();
            return designs.Select(d => new GetDesignDto
            {
                Id = d.Id,
                Title = d.Title,
                Description = d.Description,
                Category = d.Category,
                FileUrl = d.FileUrl

            });
        }

        public async Task AddAsync(CreateDesignDto createDto)
        {
            var design = new Design
            {
                Title = createDto.Title,
                Description = createDto.Description,
                Category = createDto.Category,
                FileUrl = createDto.FileUrl
            };
            await _repository.AddAsync(design);
        }

        public async Task DeleteAsync(int id)
        {
            var design = await _repository.FindAsync(id);
            if (design == null)
            {
                throw new KeyNotFoundException($"Design with ID {id} not found.");
            }

            await _repository.DeleteAsync(design);
        }

         public async Task UpdateAsync(int id, UpdateDesignDto updateDto)
        {
            var design = await _repository.FindAsync(id);
            if (design == null)
            {
                throw new KeyNotFoundException($"Design with ID {id} not found.");
            }

            design.Title = updateDto.Title;
            design.Description = updateDto.Description;
            design.Category = updateDto.Category;
            design.FileUrl = updateDto.FileUrl;

            await _repository.UpdateAsync(design);
        }
    }
}
