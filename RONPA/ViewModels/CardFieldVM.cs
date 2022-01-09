using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RONPA.ViewModels
{
    public class CardFieldVM
    {
        public int Id { get; }
        public IList<CardVM> CardVMs { get; set; }
    }
}
