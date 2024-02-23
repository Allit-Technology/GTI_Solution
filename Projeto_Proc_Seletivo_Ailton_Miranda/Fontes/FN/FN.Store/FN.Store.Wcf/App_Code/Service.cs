using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

public class Service : IService
{
    public ClienteData GetAllCliente()
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, Cpf, Rg, DataExpedicao, OrgaoExpedicao, DataNascimento, EstadoCivilId, UFId, SexoId FROM Cliente "))
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
    public ClienteData GetCliente(int Id)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, Cpf, Rg, DataExpedicao, OrgaoExpedicao, DataNascimento, EstadoCivilId, UFId, SexoId FROM Cliente WHERE Id = @Id"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Id", Id);
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

    public void InsertCliente(string Nome, string Cpf, string Rg, DateTime DataExpedicao, string OrgaoExpedicao, DateTime DataNascimento, int EstadoCivilId, int UFId, int SexoId)
    {
        var constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (Nome, Cpf, Rg, DataExpedicao, OrgaoExpedicao, DataNascimento, EstadoCivilId, UFId, SexoId) VALUES (@Nome, @Cpf, @Rg, @DataExpedicao, @OrgaoExpedicao, @DataNascimento, @EstadoCivilId, @UFId, @SexoId)"))
            {
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Rg", Rg);
                cmd.Parameters.AddWithValue("@DataExpedicao", DataExpedicao);
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

    public void UpdateCliente(int Id, string Nome, string Cpf, string Rg, DateTime DataExpedicao, string OrgaoExpedicao, DateTime DataNascimento, int EstadoCivilId, int UFId, int SexoId)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Cliente SET Nome = @Nome, Cpf = @Cpf, Rg = @Rg, DataExpedicao = @DataExpedicao, OrgaoExpedicao = @OrgaoExpedicao, DataNascimento = @DataNascimento," +
                " EstadoCivilId = @EstadoCivilId, UFId = @UFId, SexoId = @SexoId WHERE Id = @Id"))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Rg", Rg);
                cmd.Parameters.AddWithValue("@DataExpedicao", DataExpedicao);
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

    public void DeleteCliente(int Id)
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
    public ClienteEnderecoData GetClienteEndereco(int ClienteId)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Id, Cep, Logradouro, Numero, Complemento, Bairro, Cidade, ClienteId, UFId FROM ClientesEndereco WHERE ClienteId = @ClienteId"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ClienteId", ClienteId);
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        ClienteEnderecoData clienteEndereco = new ClienteEnderecoData();
                        sda.Fill(clienteEndereco.ClienteEnderecoTable);
                        return clienteEndereco;
                    }
                }
            }
        }
    }

    public ClienteEnderecoData GetClienteEnderecoLog(int ClienteId, string Logradouro)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT Id, Cep, Logradouro, Numero, Complemento, Bairro, Cidade, ClienteId, UFId FROM ClientesEndereco WHERE ClienteId = @ClienteId AND Logradouro = @Logradouro"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ClienteId", ClienteId);
                    cmd.Parameters.AddWithValue("@Logradouro", Logradouro);
                    sda.SelectCommand = cmd;
                    using (DataTable dt = new DataTable())
                    {
                        ClienteEnderecoData clienteEndereco = new ClienteEnderecoData();
                        sda.Fill(clienteEndereco.ClienteEnderecoTable);
                        return clienteEndereco;
                    }
                }
            }
        }
    }
    public void InsertClienteEndereco(string Cep, string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, int ClienteId, int UFId)
    {
        var constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("INSERT INTO ClientesEndereco (Cep, Logradouro, Numero, Complemento, Bairro, Cidade, ClienteId, UFId) VALUES (@Cep, @Logradouro, @Numero, @Complemento, @Bairro, @Cidade, @ClienteId, @UFId)"))
            {
                cmd.Parameters.AddWithValue("@Cep", Cep);
                cmd.Parameters.AddWithValue("@Logradouro", Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Complemento", Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Bairro);
                cmd.Parameters.AddWithValue("@Cidade", Cidade);
                cmd.Parameters.AddWithValue("@ClienteId", ClienteId);
                cmd.Parameters.AddWithValue("@UFId", UFId);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }

    public void UpdateClienteEndereco(int Id, string Cep, string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, int ClienteId, int UFId)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE ClientesEndereco SET Cep = @Cep, Logradouro = @Logradouro, Numero = @Numero, Complemento = @Complemento, Bairro = @Bairro, Cidade = @Cidade," +
                " ClienteId = @ClienteId, UFId = @UFId WHERE Id = @Id"))
            {
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Cep", Cep);
                cmd.Parameters.AddWithValue("@Logradouro", Logradouro);
                cmd.Parameters.AddWithValue("@Numero", Numero);
                cmd.Parameters.AddWithValue("@Complemento", Complemento);
                cmd.Parameters.AddWithValue("@Bairro", Bairro);
                cmd.Parameters.AddWithValue("@Cidade", Cidade);
                cmd.Parameters.AddWithValue("@ClienteId", ClienteId);
                cmd.Parameters.AddWithValue("@UFId", UFId);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
    public void DeleteClienteEndereco(int Id)
    {
        string constr = ConfigurationManager.ConnectionStrings["FNStoreConn"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand("DELETE FROM ClientesEndereco WHERE Id = @Id"))
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
