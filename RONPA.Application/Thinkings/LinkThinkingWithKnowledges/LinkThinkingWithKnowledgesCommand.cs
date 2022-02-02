using System;
using System.Collections.Generic;

namespace RONPA.UseCase.Thinkings.LinkThinkingWithKnowledges
{
    public class LinkThinkingWithKnowledgesCommand:ThinkingBaseCommand
    {
        public LinkThinkingWithKnowledgesCommand(
            int thinking,
            IList<int> knowledgeIds):base(thinking)
        {
            ThinkingId = thinking;
            KnowledgeIds = knowledgeIds;
        }
        public IList<int> KnowledgeIds { get; }
    }
}
