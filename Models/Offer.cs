namespace Offer_API.Models
{
    /// <summary>
    /// Модель "Оффер"
    /// </summary>
    public class Offer
    {
        /// <summary>
        /// Уникальный идентификатор оффера
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Марка автомобиля
        /// </summary>
        public required string Brand { get; set; }

        /// <summary>
        /// Модель автомобиля
        /// </summary>
        public required string Model { get; set; }

        /// <summary>
        /// Уникальный идентификатор поставщика автомобиля
        /// </summary>
        public required int SupplierId { get; set; }

        /// <summary>
        /// Поставщик, связанный с оффером
        /// </summary>
        public virtual Supplier Supplier { get; set; }

        /// <summary>
        /// Дата регистрации оффера
        /// </summary>
        public DateTime RegistrationDate { get; set; }
    }
}
