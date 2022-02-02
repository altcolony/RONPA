using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.UseCase.Thinkings
{
    public class ThinkingBaseCommand
    {
        public ThinkingBaseCommand(int thinking)
        {
            ThinkingId = thinking;
        }
        public int ThinkingId { get; protected set; }
    }
}
