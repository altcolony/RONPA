using System;
using System.Collections.Generic;
using System.Linq;
using RONPA.Domain.Thinkings;

namespace RONPA.UseCase.Thinkings.FetchAll
{
    public class ThinkingAllFetcher
    {
        private readonly IThinkingRepository _thinkingRepository;
        public ThinkingAllFetcher(IThinkingRepository thinkingRepository)
        {
            _thinkingRepository = thinkingRepository;
        }
        public IEnumerable<ThinkingData> Execute()
        {
            var thinkings = _thinkingRepository.FindAll();
            return thinkings.Select(x => new ThinkingData(
                x.Id.Value,
                x.Text,
                x.KnowledgeIds.Select(x => x.Value).ToList(),
                x.ClaimId.Value,
                x.Date));
        }

    }
}
