using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAnnotationsDemo.Models
{
    public class TestModel2
    {
        public int Value { get; set; }
        public TestModel2(int value)
        {
            Value = value;
        }
        private bool Equals(TestModel2 other)
        => Value == other.Value;

        public override bool Equals(object obj)
            => ReferenceEquals(this, obj) || obj is TestModel2 other && Equals(other);

        public override int GetHashCode()
            => Value;
    }
}
