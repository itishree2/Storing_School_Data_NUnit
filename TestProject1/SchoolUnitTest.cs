using Moq;
using SchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture]
    public class SchoolUnitTest
    {
        [Test]
        public void AddStudent()
        {
            var schoolManagement = new SchoolManagement();
            var student = new Student { StudentId = 1, StudentName = "Itishree", Class = "Seven" };
            schoolManagement.AddStudent(student);
            Assert.Contains(student, schoolManagement.Students);
        }

        [Test]
        public void AddSubject()
        {
            var schoolManagement = new SchoolManagement();
            var subject = new Subject { SubjectId = 1, SubjectName = "Math" };

            schoolManagement.AddSubject(subject);
            Assert.Contains(subject, schoolManagement.Subjects);

        }
        [Test]
        public void AddTeacher()
        {
            var schoolManagement = new SchoolManagement();
            var teacher = new Teacher { TeacherId = 1, TeacherName = "Mr.Bhupesh" };
            schoolManagement.AddTeacher(teacher);
            Assert.Contains(teacher, schoolManagement.Teachers);
        }
        [Test]
        public void StudentMockTest()
        {
            var schoolManagement = new SchoolManagement();
            var studentMock = new Mock<Student>();
            studentMock.SetupGet(s=>s.StudentId).Returns(1);
            studentMock.SetupGet(s => s.StudentName).Returns("Itishree");
            studentMock.SetupGet(s => s.Class).Returns("Seven");
            
           schoolManagement.AddStudent(studentMock.Object);
            Assert.Contains(studentMock.Object, schoolManagement.Students);
        }
        [Test]
        public void SubjectMockTest()
        {
            var schoolManagement = new SchoolManagement();
            var subjectMock = new Mock<Subject>();
            subjectMock.SetupGet(s=>s.SubjectId).Returns(1);
            subjectMock.SetupGet(s => s.SubjectName).Returns("Math");

            schoolManagement.AddSubject(subjectMock.Object);
            Assert.Contains(subjectMock.Object, schoolManagement.Subjects);
        }
        [Test]
        public void TeacherMockTest() 
        {
            var schoolManagement = new SchoolManagement();
            var teacherMock=new Mock<Teacher>();
            teacherMock.SetupGet(s => s.TeacherId).Returns(1);
            teacherMock.SetupGet(s => s.TeacherName).Returns("Mr.Bhupesh");
           
            schoolManagement.AddTeacher(teacherMock.Object);
            Assert.Contains(teacherMock.Object, schoolManagement.Teachers);
        }
    }
}
