using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psychology_Centre.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Midname { get; set; }

        public string Special { get; set; }

        public string Email { get; set; }

        public string PhoneNumberFirst { get; set; }
        
        public string PhoneNumberSecond { get; set; }

        public string PhoneNumberUnformat { get; set; }

        public string PhoneNumberOther { get; set; }

        public string IdVk { get; set; }

        public string ComfyCallTime { get; set; }

        public string Gender { get; set; }

        public string Birthday { get; set; }

        public int Age { get; set; }

        public string FamilyStatus { get; set; }

        public bool IsHaveChildren { get; set; }

        public string Status { get; set; }

        public string Source { get; set } // Источник информирования о Центре.

        public string FieldOfActivity { get; set; } // Сфера деятельности.

        public string Post { get; set; } // Должность.

        public string City { get; set; }

        public string Region { get; set; }

        public string Metro { get; set; }

        public string SelectionFactors { get; set; }

        public string Activity { get; set; } // Месяц первого контакта - последнего посещения.
    }
}
