using HappyFitness.Domain.Common;
using HappyFitness.Domain.Meals;
using HappyFitness.Domain.Workouts;

namespace HappyFitness.Domain.Users
{
    public class User : BaseEntity
    {
        /// <summary>
        /// The user's email address, used for login.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The user's display name within the application.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// The user's hashed password for security purposes.
        /// </summary>
        public string HashedPassword { get; set; }

        /// <summary>
        /// The user's profile containing goals and settings.
        /// </summary>
        public UserProfile Profile { get; set; }

        /// <summary>
        /// A collection of the user's workout plans.
        /// </summary>
        public ICollection<WorkoutPlan> WorkoutPlans { get; set; } = new List<WorkoutPlan>();

        /// <summary>
        /// A collection of the user's performed workout sessions.
        /// </summary>
        public ICollection<WorkoutSession> WorkoutSessions { get; set; } = new List<WorkoutSession>();

        /// <summary>
        /// A collection of the user's meals.
        /// </summary>
        public ICollection<Meal> Meals { get; set; } = new List<Meal>();
    }
}
