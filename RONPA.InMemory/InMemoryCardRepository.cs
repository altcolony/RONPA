using System;
using System.Collections.Generic;
using RONPA.Model;

namespace RONPA.InMemory
{
    public class InMemoryCardRepository:ICardRepository
    {
        private readonly Dictionary<int, Card> Store = new Dictionary<int, Card>()
        {
            {0,new Card(0,"テストテキスト") },
        };

        public Card Find(int id)
        {
            return Store[id];
        }
        public IEnumerable<Card> FindAll(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
                yield return Store[id];
            }
        }
        public IEnumerable<Card> FindAll()
        {
            foreach (var item in Store)
            {
                yield return item.Value;
            }
        }
        public void Save(Card card)
        {
            Store.Add(1, card);
        }
        public void Delete(int id)
        {
            Store.Remove(id);
        }
    }
}
