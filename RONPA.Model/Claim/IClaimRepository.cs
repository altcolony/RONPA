using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain
{
    public interface IClaimRepository
    {
        Claim Find(int id);
        IEnumerable<Claim> FindAll();
        void Save(Claim claim);
        void Delete(int id);
    }
}
