using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class GameEntity
    {
        [Key]
        public Guid ID { get; set; }

        public string Name { get; set; }
    }
}