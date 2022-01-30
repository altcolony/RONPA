using System;
using System.Collections.Generic;

namespace RONPA.Domain
{
    public interface IKnowledgeRepository
    {
        Knowledge Find(int id);
        IEnumerable<Knowledge> FindAll(IEnumerable<int> ids);
        IEnumerable<Knowledge> FindAll();

        void Save(Knowledge card);
        void Delete(int id);
    }
}
