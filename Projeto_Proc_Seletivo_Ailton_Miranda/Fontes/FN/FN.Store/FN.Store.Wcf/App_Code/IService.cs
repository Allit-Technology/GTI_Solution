using System;
using System.Data;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Collections.Generic;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    ClienteData GetAllCliente();

    [OperationContract]
    ClienteData GetCliente(int Id);

    [OperationContract]
    void InsertCliente(string Nome, string Cpf, string Rg, DateTime DataExpedicao, string OrgaoExpedicao, DateTime DataNascimento, int EstadoCivilId, int UFId, int SexoId);

    [OperationContract]
    void UpdateCliente(int Id, string Nome, string Cpf, string Rg, DateTime DataExpedicao, string OrgaoExpedicao, DateTime DataNascimento, int EstadoCivilId, int UFId, int SexoId);

    [OperationContract]
    void DeleteCliente(int Id);

    [OperationContract]
    ClienteEnderecoData GetClienteEndereco(int ClienteId);

    [OperationContract]
    ClienteEnderecoData GetClienteEnderecoLog(int ClienteId, string Logradouro);

    [OperationContract]
    void InsertClienteEndereco(string Cep, string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, int ClienteId, int UFId);

    [OperationContract]
    void UpdateClienteEndereco(int Id, string Cep, string Logradouro, string Numero, string Complemento, string Bairro, string Cidade, int ClienteId, int UFId);

    [OperationContract]
    void DeleteClienteEndereco(int Id);


}

[DataContract]
public class ClienteData
{
    public ClienteData()
    {
        this.ClienteTable = new DataTable("Cliente");
    }

    [DataMember]
    public DataTable ClienteTable { get; set; }
}


[DataContract]
public class ClienteEnderecoData
{
    public ClienteEnderecoData()
    {
        this.ClienteEnderecoTable = new DataTable("ClienteEndereco");
    }

    [DataMember]
    public DataTable ClienteEnderecoTable { get; set; }
}