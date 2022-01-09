using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RONPA.ViewModels
{
    public class ClaimVM
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public IList<CardVM> CardVMs { get; set; }
        /// <summary>
        /// true:カードを表示 false:非表示
        /// </summary>
        public bool IsCardDisplay { get; set; }
    }
}
