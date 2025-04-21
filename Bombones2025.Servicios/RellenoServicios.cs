

using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;

namespace Bombones2025.Servicios
{
    public class RellenoServicios
    {
        private readonly RellenoRepositorio _rellenoRepositorio = null!;
        public RellenoServicios(string ruta)
        {
            _rellenoRepositorio=new RellenoRepositorio(ruta);

        }

        public void Borrar(Relleno relleno)
        {
            _rellenoRepositorio.Borrar(relleno);
        }

        public bool Existe(Relleno relleno)
        {
            return _rellenoRepositorio.Existe(relleno);
        }

        public List<Relleno> GetRellenos()
        {
            return _rellenoRepositorio.GetRellenos();
        }

        public void Guardar(Relleno relleno)
        {
            if (relleno.IdRelleno == 0)
            {
                _rellenoRepositorio.Agregar(relleno);
            }
            else
            {
                _rellenoRepositorio.Editar(relleno);
            }
        }
    }
}
