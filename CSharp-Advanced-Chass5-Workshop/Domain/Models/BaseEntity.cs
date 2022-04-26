using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    internal class BaseEntity
    {
        public int Id { get; set; }
        public abstract void Print();
    }
}
