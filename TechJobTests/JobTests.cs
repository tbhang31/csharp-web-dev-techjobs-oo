using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
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
            Employer employer1 = new Employer("ACME");
            Location location1 = new Location("Desert");
            PositionType positionType1 = new PositionType("QualityControl");
            CoreCompetency coreCompetency1 = new CoreCompetency("Persistance");
            Job testJob = new Job("Product tester",employer1,location1,positionType1,coreCompetency1);
            Assert.AreEqual("Product tester", testJob.Name);
            Assert.AreEqual(employer1, testJob.EmployerName);
            Assert.AreEqual(location1, testJob.EmployerLocation);
            Assert.AreEqual(positionType1, testJob.JobType);
            Assert.AreEqual(coreCompetency1, testJob.JobCoreCompetency);
        }
    }
}
