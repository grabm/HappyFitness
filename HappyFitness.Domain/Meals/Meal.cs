using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Meals
{
    public class Meal : BaseEntity
    {
        public Guid UserId { get; set; }

        public Guid MealTypeId { get; set; }

        public DateTime Date { get; set; }

        public ICollection<MealEntry> MealEntries { get; set; } = new List<MealEntry>();
    }
}
