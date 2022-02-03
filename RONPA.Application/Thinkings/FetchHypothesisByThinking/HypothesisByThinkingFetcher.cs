using System;
using System.Collections.Generic;
using RONPA.Domain.Hypothesises;
using RONPA.Domain.Thinkings;

namespace RONPA.UseCase.Thinkings.FetchHypothesisByThinking
{
    public class HypothesisByThinkingFetcher
    {
        private readonly IHypothesisRepository _hypothesisRepository;
        public HypothesisByThinkingFetcher(IHypothesisRepository hypothesisRepository)
        {
            _hypothesisRepository = hypothesisRepository;
        }
        public HypothesisData Execute(ThinkingId id)
        {
            var hypothesis = _hypothesisRepository.FindByThinking(id);
            return new HypothesisData(
                hypothesis.Id.Value,
                hypothesis.Text,
                hypothesis.ThinkingId.Value,
                hypothesis.Date);
        }
    }
}
