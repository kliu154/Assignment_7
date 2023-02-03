using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7.GenericRepository
{
    public class GenericRepository<T> : IRepository<T> where T : Entity, new()
    {
        private List<T> data;

        public GenericRepository()
        {
            data = new List<T>();
        }

        public void Add(T item) 
        {
            data.Add(item);
        }

        public void Remove(T item)
        {
            data.Remove(item);
        }

        public void Save()
        {

        }

        public IEnumerable<T> GetAll()
        {
            return data;
        }

        public T GetById(int id)
        {
            return data.Find(x => x.Id == id);
        }
    }
}
