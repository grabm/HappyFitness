namespace HappyFitness.Domain.Common
{
    public class FoodSource : BaseEntity
    {
        /// <summary>
        /// The source of the food product, e.g., "System Database", "User Defined"
        /// </summary>
        public string Name { get; set; }
    }
}
