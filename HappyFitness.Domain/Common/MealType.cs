namespace HappyFitness.Domain.Common
{
    public class MealType : BaseEntity
    {
        /// <summary>
        /// The name of the meal type, e.g., "Breakfast", "Lunch", "Dinner".
        /// </summary>
        public string Name { get; set; }
    }
}
