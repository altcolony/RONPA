using System;
using System.Collections.Generic;
using System.Text;
using RONPA.Domain.Thinkings;
using RONPA.Domain.Claims;

namespace RONPA.UseCase.Thinkings.LinkThinkingWithClaim
{
    public class ThinkingWithClaimLinker
    {
        private readonly IThinkingRepository _thinkingRepository;
        public ThinkingWithClaimLinker(IThinkingRepository thinkingRepository)
        {
            _thinkingRepository = thinkingRepository;
        }
        public void Execute(LinkThinkingWithClaimCommand command)
        {
            //register claim 
            var thinking = _thinkingRepository.Find(new ThinkingId(command.ThinkingId));
            thinking.AttachClaim(new ClaimId(command.ClaimId));

        }
    }
}
