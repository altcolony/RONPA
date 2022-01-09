using System;
using System.Collections.Generic;

namespace RONPA.Application
{
    public class GetAllCardCommand
    {
        public GetAllCardCommand(IEnumerable<int> ids)
        {
            Ids = ids;
        }
        public IEnumerable<int> Ids { get; }
    }
}
