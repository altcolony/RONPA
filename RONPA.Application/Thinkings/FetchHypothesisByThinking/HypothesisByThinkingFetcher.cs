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
        public Hypothesis Execute(ThinkingId id)
        {
            return _hypothesisRepository.FindByThinking(id);
        }
    }
}
