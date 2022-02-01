using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;

namespace RONPA.Domain.Hypothesises
{
    public interface IHypothesisRepository
    {
        public Hypothesis FindByThinking(ThinkingId id);
    }
}
