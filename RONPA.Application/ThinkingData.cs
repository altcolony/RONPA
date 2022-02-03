using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase
{
    public class ThinkingData
    {
        public ThinkingData(
            int id,
            string text,
            IList<int>knowledgeIds,
            int claimid,
            DateTime date)
        {
            Id = id;
            Text = text;
            KnowledgeIds = knowledgeIds;
            ClaimId = claimid;
            Date = date;
        }
        public int Id { get;  }
        public string Text { get; }
        public IList<int> KnowledgeIds { get; }
        public int ClaimId { get;  }
        public DateTime Date { get; }
    }
}
