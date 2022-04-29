using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {

            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType positionType = new PositionType("QualityControl");
            CoreCompetency coreCompetency = new CoreCompetency("Persistance");
            public Job job1;
            public Job job2;
            public Job job3;
            public Job job4;

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Job job3 = new Job("Product tester",employer,location,positionType,coreCompetency);
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual(employer, job3.EmployerName);
            Assert.AreEqual(location, job3.EmployerLocation);
            Assert.AreEqual(positionType, job3.JobType);
            Assert.AreEqual(coreCompetency, job3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job3 = new Job("Product tester", employer, location, positionType, coreCompetency);
            Job job4 = new Job("Product tester", employer, location, positionType, coreCompetency);
            Assert.IsFalse(job3.Equals(job4));
        }
    }
}
