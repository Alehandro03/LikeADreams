using LikeADreams.Data.Enums;
using System;

namespace LikeADreams.Data.Entities
{
    public class Check
    {
        public int Id { get; set; }
        public TaxationSystem TaxationSystem { get; set; }
        public int PrechekId { get; set; }
        public int FiscalSignOfCorrection { get; set; }
        public int CorrectionTicketNumber { get; set; }
        public DateTime TimeCorrection { get; set; }
    }
}
