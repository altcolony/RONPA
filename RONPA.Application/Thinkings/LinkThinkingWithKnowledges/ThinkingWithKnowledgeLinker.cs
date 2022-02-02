using System;
using System.Collections.Generic;
using System.Linq;
using RONPA.Domain.Thinkings;
using RONPA.Domain.Knowledges;

namespace RONPA.UseCase.Thinkings.LinkThinkingWithKnowledges
{
    public class ThinkingWithKnowledgeLinker
    {
        private readonly IThinkingRepository _thinkingRepository;
        public ThinkingWithKnowledgeLinker(
            IThinkingRepository thinkingRepository)
        {
            _thinkingRepository = thinkingRepository;
        }
        public void Execute(LinkThinkingWithKnowledgesCommand command)
        {
            var thinking = _thinkingRepository.Find(new ThinkingId(command.ThinkingId));
            var knowledgeids = command.KnowledgeIds.Select(x => new KnowledgeId(x)).ToList();
            knowledgeids.ForEach(x => thinking.JoinKnowledge(x));
            _thinkingRepository.Save(thinking);
        }
    }
}
