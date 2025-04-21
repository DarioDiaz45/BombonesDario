using Bombones2025.Datos.Repositorios;
using Bombones2025.Entidades;

namespace Bombones2025.Servicios
{
    public class FrutosServicios
    {
        private readonly RepositorioFrutos _frutoRepositorio = null!;

        public FrutosServicios(string ruta)
        {
            _frutoRepositorio = new RepositorioFrutos(ruta);
        }

        public void AgregarFrutoSeco(FrutosSecos fruto)
        {
            _frutoRepositorio.Agregar(fruto);
        }

        public void Borrar(FrutosSecos fruto)
        {
            _frutoRepositorio.Borrar(fruto);
        }

        public bool Existe(FrutosSecos fruto)
        {
            return _frutoRepositorio.Existe(fruto);
        }

        public void Guardar(FrutosSecos fruto)
        {
            if (fruto.IdFruto == 0)
            {
                _frutoRepositorio.Agregar(fruto);
            }
            else
            {
                _frutoRepositorio.Editar(fruto);
            }
        }

        public List<FrutosSecos> ListarFrutosSecos()
        {
            return _frutoRepositorio.GetFrutoSeco();
        }
    }
}
