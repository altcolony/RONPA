using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<KnowledgeData> Execute(FetchKnowledgeByThinkingCommand command)
        {
            var knowledges = _knowledgeRepository.FindByThinking(new ThinkingId(command.ThinkingId));
            return knowledges.Select(x => new KnowledgeData(
                x.Id.Value,
                x.Text,
                x.KnowledgeIds.Select(x => x.Value).ToList(),
                x.Date));
        }
    }
}
