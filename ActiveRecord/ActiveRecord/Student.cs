using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace ActiveRecord
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

		//----------------------------------//
		// SQL Operation Methods			//
		//----------------------------------//
		[MethodImpl(MethodImplOptions.Synchronized)]
		public static Student findGuId(Guid uniqueID)
		{
			try
			{
				using (SqlConnection db = new SqlConnection())
				{
					db.Open();

					string sqlStatement = "SELECT `guid`, `grade`, `studentID`, `name` FROM `students` where `guid`=?";
					SqlCommand command = new SqlCommand(sqlStatement, db);

					SqlDataReader dataReader = command.ExecuteReader();

					while (dataReader.Read())
					{
						Guid guid = dataReader.GetGuid(0);
						string name = dataReader.GetString(1);
						char grade = (char)(dataReader.GetValue(2));
						int studentID = dataReader.GetInt32(3);

						Student student = new Student(guid);
						student.name = name;
						student.grade = grade;
						student.studentID = studentID;

						return student;
					}
					db.Close();
				}
				return null;
			}
			catch (SqlException e)
			{
				// We don't want any types which use the Active Record
				// to be coupled to java.sql.SQLException
				// So instead, we throw a custom ActiveRecordException 
				throw new ActiveRecordException("Error occured reading Students from the data source.", e);
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void update()
		{
			try
			{
				using (SqlConnection db = new SqlConnection())
				{
					db.Open();

					string sqlStatement = "UPDATE `students` SET `grade`=@grade, `studentID`=@studentID, `name`=@name where `guid`=@guid";
					SqlCommand command = new SqlCommand(sqlStatement, db);

					command.Parameters.AddWithValue("@grade", this.grade);
					command.Parameters.AddWithValue("@studentID", this.studentID);
					command.Parameters.AddWithValue("@name", this.name);
					command.Parameters.AddWithValue("@guid", this.guid);

					command.ExecuteNonQuery();

					db.Close();
				}
			}
			catch (SqlException e)
			{
				// We don't want any types which use the Active Record
				// to be coupled to java.sql.SQLException
				// So instead, we throw a custom ActiveRecordException 
				throw new ActiveRecordException("Error occured reading Students from the data source.", e);
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void insert()
		{
			try
			{
				using (SqlConnection db = new SqlConnection())
				{
					db.Open();

					string sqlStatement = "INSERT INTO `students` (`grade`, `studentID`, `name`, `guid`) VALUES (@grade, @studentID, @name, @guid)";
					SqlCommand command = new SqlCommand(sqlStatement, db);

					command.Parameters.AddWithValue("@grade", this.grade);
					command.Parameters.AddWithValue("@studentID", this.studentID);
					command.Parameters.AddWithValue("@name", this.name);
					command.Parameters.AddWithValue("@guid", this.guid);

					command.ExecuteNonQuery();

					db.Close();
				}
			}
			catch (SqlException e)
			{
				// We don't want any types which use the Active Record
				// to be coupled to java.sql.SQLException
				// So instead, we throw a custom ActiveRecordException 
				throw new ActiveRecordException("Error occured reading Students from the data source.", e);
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void delete()
		{
			try
			{
				using (SqlConnection db = new SqlConnection())
				{
					db.Open();

					string sqlStatement = "DELETE FROM `students` where `guid`=@guid";
					SqlCommand command = new SqlCommand(sqlStatement, db);

					command.Parameters.AddWithValue("@guid", this.guid);

					command.ExecuteNonQuery();

					db.Close();
				}
			}
			catch(SqlException e)
			{
				// We don't want any types which use the Active Record
				// to be coupled to java.sql.SQLException
				// So instead, we throw a custom ActiveRecordException 
				throw new ActiveRecordException("Error occured reading Students from the data source.", e);
			}
		}
	}

	// Custom active record exception
	public class ActiveRecordException : Exception
	{
		private string msg { get; set; }
		private SqlException e { get; set; }

		public ActiveRecordException(string msg, SqlException e)
		{
			this.msg = msg;
			this.e = e;
		}
	}
}
