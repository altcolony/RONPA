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
        private readonly IThinkingRepository _thinkingRepository;
        public KnowledgeByThinkingFetcher(
            IKnowledgeRepository knowledgeRepository,
            IThinkingRepository thinkingRepository)
        {
            _knowledgeRepository = knowledgeRepository;
            _thinkingRepository = thinkingRepository;
        }
        public IEnumerable<KnowledgeData> Execute(FetchKnowledgeByThinkingCommand command)
        {
            var thinking = _thinkingRepository.Find(new ThinkingId(command.ThinkingId));
            var knowledges = _knowledgeRepository.Finds(thinking.KnowledgeIds);
            return knowledges.Select(x => new KnowledgeData(
                x.Id.Value,
                x.Text,
                x.KnowledgeIds.Select(x => x.Value).ToList(),
                x.Date));
        }
    }
}
