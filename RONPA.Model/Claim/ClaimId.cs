using System;
using System.Collections.Generic;
using System.Text;

namespace RONPA.Domain
{
    public class ClaimId:IEquatable<ClaimId>
    {
        public ClaimId(int value)
        {
            Value = value;
        }
        public int Value { get; }

        public bool Equals(ClaimId other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(Value, other.Value);
        }

        /// <summary>
        /// 等価
        /// </summary>
        /// <param name="obj">比較対象</param>
        /// <returns>true: 等しい</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((ClaimId)obj);
        }

        /// <summary>
        /// ハッシュ値生成
        /// </summary>
        /// <returns>ハッシュ値</returns>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
