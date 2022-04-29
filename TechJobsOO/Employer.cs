using System;
namespace TechJobsOO
{
    public class Employer: JobField
    {
        public Employer(string value) : base(value)
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
            return obj is Employer employer &&
            Id == employer.Id;
        }
    }
}
