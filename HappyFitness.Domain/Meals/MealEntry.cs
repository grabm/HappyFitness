using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Meals
{
    public class MealEntry : BaseEntity
    {
        /// <summary>
        /// Foreign key to the parent Meal.
        /// </summary>
        public Guid MealId { get; set; }

        /// <summary>
        /// Navigation property to the parent Meal.
        /// </summary>
        public Meal Meal { get; set; }

        /// <summary>
        /// Foreign key to the FoodProduct entity.
        /// </summary>
        public Guid FoodProductId { get; set; }

        /// <summary>
        /// Navigation property to the related FoodProduct.
        /// </summary>
        public FoodProduct FoodProduct { get; set; }

        /// <summary>
        /// The actual weight of the consumed product in grams.
        /// </summary>
        public float WeightInGrams { get; set; }
    }
}
