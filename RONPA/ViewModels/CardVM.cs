using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RONPA.ViewModels
{
    public class CardVM
    {
        public int Id { get; set; }
        [StringLength(256)]
        public string Text { get;  set; }

        public string EditBtnId { get; set; }
        public string RemoveBtnId { get; set; }

    }
}
