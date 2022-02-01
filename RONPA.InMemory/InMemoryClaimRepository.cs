using System;
using System.Collections.Generic;
using RONPA.Domain.Claims;
using RONPA.Domain.Knowledges;
using RONPA.Domain.Thinkings;


namespace RONPA.InMemory
{
    public class InMemoryClaimRepository : IClaimRepository
    {
        private Dictionary<int, Claim> Store = new Dictionary<int, Claim>()
        {
            {1,new Claim(
                new ClaimId(1),
                "テストclaim",
                new List<KnowledgeId>(),
                new ThinkingId(1))
            }
        };
        public Claim Find(int id)
        {
            return Store[id];
        }
        public Claim FindByThinking(ThinkingId id)
        {
            foreach (var item in Store)
            {
                if (item.Value.ThinkingId.Value == id.Value) return item.Value;
            }
            return null;
        }
        public IEnumerable<Claim> FindAll()
        {
            foreach (var item in Store)
            {
                yield return item.Value;
            }
        }
        

        public void Save(Claim claim)
        {
            Store.Add(claim.Id.Value, claim);
        }
        public void Delete(int id)
        {
            Store.Remove(id);
        }
    }
}
