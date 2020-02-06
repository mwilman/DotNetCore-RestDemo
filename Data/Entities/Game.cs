using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Game
    {
        [Key]
        public Guid ID { get; set; }

        public string Name { get; set; }
    }
}