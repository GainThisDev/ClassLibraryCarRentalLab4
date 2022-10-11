// Прокат автомобилей
// ⦁	 Автомобили (марка, стоимость, стоимость проката, тип).
// ⦁	 Клиенты(фамилия, имя, отчество, адрес, телефон).
// ⦁ Выданные автомобили(автомобиль, клиент, дата выдачи, дата возврата).

namespace ClassLibraryCarRental
{
    /// <summary>
    /// Класс машины
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Модель автомобиля
        /// </summary>
        string Model = string.Empty;
        /// <summary>
        /// Цена авто
        /// </summary>
        int Price = 100;
        /// <summary>
        /// Цена аренды
        /// </summary>
        int HireRate = 10;

    }
}