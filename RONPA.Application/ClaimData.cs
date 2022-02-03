using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase
{
    public class ClaimData
    {

        public ClaimData(
            int id,
            string text,
            IList<int>knowledgeIds,
            int thinkingid,
            DateTime date)
        {
            Id = id;
            Text = text;
            KnowledgeIds = knowledgeIds;
            ThinkingId = thinkingid;
            Date = date;
        }
        public int Id { get; }
        public string Text { get; }
        public IList<int> KnowledgeIds { get; }
        public int ThinkingId { get; }
        public DateTime Date { get;  }
    }
}
