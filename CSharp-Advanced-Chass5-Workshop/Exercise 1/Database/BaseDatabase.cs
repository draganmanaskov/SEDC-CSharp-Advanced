using System;
using System.Collections.Generic;
using System.Text;

using Exercise_1.Enums;
using Exercise_1.Models;

namespace Exercise_1.Database
{
    internal class BaseDatabase<T> where T: BaseEntity
    {
        public List<T> Entities = new List<T>();

        public BaseDatabase()
        {

        }

        public BaseDatabase(List<T> entities)
        {
            Entities.AddRange(entities);
        }

        public virtual void PrintAll()
        {
            foreach(T entity in Entities)
            {
                entity.Print();
            }
        }

        public void Insert(T item)
        {
            Entities.Add(item);
        }

        public void InsertMany(List<T> items)
        {
            Entities.AddRange(items);
        }

    }
}
