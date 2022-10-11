// Прокат автомобилей
// ⦁	 Автомобили (марка, стоимость, стоимость проката, тип).
// ⦁	 Клиенты(фамилия, имя, отчество, адрес, телефон).
// ⦁ Выданные автомобили(автомобиль, клиент, дата выдачи, дата возврата).

namespace ClassLibraryCarRental
{
    public class Client : IValidatable
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; } = string.Empty;
        /// <summary>
        /// Отчество
        /// </summary>
        public string MiddleName { get; set; } = string.Empty;
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; } = string.Empty;
        /// <summary>
        /// Адрес
        /// </summary>
        public string Adress { get; set; } = string.Empty;
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;
        /// <summary>
        /// Реализация интерфейса валидации для класса клиента
        /// </summary>
        public bool IsValid
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName)) return false;
                if (string.IsNullOrWhiteSpace(MiddleName)) return false;
                if (string.IsNullOrWhiteSpace(LastName)) return false;
                if (!string.IsNullOrWhiteSpace(Adress)) return false;
                if (string.IsNullOrWhiteSpace(PhoneNumber)) return false;
                return true;
            }
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Client() { }
        /// <summary>
        /// Конструктор с параметрами заданными пользователем
        /// </summary>
        /// <param name="firstName">Имя клиента</param>
        /// <param name="middleName">Отчество клиента</param>
        /// <param name="lastName">Фамилия клиента</param>
        /// <param name="adress">Адрес клиента</param>
        /// <param name="phoneNumber">Номер телефона клиента</param>
        public Client(string firstName, string middleName, 
            string lastName, string adress, string phoneNumber)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Adress = adress;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"Имя: {FirstName}, Фамилия: {LastName}, Отчество: {LastName}, Адрес: {Adress}, Номер телефона: {PhoneNumber}\n";
        }
    }
}
