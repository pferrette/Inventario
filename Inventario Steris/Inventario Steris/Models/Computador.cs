namespace Inventario_Steris.Models
{
    public class Computador
    {
        public int ComputadorId { get; set; }
        public string ComputadorName { get; set; }
        public string ServiceTag { get; set; }
        public string SterisTag { get; set; }
        public string SerconTag { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string ExpressCode { get; set; }
        public DateTime DataUltimaTroca { get; set; }
        public string MotivoTroca { get; set; }

    }
}