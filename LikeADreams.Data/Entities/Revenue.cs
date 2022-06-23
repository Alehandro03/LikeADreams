using System;


namespace LikeADreams.Data.Entities
{
    public class Revenue
    {
        //Данный класс хранит в себе информацию по итогам дня, для бух.отчета.
        //Подумать о добовлении еще нужных данных..
        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime TimeRemoval { get; set; }
        public int TypePersonId { get; set; }
        public decimal AllSum { get; set; }
        public int CheckId { get; set; }
    }
}
