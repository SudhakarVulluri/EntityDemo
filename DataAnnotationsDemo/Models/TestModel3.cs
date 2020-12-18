using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsDemo.Models
{
    public class TestModel3
    {
        [Key]
        public int Id3 { get; set; }
        public string Name3 { get; set; }
        public TestModel4 testModel4 { get; set; }
    }
}
