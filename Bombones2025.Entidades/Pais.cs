namespace Bombones2025.Entidades
{
    public class Pais
    {
        public string NombrePais { get; set; } = null!;
        public int PaisId { get; set; }
        public override string ToString()
        {
            return $"{NombrePais}";
        }
    }
}
