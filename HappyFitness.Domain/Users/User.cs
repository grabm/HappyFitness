using HappyFitness.Domain.Common;

namespace HappyFitness.Domain.Users
{
    public class User : BaseEntity
    {
        public string Email { get; set; }

        public string UserName { get; set; }

        public string HashedPassword { get; set; }


    }
}
