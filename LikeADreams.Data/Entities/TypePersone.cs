using LikeADreams.Data.Enums;
using System;

namespace LikeADreams.Data.Entities
{
    public class TypePersone
    {
        public int Id { get; set; }
        public Posts Post { get; set; }
        public Powers Power { get; set; }
        public int PersonId { get; set; }
        public int Color { get; set; }
        public int Password { get; set; }
    }
}
