using System;
using System.Collections.Generic;
using RONPA.Domain.Claims;
using RONPA.Domain.Thinkings;

namespace RONPA.UseCase.Thinkings
{
    public class ClaimByThinkingFetcher
    {
        private readonly IClaimRepository _claimRepository;

        public ClaimByThinkingFetcher(
            IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }
        public Claim Execute(ThinkingId id)
        {
            return _claimRepository.FindByThinking(id);
        }
    }
}
