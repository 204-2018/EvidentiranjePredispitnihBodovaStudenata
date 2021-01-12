using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayerTests
{
    public class FormStudents1Tests
    {

        [TestMethod]
        public void IsDataRefreshed()
        {
            // Arrange
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student
            {
                Name = "Mladen Janjic",
                IndexNumber = "150/2004",
                AverageMark = 9.5m
            });
            listOfStudents.Add(new Student
            {
                Name = "Nikola Ristanovic",
                IndexNumber = "500/2017",
                AverageMark = 7.5m
            });
            listOfStudents.Add(new Student
            {
                Name = "Luka Radovanovic",
                IndexNumber = "800/2016",
                AverageMark = 7.5m
            });

            var mockStudentBusiness = new Mock<IStudentBusiness>();
            mockStudentBusiness.Setup(s => s.GetAllStudents()).Returns(listOfStudents);

            var form1 = new Form1(mockStudentBusiness.Object);

            // Act
            PrivateObject obj = new PrivateObject(form1);
            obj.Invoke("RefreshData");

            ListBox listBoxStudents = (ListBox)obj.GetFieldOrProperty("listBoxStudents");

            // Assert
            Assert.AreEqual(3, listBoxStudents.Items.Count);
        }




    }
}
