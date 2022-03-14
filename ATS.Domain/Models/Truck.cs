using System;
using System.ComponentModel.DataAnnotations;
using ATS.Domain.Validator;


namespace ATS.Domain.Models
{
    public class Truck : BaseEntity
    {

        [Required(ErrorMessage = "Descri��o do modelo � obrigat�ria!")]
        [ModeloValidator(ErrorMessage ="Modelo s� poder� ser FH ou FM")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Ano de Fabrica��o � obrigat�rio!")]
        [AnoFabricacaoValidator(ErrorMessage ="Ano de Fabrica��o dever� ser o atual")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Ano do Modelo � obrigat�rio!")]
        [AnoModeloValidator (ErrorMessage = "O Ano do modelo dever� ser o atual ou o pr�ximo!")]
        public int AnoModelo { get; set; }

        [Required(ErrorMessage = "Descri��o do caminh�o � obrigat�ria!")]
        public string Descricao { get; set; }

    }
}