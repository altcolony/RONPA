using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain.Knowledges
{
    public interface IKnowledgeFactory
    {
        public Knowledge Create();
    }
}
