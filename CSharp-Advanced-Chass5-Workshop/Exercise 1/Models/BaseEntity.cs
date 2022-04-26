using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    internal abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract void Print();
    }
}
