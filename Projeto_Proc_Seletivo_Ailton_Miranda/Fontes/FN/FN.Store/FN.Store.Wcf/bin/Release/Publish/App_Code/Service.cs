using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Runtime.Serialization;

public class Service : IService
{
    public ClienteData Get()
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, Cpf, Rg, DataExpedicao, OrgaoExpedicao, DataNascimento, EstadoCivilId, UFId, SexoId FROM Cliente"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        ClienteData cliente = new ClienteData();
                        sda.Fill(cliente.ClienteTable);
                        return cliente;
                    }
                }
            }
        }
    }

    public void Insert(string Nome, string Cpf, string Rg, DateTime DataExpedicao, string OrgaoExpedicao, DateTime DataNascimento, int EstadoCivilId, int UFId, int SexoId)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (Nome, Cpf, Rg, DataExpedicao, OrgaoExpedicao, DataNascimento, EstadoCivilId, UFId, SexoId) VALUES (@Nome, @Cpf, @Rg, @DataExpedicao, @OrgaoExpedicao, @DataNascimento, @EstadoCivilId, @UFId, @SexoId)"))
            {
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Rg", Rg);
                cmd.Parameters.AddWithValue("@DataExpedixao", DataExpedicao);
                cmd.Parameters.AddWithValue("@OrgaoExpedicao", OrgaoExpedicao);
                cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                cmd.Parameters.AddWithValue("@EstadoCivilId", EstadoCivilId);
                cmd.Parameters.AddWithValue("@UFId", UFId);
                cmd.Parameters.AddWithValue("@SexoId", SexoId);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

    public void Update(int Id, string Nome, string Cpf, string Rg, DateTime DataExpedicao, string OrgaoExpedicao, DateTime DataNascimento, int EstadoCivilId, int UFId, int SexoId)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Customers SET Nome = @Nome, Cpf = @Cpf, Rg = @Rg, DataExpedicao = @DataExpedicao, OrgaoExpedicao = @OrgaoExpedicao, DataNascimento = @DataNascimento," +
                " EstadoCivilId = @EstadoCivilId, UFId = @UFId, SexoId = @SexoId WHERE Id = @Id"))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Rg", Rg);
                cmd.Parameters.AddWithValue("@DataExpedixao", DataExpedicao);
                cmd.Parameters.AddWithValue("@OrgaoExpedicao", OrgaoExpedicao);
                cmd.Parameters.AddWithValue("@DataNascimento", DataNascimento);
                cmd.Parameters.AddWithValue("@EstadoCivilId", EstadoCivilId);
                cmd.Parameters.AddWithValue("@UFId", UFId);
                cmd.Parameters.AddWithValue("@SexoId", SexoId);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

    public void Delete(int Id)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE Id = @Id"))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
