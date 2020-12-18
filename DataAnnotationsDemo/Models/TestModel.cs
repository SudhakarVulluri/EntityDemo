using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationsDemo.Models
{
    public class TestModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public EquineBeast Mount { get; set; }
    }

    public enum EquineBeast
    {
        Donkey,
        Mule,
        Horse,
        Unicorn
    }
}
