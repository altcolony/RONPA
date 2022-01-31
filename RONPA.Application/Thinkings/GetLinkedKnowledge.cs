using System;
using System.Collections.Generic;
using RONPA.Domain.Knowledges;
using RONPA.Domain.Thinkings;

namespace RONPA.UseCase.Thinkings
{
    public class GetLinkedKnowledge
    {
        private readonly IThinkingRepository _thinkingRepository;
        private readonly IKnowledgeRepository _knowledgeRepository;
        public GetLinkedKnowledge(
            IThinkingRepository thinkingRepository,
            IKnowledgeRepository knowledgeRepository)
        {
            _thinkingRepository = thinkingRepository;
            _knowledgeRepository = knowledgeRepository;
        }
        public IEnumerable<Knowledge> Execute(ThinkingId id)
        {
            var thiking = _thinkingRepository.Find(id);
            return _knowledgeRepository.FindByThinking(thiking.Id);
        }
    }
}
