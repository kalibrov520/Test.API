using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.API.Extansions;
using Test.API.Models;

namespace Test.API.Data
{
    public interface ITestRepository
    {
        void Add<T>(T entity) where T : class;
        
        void Delete<T>(T entity) where T : class;
        
        Task<bool> SaveAll();
        
        Task<PagedList<User>> GetUsers(UserParams userParams);
        
        Task<User> GetUser(int id);
    }
}