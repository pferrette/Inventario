namespace Inventario_Steris.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public int CentroDeCusto { get; set; }
        public string Supervisor { get; set; }
        public string Email { get; set; }
        public bool SignatureEquip { get; set; }
        public bool SignatureDados { get; set; }

        public List<Celular> Celulares { get; set; }
        public List<Computador> Computadores { get; set; }


    }
}
