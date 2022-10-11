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
        /// Цена аренды
        /// </summary>
        public int HireRate = 1;
        /// <summary>
        /// Тип машины
        /// </summary>
        public CarTypes CarTypes = CarTypes.Легковой;

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
    }
}