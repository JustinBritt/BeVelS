namespace BeVelS.Common.Comparers.Classes
{
    using System;

    using BeVelS.Common.Comparers.Interfaces;

    internal sealed class GuidEqualityComparerRef : IGuidEqualityComparerRef
    {
        public GuidEqualityComparerRef()
        {
        }

        public bool Equals(
            ref Guid a,
            ref Guid b)
        {
            return a.Equals(
                b);
        }

        public int Hash(
            ref Guid item)
        {
            return item.GetHashCode();
        }
    }
}