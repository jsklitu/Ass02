using System;
using Xunit;

namespace Student.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ToString_returns_correct_string_status_graduated()
        {
            var student = new StudentClass{ID = 1234, EndDate = new DateTime(2001,07,19), GraduationDate = new DateTime(2001,07,19), StartDate = new DateTime(2000,07,19)};
            student.GivenName = "Mark";
            student.Surname = "Falk";

            var output = student.ToString();
            var expected = "Student ID: 1234." + Environment.NewLine + 
                    "Student name: Mark Falk." + Environment.NewLine +
                    "Status: GRADUATED.";
            Assert.Equal(expected, output);
        }
    }
}
