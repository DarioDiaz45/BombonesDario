

using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;

namespace Bombones2025.Servicios
{
    public class ChocolateServicios
    {
        private readonly ChocolateRepositorio _chocolateRepositorio = null!;
        public ChocolateServicios(string ruta)
        {
            _chocolateRepositorio = new ChocolateRepositorio(ruta);
        }

        public void Agregar(TipoChocolate chocolate)
        {
            if (chocolate.IdChocolate == 0)
            {
                _chocolateRepositorio.Agregar(chocolate);
            }
            else
            {
                _chocolateRepositorio.Editar(chocolate);
            }
        }

        public void Borrar(TipoChocolate chocolate)
        {
            _chocolateRepositorio.Borrar(chocolate);
        }

        public bool Existe(TipoChocolate chocolate)
        {
            return _chocolateRepositorio.Existe(chocolate);
        }

        public List<TipoChocolate> GetChocolate()
        {
            return _chocolateRepositorio.GetChocolate();
        }

        public void Guardar(TipoChocolate chocolate)
        {
            if (chocolate.IdChocolate == 0)
            {
                _chocolateRepositorio.Agregar(chocolate);
            }
            else
            {
                _chocolateRepositorio.Editar(chocolate);
            }
        }
    }
}
