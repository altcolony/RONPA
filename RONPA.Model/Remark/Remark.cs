using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Model
{
    /// <summary>
    /// ツッコミModel
    /// </summary>
    public class Remark
    {
        public Remark(
            int id,
            int claimId,
            string text,
            IEnumerable<Remark>relateRemarks)
        {
            Id = id;
            ClaimId = claimId;
            Text = text;
            RelateRemarks = relateRemarks;
        }
        public int Id { get; }
        public int ClaimId { get; }
        public string Text { get; private set; }
        public IEnumerable<Remark> RelateRemarks { get; set; }

        public void ChangeText(string text)
        {
            Text = text;
        }
    }
}
