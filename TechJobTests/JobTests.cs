using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {

        public Employer employer = new Employer("ACME");
        public Location location = new Location("Desert");
        public PositionType positionType = new PositionType("Quality Control");
        public CoreCompetency coreCompetency = new CoreCompetency("Persistance");
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

            job3 = new Job("Product tester",employer,location,positionType,coreCompetency);
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual(employer, job3.EmployerName);
            Assert.AreEqual(location, job3.EmployerLocation);
            Assert.AreEqual(positionType, job3.JobType);
            Assert.AreEqual(coreCompetency, job3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            job3 = new Job("Product tester", employer, location, positionType, coreCompetency);
            job4 = new Job("Product tester", employer, location, positionType, coreCompetency);
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]
        public void TestJobToStringOutput()
        {
            job4 = new Job();
            Assert.AreEqual(job4.ToString(), "OOPS! This Job doesn't exist!");
            job3 = new Job("Product tester", employer, location, positionType, coreCompetency);
            Assert.AreEqual(job3.ToString(), $"ID: {job3.Id}\nName: {job3.Name}\nEmployer: {job3.EmployerName} \nLocation: {job3.EmployerLocation} \nPosition Type: {job3.JobType} \nCore Competency: {job3.JobCoreCompetency}\n");
        }

    }
}
