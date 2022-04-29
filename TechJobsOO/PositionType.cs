using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        public PositionType(string value) : base(value)
        {
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            if (Value == "")
            {
                return "Data not available";
            }
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType positionType &&
            Id == positionType.Id;
        }
    }
}
