using System;
using System.Collections.Generic;
using RONPA.Domain.Thinkings;

namespace RONPA.Domain.Knowledges
{
    public interface IKnowledgeRepository
    {
        public Knowledge Find(int id);
        public IEnumerable<Knowledge> FindByThinking(IEnumerable<ThinkingId> ids);
        public IEnumerable<Knowledge> FindAll();

        void Save(Knowledge card);
        void Delete(int id);
    }
}
