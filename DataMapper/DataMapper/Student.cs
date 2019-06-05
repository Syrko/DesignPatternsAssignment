using System;

namespace DataMapper
{
	public class Student
	{
		private readonly Guid guid;
		private int studentID;
		private string name;
		private char grade;

		//----------------------------------//
		// Constructors						//
		//----------------------------------//
		public Student()
		{
			this.guid = Guid.NewGuid();
		}

		public Student(Guid guid)
		{
			this.guid = guid;
		}
		//----------------------------------//
		// Getters and Setters				//
		//----------------------------------//
		public int getStudentId() { return studentID; }

		public void setStudentId(int studentID) { this.studentID = studentID; }

		public String getName() { return name; }

		public void setName(String name) { this.name = name; }

		public char getGrade() { return grade; }

		public void setGrade(char grade) { this.grade = grade; }

		public Guid getGuId() { return guid; }

		//----------------------------------//
		// Domain Logic Methods				//
		//----------------------------------//
		public bool passes()
		{
			return grade != 'F';
		}

		public bool onProbation()
		{
			// A grade of D or F
			// results in being put on probation
			return grade < 'D';
		}
	}
}
