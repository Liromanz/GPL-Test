namespace Offer_API.Models
{
    /// <summary>
    /// Модель "Поставщик"
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Уникальный идентификатор поставщика
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование поставщика
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Дата создания записи о поставщике
        /// </summary>
        public required DateTime CreatedDate { get; set; }

        /// <summary>
        /// Список предложений, связанных с поставщиком
        /// </summary>
        public virtual List<Offer> Offers { get; set; } = new List<Offer>();
    }
}
