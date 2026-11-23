using Gym.Entities.Enums;

namespace Gym.Entities
{
    public class Trainer : GymUser
    {
        public Specialities Speciality { set; get; }
        public ICollection<Session> Sessions { get; set; } = default!;
    }
}
