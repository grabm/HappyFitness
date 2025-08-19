namespace HappyFitness.Application.Dtos
{
    public class WorkoutHistoryDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<string> PerformedExerciseShortNames { get; set; } = new();
    }
}
