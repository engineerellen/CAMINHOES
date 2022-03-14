using System;
using System.ComponentModel.DataAnnotations;
using ATS.Domain.Validator;


namespace ATS.Domain.Models
{
    public class Truck : BaseEntity
    {

        [Required(ErrorMessage = "Descrição do modelo é obrigatória!")]
        [ModeloValidator(ErrorMessage ="Modelo só poderá ser FH ou FM")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Ano de Fabricação é obrigatório!")]
        [AnoFabricacaoValidator(ErrorMessage ="Ano de Fabricação deverá ser o atual")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Ano do Modelo é obrigatório!")]
        [AnoModeloValidator (ErrorMessage = "O Ano do modelo deverá ser o atual ou o próximo!")]
        public int AnoModelo { get; set; }

        [Required(ErrorMessage = "Descrição do caminhão é obrigatória!")]
        public string Descricao { get; set; }

    }
}