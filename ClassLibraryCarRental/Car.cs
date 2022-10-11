// Прокат автомобилей
// ⦁	 Автомобили (марка, стоимость, стоимость проката, тип).
// ⦁	 Клиенты(фамилия, имя, отчество, адрес, телефон).
// ⦁ Выданные автомобили(автомобиль, клиент, дата выдачи, дата возврата).

namespace ClassLibraryCarRental
{
    /// <summary>
    /// Класс машины
    /// </summary>
    public class Car : IValidatable
    {
        /// <summary>
        /// Модель автомобиля
        /// </summary>
        public string Model = string.Empty;
        /// <summary>
        /// Цена авто
        /// </summary>
        public int Price = 1;
        /// <summary>
        /// Цена аренды (в день)
        /// </summary>
        public int HireRate = 1;
        /// <summary>
        /// Тип машины
        /// </summary>
        public CarTypes CarType = CarTypes.Легковой;

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
        /// <returns>Описание экземпляра класса</returns>
        public override string ToString()
        {
            return $"Модель: {Model}, Цена: {Price}, " +
                   $"Аренда за сутки: {HireRate}, Тип машины: {CarType}";
        }
    }
}