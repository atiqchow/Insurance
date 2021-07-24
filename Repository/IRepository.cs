using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Insurance.Repository
{
    public interface IRepository
    {
        
        Task CreateAsync<T>(T entity) where T : class;
        
    }
}
