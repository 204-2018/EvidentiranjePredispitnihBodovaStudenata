using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerTests
{
    public class StudentBusinessTests
    {
        private Mock<IStudentRepository> mockStudentRepository = new Mock<IStudentRepository>();



        [TestMethod]
        public void IsStudentInserted()
        {
            // Arrange
            mockStudentRepository.Setup(x => x.InsertStudent(student)).Returns(1);
            this.studentBusiness = new StudentBusiness(mockStudentRepository.Object);

            // Act
            var result = studentBusiness.InsertStudent(student);

            // Assert
            Assert.IsTrue(result);
        }


    }
}
