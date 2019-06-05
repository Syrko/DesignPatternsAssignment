using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;


namespace DataMapper
{
	class StudentDataMapper
	{

		//----------------------------------//
		// SQL Operation Methods			//
		//----------------------------------//
		[MethodImpl(MethodImplOptions.Synchronized)]
		public static Student findByGuId(Guid uniqueID)
		{
			try
			{
				using (SqlConnection db = new SqlConnection())
				{
					db.Open();

					string sqlStatement = "SELECT `guid`, `grade`, `studentID`, `name` FROM `students` where `guid`=?";
					SqlCommand command = new SqlCommand(sqlStatement, db);

					command.Parameters.AddWithValue("@guid", uniqueID);

					SqlDataReader dataReader = command.ExecuteReader();

					while (dataReader.Read())
					{
						Guid guid = dataReader.GetGuid(0);
						string name = dataReader.GetString(1);
						char grade = (char)(dataReader.GetValue(2));
						int studentID = dataReader.GetInt32(3);

						Student student = new Student(guid);
						student.setName(name);
						student.setGrade(grade);
						student.setStudentId(studentID);

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
		public void update(Student student)
		{
			try
			{
				using (SqlConnection db = new SqlConnection())
				{
					db.Open();

					string sqlStatement = "UPDATE `students` SET `grade`=@grade, `studentID`=@studentID, `name`=@name where `guid`=@guid";
					SqlCommand command = new SqlCommand(sqlStatement, db);

					command.Parameters.AddWithValue("@grade", student.getGrade());
					command.Parameters.AddWithValue("@studentID", student.getStudentId());
					command.Parameters.AddWithValue("@name", student.getName());
					command.Parameters.AddWithValue("@guid", student.getGuId());

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
		public void insert(Student student)
		{
			try
			{
				using (SqlConnection db = new SqlConnection())
				{
					db.Open();

					string sqlStatement = "INSERT INTO `students` (`grade`, `studentID`, `name`, `guid`) VALUES (@grade, @studentID, @name, @guid)";
					SqlCommand command = new SqlCommand(sqlStatement, db);

					command.Parameters.AddWithValue("@grade", student.getGrade());
					command.Parameters.AddWithValue("@studentID", student.getStudentId());
					command.Parameters.AddWithValue("@name", student.getName());
					command.Parameters.AddWithValue("@guid", student.getGuId());

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
		public void delete(Student student)
		{
			try
			{
				using (SqlConnection db = new SqlConnection())
				{
					db.Open();

					string sqlStatement = "DELETE FROM `students` where `guid`=@guid";
					SqlCommand command = new SqlCommand(sqlStatement, db);

					command.Parameters.AddWithValue("@guid", student.getGuId());

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
