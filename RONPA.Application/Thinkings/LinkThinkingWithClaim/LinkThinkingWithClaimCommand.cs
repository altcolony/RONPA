using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase.Thinkings.LinkThinkingWithClaim
{
    public class LinkThinkingWithClaimCommand:ThinkingBaseCommand
    {
        public LinkThinkingWithClaimCommand(int thinkid,int claimid):base(thinkid)
        {
            ClaimId = claimid;
        }
        public int ClaimId { get; }
    }
}
