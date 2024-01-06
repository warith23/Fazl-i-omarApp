using Backend.Dto;
using Backend.Entities;

namespace Backend.Interface.Services
{
    public interface ISubjectService
    {
        Task<BaseResponse<SubjectDto>> Create(SubjectDto subjectDto);
        Task<BaseResponse<SubjectDto>> Update(SubjectDto subjectDto, Guid subjectId);
        Task<BaseResponse<SubjectDto>> Get(Guid id);
        Task<BaseResponse<SubjectDto>> Delete(Guid subjectId);
        Task<BaseResponse<IEnumerable<SubjectDto>>> GetAll();
    }
}