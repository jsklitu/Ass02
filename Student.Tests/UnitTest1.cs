using System;
using Xunit;
using System.Globalization;

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

        [Fact]
        public void Compare_StudentClass_and_ImmutableStudent_return_true(){
            var student1 = new ImmutableStudent{ID = 1234, GivenName = "Mark", Surname = "Falk", EndDate = new DateTime(2001,07,19), GraduationDate = new DateTime(2001,07,19), StartDate = new DateTime(2000,07,19)};
            var student2 = new ImmutableStudent{ID = 1234, GivenName = "Mark", Surname = "Falk", EndDate = new DateTime(2001,07,19), GraduationDate = new DateTime(2001,07,19), StartDate = new DateTime(2000,07,19)};
        
            Assert.Equal(student1, student2);
        }

        [Fact]
        public void Compare_StudentClass_and_ImmutableStudent_return_false(){
            var student1 = new ImmutableStudent{ID = 1234, GivenName = "Mark", Surname = "Falk", EndDate = new DateTime(2001,07,19), GraduationDate = new DateTime(2001,07,19), StartDate = new DateTime(2000,07,19)};
            var student2 = new ImmutableStudent{ID = 1234, GivenName = "Mark", Surname = "Kalk", EndDate = new DateTime(2001,07,19), GraduationDate = new DateTime(2001,07,19), StartDate = new DateTime(2000,07,19)};
        
            Assert.NotEqual(student1, student2);
        }

        [Fact]
        public void compare_tostring(){
            var student1 = new ImmutableStudent{ID = 1234, GivenName = "Mark", Surname = "Falk", EndDate = new DateTime(2001,07,19), GraduationDate = new DateTime(2001,07,19), StartDate = new DateTime(2000,07,19)};
            var actualstring = student1.ToString();
            
            var expected = "Student ID: 1234." + Environment.NewLine + 
                    "Student name: Mark Falk." + Environment.NewLine +
                    "Status: GRADUATED." + Environment.NewLine +
                    "Start date: 19 07 2000.";
       
             Assert.Equal(expected, actualstring);

        }
    }
}
