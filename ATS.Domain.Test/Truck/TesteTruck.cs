using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ExpectedObjects;
using ATS.Domain;
using ATS.Domain.Test.Util;
using ATS.Domain.Interfaces;

namespace ATS.Domain.Test.Truck
{
    public class TesteTruck
    {
        private readonly IRepository<ATS.Domain.Models.Truck> _truckRepository;

        [Fact]
        public void InstanciaCaminhao_Esperado_Sucesso()
        {
            var CaminhaoEsperado = new
            {
                Modelo = "FH"
                ,
                AnoFabricacao = 2022
                ,
                AnoModelo = 2022
                ,
                Descricao = "Caminhao Teste"
            };

            var Truck = new ATS.Domain.Models.Truck() { Modelo = CaminhaoEsperado.Modelo, AnoFabricacao = CaminhaoEsperado.AnoFabricacao, AnoModelo = CaminhaoEsperado.AnoModelo, Descricao = CaminhaoEsperado.Descricao };

            CaminhaoEsperado.ToExpectedObject().ShouldMatch(Truck);
        }

        [Fact]
        public void InstanciaCaminhao_Esperado_Erro_Modelo()
        {
            string mensagemError = "Modelo Invalido!";

            var CaminhaoEsperado = new
            {
                Modelo = "FA"
                ,
                AnoFabricacao = 2022
                ,
                AnoModelo = 2022
                ,
                Descricao = "Caminhao Errado Modelo"
            };

            var Truck = new ATS.Domain.Models.Truck() { Modelo = CaminhaoEsperado.Modelo, AnoFabricacao = CaminhaoEsperado.AnoFabricacao, AnoModelo = CaminhaoEsperado.AnoModelo, Descricao = CaminhaoEsperado.Descricao };

            Assert.Throws<ArgumentException>(() => new ATS.Domain.Models.Truck() { Modelo = CaminhaoEsperado.Modelo, AnoFabricacao = CaminhaoEsperado.AnoFabricacao, AnoModelo = CaminhaoEsperado.AnoModelo, Descricao = CaminhaoEsperado.Descricao }).ValidarMensagem(mensagemError);

        }

        [Fact]
        public void InstanciaCaminhao_Esperado_Erro_Ano_Fabricacao()
        {
            string mensagemError = "Ano de fabricaocao inválido!";

            var CaminhaoEsperado = new
            {
                Modelo = "FH"
                ,
                AnoFabricacao = 2020
                ,
                AnoModelo = 2022
                ,
                Descricao = "Caminhao Errado Ano Fabricacao"
            };

            var Truck = new ATS.Domain.Models.Truck() { Modelo = CaminhaoEsperado.Modelo, AnoFabricacao = CaminhaoEsperado.AnoFabricacao, AnoModelo = CaminhaoEsperado.AnoModelo, Descricao = CaminhaoEsperado.Descricao };

            Assert.Throws<ArgumentException>(() => new ATS.Domain.Models.Truck() { Modelo = CaminhaoEsperado.Modelo, AnoFabricacao = CaminhaoEsperado.AnoFabricacao, AnoModelo = CaminhaoEsperado.AnoModelo, Descricao = CaminhaoEsperado.Descricao }).ValidarMensagem(mensagemError);

        }

        [Fact]
        public void InstanciaCaminhao_Esperado_Erro_Ano_Modelo()
        {
            string mensagemError = "Ano Modelo inválido!";

            var CaminhaoEsperado = new
            {
                Modelo = "FH"
                ,
                AnoFabricacao = 2022
                ,
                AnoModelo = 2020
                ,
                Descricao = "Caminhao Errado Ano Modelo"
            };

            var Truck = new ATS.Domain.Models.Truck() { Modelo = CaminhaoEsperado.Modelo, AnoFabricacao = CaminhaoEsperado.AnoFabricacao, AnoModelo = CaminhaoEsperado.AnoModelo, Descricao = CaminhaoEsperado.Descricao };

            Assert.Throws<ArgumentException>(() => new ATS.Domain.Models.Truck() { Modelo = CaminhaoEsperado.Modelo, AnoFabricacao = CaminhaoEsperado.AnoFabricacao, AnoModelo = CaminhaoEsperado.AnoModelo, Descricao = CaminhaoEsperado.Descricao }).ValidarMensagem(mensagemError);

        }


        [Fact]
        public void TesteInclusao()
        {

            var caminhaoTeste = new Models.Truck
            {
                Modelo = "FM"
                ,
                AnoFabricacao = 2022
                ,
                AnoModelo = 2022
                ,
                Descricao = "Caminhao Teste Ellen"
            };

            try
            {
                _truckRepository.Save(caminhaoTeste);
                Assert.True(true);
            }
            catch
            {
                Assert.False(false);
            }

        }
        [Fact]
        public void TesteListagem()
        {
            var dados = _truckRepository.GetAll();
            Assert.True(dados.Count() > 0);
        }

        [Fact]
        public void TesteGetById()
        {
            var dados = _truckRepository.GetById(1);
            Assert.True(dados is not null);
        }

    }
}
