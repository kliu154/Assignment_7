﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7.GenericRepository
{
    interface IRepository<T> where T : class
    {
        void Add(T item);
        void Remove(T item);
        void Save(string filePath);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
