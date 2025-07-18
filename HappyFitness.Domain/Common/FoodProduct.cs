namespace HappyFitness.Domain.Common
{
    public class FoodProduct : BaseEntity
    {
        /// <summary>
        /// Foreign key to the FoodSource entity.
        /// </summary>
        public Guid FoodSourceId { get; set; }

        /// <summary>
        /// Navigation property to the related FoodSource.
        /// </summary>
        public FoodSource FoodSource { get; set; }

        /// <summary>
        /// The name of the food product, e.g., "Chicken Egg".
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The number of calories per 100g of the product.
        /// </summary>
        public float CaloriesPer100g { get; set; }

        /// <summary>
        /// The amount of protein in grams per 100g of the product.
        /// </summary>
        public float ProteinPer100g { get; set; }

        /// <summary>
        /// The amount of carbohydrates in grams per 100g of the product.
        /// </summary>
        public float CarbsPer100g { get; set; }

        /// <summary>
        /// The amount of fat in grams per 100g of the product.
        /// </summary>
        public float FatPer100g { get; set; }
    }
}
