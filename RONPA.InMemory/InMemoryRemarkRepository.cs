using System;
using System.Collections.Generic;
using System.Text;
using RONPA.Domain;

namespace RONPA.InMemory
{
    public class InMemoryRemarkRepository : IRemarkRepository
    {
        private Dictionary<int, Remark> Store = new Dictionary<int, Remark>()
        {
            {1,new Remark(
                1,
                1,
                "テストツッコミ",
                new List<Remark>()
                    {new Remark(2,1, "テストツッコミ2",null) })

            },
        };
        public Remark Find(int id)
        {
            return Store[id];
        }
        public IEnumerable<Remark> FindAll(IEnumerable<int> ids)
        {
            foreach (var id in ids)
            {
                yield return Store[id];
            }
        }

        public void Save(Remark remark)
        {
            Store.Add(2,remark);
        }
        public void Delete(int id)
        {
            Store.Remove(id);
        }
    }
}
