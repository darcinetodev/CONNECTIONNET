using CONNECTION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONNECTION.Repositories
{
    public interface IRepository
    {
        void Post(Peoples peoples);
        void Put(Peoples peoples);
        IEnumerable<Peoples> GetAll();
        Peoples Get(Guid id);
        void Delete(Peoples peoples);
    }
}
