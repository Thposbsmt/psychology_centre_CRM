using System;
using System.ComponentModel.DataAnnotations;

namespace Psychology_Centre.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите имя клиента")]
        [RegularExpression(@"^[А-Я]+[а-яА-Я''-'\s]*$", 
            ErrorMessage = "Имя должно быть написано русскими буквами и начинаться с заглавной буквы")]
        public string Name { get; set; }

        [RegularExpression(@"^[А-Я]+[а-яА-Я''-'\s]*$", 
            ErrorMessage = "Фамилия должна быть написана русскими буквами и начинаться с заглавной буквы")]
        public string Surname { get; set; }

        [RegularExpression(@"^[А-Я]+[а-яА-Я''-'\s]*$", 
            ErrorMessage = "Отчество должно быть написано русскими буквами и начинаться с заглавной буквы")]
        public string Midname { get; set; }

        public bool Special { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^8+[1-9]*$", ErrorMessage = "Номер телефона должен начинаться на 8")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "В номере должно быть 11 цифр")]
        public string PhoneNumberFirst { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^8+[1-9]*$", ErrorMessage = "Номер телефона должен начинаться на 8")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "В номере должно быть 11 цифр")]
        public string PhoneNumberSecond { get; set; }

        public string PhoneNumberUnformat { get; set; }

        public string PhoneNumberOther { get; set; }

        public string IdVk { get; set; }

        public string ComfyCallTime { get; set; }

        public string Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        public int Age { get; set; }

        public string FamilyStatus { get; set; }

        public bool IsHaveChildren { get; set; }

        public string Status { get; set; }

        public string Source { get; set; } // Источник информирования о Центре.

        public string FieldOfActivity { get; set; } // Сфера деятельности.

        public string Post { get; set; } // Должность.

        public string City { get; set; }

        public string Region { get; set; }

        public string Metro { get; set; }

        public string SelectionFactors { get; set; }

        public string Activity { get; set; } // Месяц первого контакта - последнего посещения.
    }
}
