using System;
using System.Text;

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            double pointsEarned = Gpa * NumberOfCredits;
            pointsEarned += grade * courseCredits;
            NumberOfCredits += courseCredits;
            Gpa = pointsEarned / NumberOfCredits;
        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            return "grade level tbd";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} (ID: {StudentId})\r\n");
            sb.Append($"\tCredits: {NumberOfCredits}\r\n");
            sb.Append($"\tGPA: {Gpa}\r\n");
            return sb.ToString();
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() == this.GetType())
            {
                return obj is Student s && s.StudentId == StudentId;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudentId);
        }
    }
}
