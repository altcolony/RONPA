using System;
using System.Collections.Generic;
using RONPA.Domain.Claims;

namespace RONPA.Application.Claims
{
    public class ClaimApplication
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimApplication(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }
        public IEnumerable<Claim> GetAll()
        {
            return _claimRepository.FindAll();
        }
    }
}
