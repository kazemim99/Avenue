using System;
using Avenue.Core.Common;

namespace Avenue.Core
{
    public class Review : AuditabeEntity
    {
        public string Content { get; set; }
        public Guid UserId { get; set; }
        public Guid AvenueDetailsId { get; set; }
        public int Like { get; set; }
        public int DisLike { get; set; }
        public Guid AnswerId { get; set; }
        public int ScoreId { get; set; }
        public string UserIp { get; set; }
        public bool Suggestion { get; set; }

        public WeddingVenues WeddingVenues { get; set; }
        public Score Score { get; set; }
        public Review Answer { get; set; }
        //public ApplicationUser User { get; set; }
    }
}