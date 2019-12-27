using CONNECTION.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CONNECTION.Repositories
{
    public class Repository : IRepository
    {
        private readonly List<Peoples> _data;

        public Repository()
        {
            _data = new List<Peoples>();
        }

        public Peoples Get(Guid id)
        {
            return _data.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Peoples> GetAll()
        {
            return _data;
        }

        public void Post(Peoples o)
        {
            _data.Add(o);
        }

        public void Put(Peoples o)
        {
            var index = _data.FindIndex(0, _data.Count, p => p.Id == o.Id);
            _data[index] = o;
        }

        public void Delete(Peoples o)
        {
            _data.Remove(o);
        }
    }
}
