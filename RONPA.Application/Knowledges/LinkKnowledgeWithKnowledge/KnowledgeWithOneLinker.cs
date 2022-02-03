using System;
using System.Collections.Generic;
using System.Linq;
using RONPA.Domain.Knowledges;

namespace RONPA.UseCase.Knowledges.LinkKnowledgeWithKnowledge
{
    public class KnowledgeWithOneLinker
    {
        private readonly IKnowledgeRepository _knowledgeRepository;
        private readonly IKnowledgeFactory _knowledgeFactory;
        public KnowledgeWithOneLinker(
            IKnowledgeRepository knowledgeRepository,
            IKnowledgeFactory knowledgeFactory)
        {
            _knowledgeRepository = knowledgeRepository;
            _knowledgeFactory = knowledgeFactory;
        }
        public void Execute(LinkKnowledgeWithKnowledgeCommand command)
        {
            var knowledge = _knowledgeRepository.Find(new KnowledgeId(command.Id));
            var linkedKnowledges = _knowledgeFactory.Create(command.Id,);
        }
    }
}
