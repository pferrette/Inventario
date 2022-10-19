namespace Inventario_Steris.Models
{
    public class Celular
    {
        public int CelularId { get; set; }
        public string Marca { get; set; }
        public float IMEI { get; set; }
        public string Telefone { get; set; }
        public float IMEIold { get; set; }
        public string EmailConfig { get; set; }
        public string PwdConfig { get; set; }
        public string PwdPIN { get; set; }
        public DateTime DataTroca { get; set; }
        public string MotivoTroca { get; set; }
        public string Descricao { get; set; }
    }
}
