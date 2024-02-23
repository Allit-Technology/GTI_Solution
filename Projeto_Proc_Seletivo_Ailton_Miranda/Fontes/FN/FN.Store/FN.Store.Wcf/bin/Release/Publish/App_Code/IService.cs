using System;
using System.Data;
using System.ServiceModel;
using System.Runtime.Serialization;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    ClienteData Get();

    [OperationContract]
    void Insert(string Nome, string Cpf, string Rg, DateTime DataExpedicao, string OrgaoExpedicao, DateTime DataNascimento, int EstadoCivilId, int UFId, int SexoId);

    [OperationContract]
    void Update(int Id, string Nome, string Cpf, string Rg, DateTime DataExpedicao, string OrgaoExpedicao, DateTime DataNascimento, int EstadoCivilId, int UFId, int SexoId);

    [OperationContract]
    void Delete(int Id);
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
