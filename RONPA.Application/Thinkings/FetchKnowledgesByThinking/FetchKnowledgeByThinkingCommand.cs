using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase.Thinkings.FetchKnowledgesByThinking
{
    public class FetchKnowledgeByThinkingCommand:ThinkingBaseCommand
    {
        public FetchKnowledgeByThinkingCommand(int id):base(id)
        {
        }
    }
}
