using System;
using System.Collections.Generic;

namespace RONPA.Domain
{
    public interface IReasonRepository
    {
        Reason Find(int id);
        IEnumerable<Reason> FindAll(IEnumerable<int> ids);
        IEnumerable<Reason> FindAll();

        void Save(Reason card);
        void Delete(int id);
    }
}
