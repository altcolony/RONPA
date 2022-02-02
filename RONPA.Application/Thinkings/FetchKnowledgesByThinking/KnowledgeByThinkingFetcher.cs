using System;
using System.Collections.Generic;
using RONPA.Domain.Knowledges;
using RONPA.Domain.Thinkings;

namespace RONPA.UseCase.Thinkings.FetchKnowledgesByThinking
{
    public class KnowledgeByThinkingFetcher
    {
        private readonly IKnowledgeRepository _knowledgeRepository;
        public KnowledgeByThinkingFetcher(
            IKnowledgeRepository knowledgeRepository)
        {
            _knowledgeRepository = knowledgeRepository;
        }
        public IEnumerable<Knowledge> Execute(FetchKnowledgeByThinkingCommand command)
        {
            return _knowledgeRepository.FindByThinking(new ThinkingId(command.ThinkingId));
        }
    }
}
