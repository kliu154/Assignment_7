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

        public void Save(string filePath)
        {
            List<string> lines = new List<string>();
            StringBuilder line = new StringBuilder();

            var cols = data[0].GetType().GetProperties();

            foreach ( var col in cols )
            {
                lines.Append(col.Name);
                lines.Append(",");
            }

            lines.Add(line.ToString().Substring(0, line.Length - 1));

            foreach (var row in data)
            {
                line = new StringBuilder();

                foreach ( var col in cols)
                {
                    line.Append(col.GetValue(row));
                    line.Append(",");
                }

                lines.Add(line.ToString().Substring(0, line.Length - 1));
            }
            
            System.IO.File.WriteAllLines(filePath, lines);
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
