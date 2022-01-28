using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain
{

    public interface IRemarkRepository
    {
        Remark Find(int id);
        IEnumerable<Remark> FindAll(IEnumerable<int> ids);

        void Save(Remark remark);
        void Delete(int id);

    }
}
