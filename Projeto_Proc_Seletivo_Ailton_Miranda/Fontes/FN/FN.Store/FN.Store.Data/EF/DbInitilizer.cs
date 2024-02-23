using FN.Store.Domain.Entities;
using FN.Store.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace FN.Store.Data.EF
{
    public class DbInitilizer : CreateDatabaseIfNotExists<FNStoreDataContext>
    {
        protected override void Seed(FNStoreDataContext context)
        {
            //context.SaveChanges();

            context.UnidadeFederativa.AddRange(new List<UnidadeFederativa>() {
                new UnidadeFederativa(){ Uf = "SP", Descricao = "SÂO PAULO" },
                new UnidadeFederativa(){ Uf = "RJ", Descricao = "RIO DE JANEIRO" },
                new UnidadeFederativa(){ Uf = "BA", Descricao = "BAHIA" }
            });

            context.EstadoCivil.AddRange(new List<EstadoCivil>() {
                new EstadoCivil(){ Nome = "CASADO" },
                new EstadoCivil(){ Nome = "SOLTEIRO" },
                new EstadoCivil(){ Nome = "DIVORCIADO" }
            });

            context.Sexo.AddRange(new List<Sexo>() {
                new Sexo(){ Descricao = "MASCULINO" },
                new Sexo(){ Descricao = "FEMININO" }
            });

            context.Clientes.AddRange(new List<Cliente>() {
                new Cliente(){ Cpf = "73423082003", Nome = "José Maria da Silva", Rg = "4509889843",  DataExpedicao = DateTime.Parse("23/02/1987"), OrgaoExpedicao = "SSP", UFId = 4, DataNascimento = DateTime.Parse("15/02/1956"),
                SexoId = 1, EstadoCivilId = 1  },
                new Cliente(){ Cpf = "82540886086", Nome = "Maria José Souza", Rg = "23456787621", DataExpedicao = DateTime.Parse("01/01/1980"), OrgaoExpedicao = "SSP", UFId = 4, DataNascimento = DateTime.Parse("25/04/1971"),
                SexoId = 2, EstadoCivilId = 3 },
                new Cliente(){ Cpf = "87349980043", Nome="Josevaldo Pereira", Rg = "45678909821", DataExpedicao = DateTime.Parse("16/07/1999"), OrgaoExpedicao = "RRJ", UFId = 5, DataNascimento = DateTime.Parse("02/08/1948"),
                SexoId = 1, EstadoCivilId = 2 }
            });

            //context.SaveChanges();

            context.Usuarios.Add(
                new Usuario()
                {
                    Nome = "Fabiano Nalin",
                    Email = "fabiano.nalin@gmail.com",
                    Senha = "123456".Encrypt(),
                    Perfil = new Perfil() { Nome = "Admin" }
                }
                );

            context.Perfis.AddRange(new List<Perfil>() {
                new Perfil(){ Nome = "Financeiro"},new Perfil(){ Nome="Vendedor"}
            });

            context.SaveChanges();

        }
    }
}
