using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;

namespace RONPA.Domain.Knowledges
{
    public interface IKnowledgeRepository
    {
        public Knowledge Find(KnowledgeId id);
        public IEnumerable<Knowledge> Finds(IEnumerable<KnowledgeId> ids);
        public IEnumerable<Knowledge> FindAll();

        void Save(Knowledge card);
        //void Delete(KnowledgeId id);
    }
}
