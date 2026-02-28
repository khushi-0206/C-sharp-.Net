using Microsoft.Data.SqlClient;

public class StudentDAL
{
    private readonly string connectionString =
        "Server=.\\sqlexpress;Database=CrudDemoDB;Trusted_Connection=True;TrustServerCertificate=True";

    public void AddStudent(Student s)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            "INSERT INTO Students (Name,Age,Course) VALUES (@name,@age,@course)", con);

        cmd.Parameters.AddWithValue("@name", s.Name);
        cmd.Parameters.AddWithValue("@age", s.Age);
        cmd.Parameters.AddWithValue("@course", s.Course);

        con.Open();
        cmd.ExecuteNonQuery();

        Console.WriteLine("Student added successfully");
    }

    public void GetAllStudents()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);

        con.Open();
        using SqlDataReader dr = cmd.ExecuteReader();

        Console.WriteLine("\nID  Name  Age  Course");
        while (dr.Read())
        {
            Console.WriteLine($"{dr[0]}  {dr[1]}  {dr[2]}  {dr[3]}");
        }
    }

    public void UpdateStudent(Student s)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            "UPDATE Students SET Name=@name,Age=@age,Course=@course WHERE Id=@id", con);

        cmd.Parameters.AddWithValue("@id", s.Id);
        cmd.Parameters.AddWithValue("@name", s.Name);
        cmd.Parameters.AddWithValue("@age", s.Age);
        cmd.Parameters.AddWithValue("@course", s.Course);

        con.Open();
        cmd.ExecuteNonQuery();

        Console.WriteLine("Student updated successfully");
    }

    public void DeleteStudent(int id)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        using SqlCommand cmd = new SqlCommand(
            "DELETE FROM Students WHERE Id=@id", con);

        cmd.Parameters.AddWithValue("@id", id);

        con.Open();
        int rowAffected = cmd.ExecuteNonQuery();
        if (rowAffected == 0)
        {
            Console.WriteLine("Student not found");
        }
        else
        {
            Console.WriteLine("Student deleted successfully");
        }
    }
}