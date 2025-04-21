using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;


namespace Bombones2025.Servicios
{
    public class PaisServicio
    {
        private readonly PaisRepositorio _paisRepositorio = null!;
        public PaisServicio(string ruta)
        {
            _paisRepositorio = new PaisRepositorio(ruta);
        }

        public void Borrar(Pais pais)
        {
            _paisRepositorio.Borrar(pais);
        }

        public bool Existe(Pais pais)
        {
            return _paisRepositorio.Existe(pais);
        }

        public List<Pais> GetPaises()
        {
            return _paisRepositorio.GetPaises();
        }

        public void Guardar(Pais pais)
        {
            if (pais.PaisId==0)
            {
                _paisRepositorio.Agregar(pais); 
            }
            else
            {
                _paisRepositorio.Editar(pais);
            }
        }
    }
}
