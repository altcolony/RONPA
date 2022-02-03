using System;
using System.Collections.Generic;
using System.Linq;
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
        public ClaimData Execute(FetchClaimByThinkingCommand command)
        {
            var claim = _claimRepository.FindByThinking(new ThinkingId(command.ThinkingId));
            return new ClaimData(
                claim.Id.Value,
                claim.Text,
                claim.KnowledgeIds.Select(x=>x.Value).ToList(),
                claim.ThinkingId.Value,
                claim.Date);
        }
    }
}
