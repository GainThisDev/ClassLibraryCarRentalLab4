// Прокат автомобилей
// ⦁	 Автомобили (марка, стоимость, стоимость проката, тип).
// ⦁	 Клиенты(фамилия, имя, отчество, адрес, телефон).
// ⦁ Выданные автомобили(автомобиль, клиент, дата выдачи, дата возврата).

namespace ClassLibraryCarRental
{
    /// <summary>
    /// Машина
    /// </summary>
    public class Car : IValidatable
    {
        /// <summary>
        /// Модель автомобиля
        /// </summary>
        public string Model { get; set; } = string.Empty;
        /// <summary>
        /// Цена авто
        /// </summary>
        public int Price { get; set; } = 1;
        /// <summary>
        /// Цена аренды (в день)
        /// </summary>
        public int HireRate { get; set; } = 1;
        /// <summary>
        /// Тип машины
        /// </summary>
        public CarTypes CarType { get; set; } = CarTypes.Легковой;
        /// <summary>
        /// Реализация интерфейса валидации для класса машины
        /// </summary>
        public bool IsValid
        {
            get 
            { 
                if (string.IsNullOrEmpty(Model)) return false;
                if (Price <= 1) return false;
                if (HireRate <= 1) return false;
                return true;
            }
        }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Car() { }
        /// <summary>
        /// Конструктор класса на основе данных пользователя
        /// </summary>
        /// <param name="model">Модель машины</param>
        /// <param name="price">Цена машины</param>
        /// <param name="hireRate">Цена аренды (в день)</param>
        /// <param name="carType">Тип машины (легковая, грузовая)</param>
        public Car(string model, int price, int hireRate, CarTypes carType)
        {
            Model = model;
            Price = price;
            HireRate = hireRate;
            CarType = carType;
        }
        /// <summary>
        /// Переопределение метода ToString() для 
        /// поледующего корректного вывода в ListView
        /// </summary>
        /// <returns>Строка описание класса машины</returns>
        public override string ToString()
        {
            return $"Модель: {Model}, Цена: {Price}, " +
                   $"Аренда за сутки: {HireRate}, Тип машины: {CarType}\n";
        }
    }
}