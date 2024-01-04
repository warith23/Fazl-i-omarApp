using Backend.Dto;
using Backend.Entities;
using Backend.Interface.Repositories;
using Backend.Interface.Services;

namespace Backend.Implementation.Services
{
    public class LevelService : ILevelService
    {
        private readonly ILevelRepository _levelRepository;
        public LevelService(ILevelRepository levelRepository) 
        {
            _levelRepository = levelRepository;
        }
        public async Task<BaseResponse<LevelDto>> Create(LevelDto levelDto)
        {
            var getLevel = await _levelRepository.Get(l => l.LevelName == levelDto.LevelName);
            if (getLevel != null)
            {
                return new BaseResponse<LevelDto>
                {
                    Message = "already exist",
                    Status = false
                };
            }
            var level = new Level
            {
                LevelName = levelDto.LevelName
            };
            await _levelRepository.Register(level);

            var levelDTO = new LevelDto 
            { 
                LevelName = level.LevelName
            };

            return new BaseResponse<LevelDto>
            {
                Message = "crested succesfully",
                Status = true,
                Data = levelDTO
            };
        }

        Task<BaseResponse<LevelDto>> ILevelService.Delete(Guid levelId)
        {
            throw new NotImplementedException();
        }

        Task<BaseResponse<LevelDto>> ILevelService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<BaseResponse<LevelDto>> ILevelService.Update(LevelDto levelDto, Guid levelId)
        {
            throw new NotImplementedException();
        }
    }
}
