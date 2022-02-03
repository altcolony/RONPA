using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain.Knowledges
{
    public interface IKnowledgeFactory
    {
        public IEnumerable<Knowledge> Create(
            int id,
            string text,
            IList<int> knowledgeIds,
            DateTime date);
        public IEnumerable<Knowledge> Create(
            string text,
            IList<int>knowledgeIds,
            DateTime date);
    }
}
