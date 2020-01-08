using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psychology_Centre.ViewModels
{
    public class SortViewModel
    {
        public SortState SurnameSort { get; private set; } 
        public SortState EmailSort { get; private set; }
        public SortState Current { get; private set; }  

        public SortViewModel(SortState sortOrder)
        {
            SurnameSort = sortOrder == SortState.SurnameAsc ? SortState.SurnameDesk : SortState.SurnameAsc;
            EmailSort = sortOrder == SortState.EmailAsc ? SortState.EmailDesc : SortState.EmailAsc;
            Current = sortOrder;
        }
    }
}
