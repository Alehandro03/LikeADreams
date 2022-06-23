using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeADreams.Data.Enums
{
    public enum TaxationSystem
    {
        //Данный енам  отвечает за выбор системы налогообложением компании или ИП
        //Подумать те ли виды  налогообложения указаны и все ли???
        OSNO = 1,
        USN,
        ESXN,
        Patent
    }
}
