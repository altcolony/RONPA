using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain
{
    public class Thinking
    {
        public int Id { get; }
        public string Text { get;private set; }
        public IList<Reason> Reasons { get; }
        public Claim Claim { get; }
    }
}
