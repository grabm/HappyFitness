using HappyFitness.Domain.Common;
using HappyFitness.Domain.Users;

namespace HappyFitness.Domain.Meals
{
    public class Meal : BaseEntity
    {
        /// <summary>
        /// Foreign key to the User entity.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Navigation property to the parent User.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Foreign key to the MealType entity.
        /// </summary>
        public Guid MealTypeId { get; set; }

        /// <summary>
        /// Navigation property to the related MealType.
        /// </summary>
        public MealType MealType { get; set; }

        /// <summary>
        /// The date the meal was consumed.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// A collection of food products eaten as part of this meal.
        /// </summary>
        public ICollection<MealEntry> MealEntries { get; set; } = new List<MealEntry>();
    }
}
