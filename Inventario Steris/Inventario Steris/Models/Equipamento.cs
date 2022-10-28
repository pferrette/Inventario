namespace Inventario_Steris.Models
{
    public class Equipamento
    {
        public int EquipamentoId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string SterisTag { get; set; }
        public string SerconTag { get; set; }
        public string Local { get; set; }
        public string Situação { get; set; }
        public string Detalhes { get; set; }
        public string Tipo { get; set; }
        public int QtdUsuarios { get; set; }
        public List<Computador> Computadores { get; set; }
        public List<Celular> Celulares { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

    }
}