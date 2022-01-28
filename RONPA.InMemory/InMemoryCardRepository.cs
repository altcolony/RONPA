using System;
using System.Collections.Generic;
using RONPA.Domain;

namespace RONPA.InMemory
{
    public class InMemoryCardRepository:IReasonRepository
    {
        private readonly Dictionary<int, Reason> Store = new Dictionary<int, Reason>()
        {
            {0,new Reason(0,"テストテキスト") },
        };

        public Reason Find(int id)
        {
            return Store[id];
        }
        public IEnumerable<Reason> FindAll(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
                yield return Store[id];
            }
        }
        public IEnumerable<Reason> FindAll()
        {
            foreach (var item in Store)
            {
                yield return item.Value;
            }
        }
        public void Save(Reason card)
        {
            Store.Add(1, card);
        }
        public void Delete(int id)
        {
            Store.Remove(id);
        }
    }
}
