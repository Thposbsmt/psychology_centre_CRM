using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psychology_Centre.ViewModels
{
    public class FilterViewModel
    {
        public string SelectedSurname { get; private set; }
        public string SelectedEmail { get; private set; }

        public FilterViewModel(string surname, string email)
        {
            SelectedSurname = surname;
            SelectedEmail = email;
        }
    }
}
