using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Game
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
    }
}