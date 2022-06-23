using LikeADreams.Data.Enums;
using System;

namespace LikeADreams.Data.Entities
{
    public class Prechek
    {
        public int Id { get; set; }
        public int OlderId { get; set; }
        public int RegistrationAddressId { get; set; }
        public DateTime TimePrint { get; set; }
        public int TypePersoneId { get; set; }
        public CalculationType CalculationType { get; set; }
        public decimal TotalSum { get; set; }
        public decimal Change { get; set; } //Сдача
    }
}
