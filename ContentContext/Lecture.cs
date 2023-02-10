using Plataform.ContentContext.Enums;
using Plataform.SharedContext;

namespace Plataform.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public int Title { get; set; }
        public int DurationInMintues { get; set; }
        public EContentLevel Level { get; set; }
    }
}