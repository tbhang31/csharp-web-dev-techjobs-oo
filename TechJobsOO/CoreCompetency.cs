using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency(string value) : base(value)
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
            return obj is CoreCompetency coreCompetency &&
            Id == coreCompetency.Id;
        }
    }
}
