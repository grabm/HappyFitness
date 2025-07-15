using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Users
{
    public class UserProfile : BaseEntity
    {
        /// <summary>
        /// Foreign key to the User entity.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// The daily calorie goal in kcal.
        /// </summary>
        public float DailyCalorieGoal { get; set; }

        /// <summary>
        /// The daily protein goal in kcal.
        /// </summary>
        public float DailyProteinGoal { get; set; }

        /// <summary>
        /// The daily carbohydrate goal in kcal.
        /// </summary>
        public float DailyCarbsGoal { get; set; }

        /// <summary>
        /// The daily fat goal in kcal.
        /// </summary>
        public float DailyFatGoal { get; set; }
    }
}
