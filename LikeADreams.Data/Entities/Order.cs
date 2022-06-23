using System;

namespace LikeADreams.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public int TypePersoneId { get; set; }
        public int NumberTable { get; set; }
        public DateTime TimeOpen { get; set; }
        public DateTime TimeChange { get; set; }
        public int CategorieId { get; set; }
        public int BaseCommentId { get; set; }
        public int Amount { get; set; }
    }
}
