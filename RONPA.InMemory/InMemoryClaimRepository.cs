﻿using System;
using System.Collections.Generic;
using RONPA.Domain;

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
