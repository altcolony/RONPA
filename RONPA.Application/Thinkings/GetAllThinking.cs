using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;

namespace RONPA.UseCase.Thinkings
{
    public class GetAllThinking
    {
        private readonly IThinkingRepository _thinkingRepository;
        public GetAllThinking(IThinkingRepository thinkingRepository)
        {
            _thinkingRepository = thinkingRepository;
        }
        public IEnumerable<Thinking> Run()
        {
            return _thinkingRepository.FindAll();
        }

    }
}
