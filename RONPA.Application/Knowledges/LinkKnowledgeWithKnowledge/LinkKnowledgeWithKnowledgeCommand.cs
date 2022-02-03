using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase.Knowledges.LinkKnowledgeWithKnowledge
{
    public class LinkKnowledgeWithKnowledgeCommand
    {
        public LinkKnowledgeWithKnowledgeCommand(
            int id,
            IList<KnowledgeData>linkedDatas)
        {
            Id = id;
            LinkedData = linkedDatas;
        }
        public int Id { get;  }
        public IList<KnowledgeData> LinkedData { get; }
    }
}
