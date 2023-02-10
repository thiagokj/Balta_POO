using Plataform.SharedContext;

namespace Plataform.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInative => EndDate <= DateTime.Now;
    }
}