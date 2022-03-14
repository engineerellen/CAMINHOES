using System.ComponentModel.DataAnnotations;

namespace ATS.Web.DTOs
{
    public class TruckDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email{ get; set; }
    }
}