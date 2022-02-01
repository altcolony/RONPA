using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain.Thinkings
{
    public interface IThinkingRepository
    {
        public IEnumerable<Thinking> FindAll();
        public Thinking Find(ThinkingId id);
        public void Save(Thinking thinking);
    }
}
