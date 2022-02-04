using System;
using System.Collections.Generic;
using System.Linq;
using RONPA.Domain.Knowledges;

namespace RONPA.UseCase.Knowledges.LinkKnowledgeWithKnowledge
{
    public class KnowledgeWithOneLinker
    {
        private readonly IKnowledgeRepository _knowledgeRepository;
        public KnowledgeWithOneLinker(
            IKnowledgeRepository knowledgeRepository)
        {
            _knowledgeRepository = knowledgeRepository;
        }
        public void Execute(LinkKnowledgeWithKnowledgeCommand command)
        {
            var knowledge = _knowledgeRepository.Find(new KnowledgeId(command.Id));
            var linkedKnowledgeIds = command.LinkedData.Select(x => new KnowledgeId(x.Id))
                                                     .ToList();
            foreach (var linkedKnowledgeId in linkedKnowledgeIds)
            {
                knowledge.IsNotSame(linkedKnowledgeId);
                knowledge.JoinKnowledge(linkedKnowledgeId);
            }
            _knowledgeRepository.Save(knowledge);
        }
    }
}
