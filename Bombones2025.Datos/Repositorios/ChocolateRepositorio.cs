

using Bombones2025.Entidades;

namespace Bombones2025.Datos.Repositorios
{
    public class ChocolateRepositorio
    {
        private List<TipoChocolate> _chocolate = new();
        private readonly string ruta = null!;
        public ChocolateRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }
        public ChocolateRepositorio()
        {

        }

        private void LeerDatos()
        {
            if (!File.Exists(ruta))
            {
                return;
            }
            var registros = File.ReadAllLines(ruta);
            foreach (var registro in registros)
            {
                TipoChocolate chocolate = ContruirChocolate(registro);
                _chocolate.Add(chocolate);
            }
        }

        private TipoChocolate ContruirChocolate(string registro)
        {
            var campos = registro.Split('|');
            var idChocolate = int.Parse(campos[0]);
            var nombreChocolate = campos[1];
            return new TipoChocolate()
            {
                NombreChocolate = nombreChocolate,
                IdChocolate = idChocolate
            };
        }

        public void Agregar(TipoChocolate chocolate)
        {
            chocolate.IdChocolate = SetearId();
            _chocolate.Add(chocolate);
            if (File.Exists(ruta))
            {
                var registros = File.ReadAllText(ruta);
                if (!string.IsNullOrEmpty(registros) && !registros.EndsWith(Environment.NewLine))
                {
                    File.WriteAllText(ruta, Environment.NewLine);
                }
            }
            using (var escritor = new StreamWriter(ruta, true))
            {
                string linea = ConstruirLinea(chocolate);
                escritor.WriteLine(linea);
            }
            ;

        }

       

        private string ConstruirLinea(TipoChocolate chocolate)
        {
            return $"{chocolate.IdChocolate}|{chocolate.NombreChocolate}";
        }

        private int SetearId()
        {
            return _chocolate.Any() ? _chocolate.Max(f => f.IdChocolate) + 1 : 1;
        }

        public void Editar(TipoChocolate chocolate)
        {
            var chocolateEditado = _chocolate.FirstOrDefault(p => p.IdChocolate == chocolate.IdChocolate);
            if (chocolateEditado is null)
            {
                return;
            }
            chocolateEditado.NombreChocolate = chocolate.NombreChocolate;
            var registros = _chocolate.Select(p => ContruisLinea(p)).ToArray();
            File.WriteAllLines(ruta,registros);
        }

        private string ContruisLinea(TipoChocolate chocolate)
        {
            return $"{chocolate.IdChocolate}|{chocolate.NombreChocolate}";
        }

        public void Borrar(TipoChocolate chocolate)
        {
            TipoChocolate? chocolateBorrar = _chocolate.FirstOrDefault(p => p.NombreChocolate == chocolate.NombreChocolate);
            if (chocolateBorrar is null)
            {
                return;
            }
            _chocolate.Remove(chocolateBorrar);
            var registros = _chocolate.Select(p => ContruisLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);
        }

        public bool Existe(TipoChocolate chocolate)
        {
            return chocolate.IdChocolate == 0 ? _chocolate.Any(p => p.NombreChocolate == chocolate.NombreChocolate) :
               _chocolate.Any(p => p.NombreChocolate == chocolate.NombreChocolate && p.IdChocolate != chocolate.IdChocolate);
        }

        public List<TipoChocolate> GetChocolate()
        {
            return _chocolate.OrderBy(p => p.NombreChocolate).ToList();
        }
    }
    
}
