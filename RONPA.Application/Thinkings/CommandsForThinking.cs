using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase.Thinkings
{
    public class ThinkingWithKnowledgeLinkCommand
    {
        public ThinkingWithKnowledgeLinkCommand(int thinking,IList<int>knowledgeIds)
        {
            ThinkingId = thinking;
            KnowledgeIds = knowledgeIds;
        }
        public int ThinkingId { get; }
        public IList<int> KnowledgeIds { get;  }
    }
}
