using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;

namespace RONPA.UseCase.Thinkings
{
    public class ThinkingAllFetcher
    {
        private readonly IThinkingRepository _thinkingRepository;
        public ThinkingAllFetcher(IThinkingRepository thinkingRepository)
        {
            _thinkingRepository = thinkingRepository;
        }
        public IEnumerable<Thinking> Execute()
        {
            return _thinkingRepository.FindAll();
        }

    }
}
