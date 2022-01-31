using System;
using System.Collections.Generic;
using RONPA.Domain;
using RONPA.Domain.Knowledges;


namespace RONPA.InMemory
{
    public class InMemoryCardRepository:IKnowledgeRepository
    {
        private readonly Dictionary<int, Knowledge> Store = new Dictionary<int, Knowledge>()
        {
            {
                0,new Knowledge(new KnowledgeId(0),"テストknowledge") 
            },
        };

        public Knowledge Find(int id)
        {
            return Store[id];
        }
        public IEnumerable<Knowledge> FindAll(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
                yield return Store[id];
            }
        }
        public IEnumerable<Knowledge> FindAll()
        {
            foreach (var item in Store)
            {
                yield return item.Value;
            }
        }
        public void Save(Knowledge card)
        {
            Store.Add(1, card);
        }
        public void Delete(int id)
        {
            Store.Remove(id);
        }
    }
}
