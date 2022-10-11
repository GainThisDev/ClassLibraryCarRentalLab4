// Прокат автомобилей
// ⦁	 Автомобили (марка, стоимость, стоимость проката, тип).
// ⦁	 Клиенты(фамилия, имя, отчество, адрес, телефон).
// ⦁ Выданные автомобили(автомобиль, клиент, дата выдачи, дата возврата).

namespace ClassLibraryCarRental
{
    /// <summary>
    /// Машина в аренде
    /// </summary>
    public class CarInRent : IValidatable
    {
        /// <summary>
        /// Машина
        /// </summary>
        public Car? car { get; set; }
        /// <summary>
        /// Клиент
        /// </summary>
        public Client? client { get; set; }
        /// <summary>
        /// Дата начала проживания
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// Дата окончания проживания
        /// </summary>
        public DateTime EndDate { get; set; }
        public bool IsValid
        {
            get
            {
                if (client == null) return false;
                if (car == null) return false;
                if (EndDate <= StartDate) return false;
                return true;
            }
        }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public CarInRent() { }
        /// <summary>
        /// Конструктор с параметрами введенным пользователем
        /// </summary>
        /// <param name="car">Машина</param>
        /// <param name="client">Клиент</param>
        /// <param name="startDate">Дата начала аренды</param>
        /// <param name="endDate">Дата окончания аренды</param>
        public CarInRent(Car? car, Client? client, DateTime startDate, DateTime endDate)
        {
            this.car = car;
            this.client = client;
            StartDate = startDate;
            EndDate = endDate;
        }
        /// <summary>
        /// Переопределение метода ToString() для класса аренды машины
        /// </summary>
        /// <returns>Строка описание класса аренды машины</returns>
        public override string ToString()
        {
            return $"Клиент: {client}, Машина: {car}, Начало аренды: {StartDate}, Конец аренды: {EndDate}\n";
        }
    }
}
