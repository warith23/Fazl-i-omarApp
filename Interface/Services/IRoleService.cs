using Backend.Dto;

namespace Backend.Interface.Services
{
    public interface IRoleService
    {
        Task<BaseResponse<RoleDto>> CreateRole(RoleDto roleDto);
        Task<BaseResponse<IEnumerable<RoleDto>>> GetRolesByUserId(Guid userId);
    }
}
