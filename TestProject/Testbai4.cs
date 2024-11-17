using BaiTapOnl;
using NUnit.Framework;
using System.Linq;

namespace TestProject
{
    [TestFixture]
    public class TestBai4
    {
        private Bai4 _bai4;

        [SetUp]
        public void Setup()
        {
            _bai4 = new Bai4();  
        }

        [Test]
        public void TestAddEmployee()
        {
            var employee = new Employee (  1, "John", "Doe", "john.doe@example.com" );

            _bai4.Add(employee);
            var allEmployees = _bai4.GetAllEmployees();

            Assert.AreEqual(1, allEmployees.Count);
            Assert.AreEqual(employee.Id, allEmployees[0].Id);
            Assert.AreEqual(employee.FirstName, allEmployees[0].FirstName);
            Assert.AreEqual(employee.LastName, allEmployees[0].LastName);
            Assert.AreEqual(employee.Email, allEmployees[0].Email);
        }

        [Test]
        public void TestUpdateEmployee()
        {
            var employee = new Employee(1, "John", "Doe", "john.doe@example.com");
            _bai4.Add(employee);

            var updatedEmployee = new Employee(1, "John", "Doe", "john.doe@example.com");

            _bai4.UpdateEmployee(1, updatedEmployee);

           
            var allEmployees = _bai4.GetAllEmployees();

            Assert.AreEqual(1, allEmployees.Count);
            Assert.AreEqual(updatedEmployee.Id, allEmployees[0].Id);
            Assert.AreEqual(updatedEmployee.FirstName, allEmployees[0].FirstName);
            Assert.AreEqual(updatedEmployee.LastName, allEmployees[0].LastName);
            Assert.AreEqual(updatedEmployee.Email, allEmployees[0].Email);
        }

        [Test]
        public void TestDeleteEmployee()
        {
            var employee1 = new Employee(1, "John", "Doe", "john.doe@example.com");
            _bai4.Add(employee1);

            _bai4.DeleteEmployee(1);

            var allEmployees = _bai4.GetAllEmployees();

            Assert.AreEqual(0, allEmployees.Count);
        }
    }
}
