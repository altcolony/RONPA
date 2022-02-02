using System;
using System.Collections.Generic;
using RONPA.Domain.Claims;
using RONPA.Domain.Thinkings;

namespace RONPA.UseCase.Thinkings.FetchClaimByThinking
{
    public class ClaimByThinkingFetcher
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimByThinkingFetcher(
            IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }
        public Claim Execute(FetchClaimByThinkingCommand command)
        {
            return _claimRepository.FindByThinking(new ThinkingId(command.ThinkingId));
        }
    }
}
