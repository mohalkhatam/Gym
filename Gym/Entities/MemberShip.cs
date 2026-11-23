using System.ComponentModel.DataAnnotations.Schema;

namespace Gym.Entities
{
    public class MemberShip : BaseEntity
    {
        public Member Member { get; set; }
        public int MemberId { get; set; }
        public Plan Plan { get; set; }
        public int PlanId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [NotMapped]
        public string status => StartDate > DateTime.Now ? "Upcoming"
                                : EndDate > DateTime.Now ? "Active"
                                : "Expired";
    }
}
