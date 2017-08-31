using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avenue.Core.Common;

namespace Avenue.Core
{
  public class Article:AuditabeEntity
    {
      public string Title { get; set; }
      public DateTime DateTime { get; set; }
      public int UserId { get; set; }
      public int Review { get; set; }
      public ICollection<ArticleComment> ArticleComments { get; set; }
    }

    public class ArticleComment
    {
        public Guid Id { get; set; }
        public int ArticleId { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }
        public int UserId { get; set; }

    }
}
