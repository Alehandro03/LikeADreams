using System;

namespace LikeADreams.Data.Entities
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddTime { get; set; }
        public decimal Price { get; set; }
        public int CategorieId { get; set; }
    }
}
