using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetAppUserByIdAsync(int id);
        Task<AppUser> GetAppUserByUserNameAsync(string userName);
        Task<IEnumerable<MemberDTO>> GetMembersDTOAsync();
        Task<MemberDTO> GetMemberDTOAsync(string username);
    }
}