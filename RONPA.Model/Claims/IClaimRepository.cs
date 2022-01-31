using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;

namespace RONPA.Domain.Claims
{
    public interface IClaimRepository
    {
        public Claim Find(int id);
       // public Claim FindByThinking(ThinkingId id);
        public IEnumerable<Claim> FindAll();
        public void Save(Claim claim);
        public void Delete(int id);
    }
}
