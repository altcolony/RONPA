using System;
using System.Collections.Generic;
using System.Linq;
using RONPA.Domain.Thinkings;
using RONPA.Domain.Knowledges;

namespace RONPA.UseCase.Thinkings
{
    public class ThinkingWithKnowledgeLinker
    {
        private readonly IThinkingRepository _thinkingRepository;
        private readonly IKnowledgeRepository _knowledgeRepository;
        public ThinkingWithKnowledgeLinker(
            IThinkingRepository thinkingRepository,
            IKnowledgeRepository knowledgeRepository)
        {
            _thinkingRepository = thinkingRepository;
            _knowledgeRepository = knowledgeRepository;
        }
        public void Execute(ThinkingWithKnowledgeLinkCommand command)
        {
            var thinking = _thinkingRepository.Find(new ThinkingId(command.ThinkingId));
            var knowledgeids = command.KnowledgeIds.Select(x => new KnowledgeId(x)).ToList();
            knowledgeids.ForEach(x => thinking.JoinKnowledge(x));
            _thinkingRepository.Save(thinking);
        }
    }
}
