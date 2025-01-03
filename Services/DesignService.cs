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
                Category = d.Category
            });
        }

        public async Task AddAsync(CreateDesignDto createDto)
        {
            var design = new Design
            {
                DesignerId = createDto.DesignerId,
                Title = createDto.Title,
                Description = createDto.Description,
                Category = createDto.Category,
                FileUrl = createDto.FileUrl
            };
            await _repository.AddAsync(design);
        }
    }
}
