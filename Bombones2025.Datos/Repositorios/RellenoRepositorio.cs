using Bombones2025.Entidades;

namespace Bombones2025.Datos.Repositorios
{
    public class RellenoRepositorio
    {
        private List<Relleno> _relleno = new();
        private readonly string ruta = null!;
        public RellenoRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
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
                Relleno relleno = ContruirRelleno(registro);
                _relleno.Add(relleno);
            }
        }

        private Relleno ContruirRelleno(string registro)
        {
            var campos = registro.Split('|');
            var idRelleno = int.Parse(campos[0]);
            var nombreRelleno = campos[1];
            return new Relleno()
            {
                NombreRelleno = nombreRelleno,
                IdRelleno = idRelleno
            };
        }

        public List<Relleno> GetRellenos()
        {
            return _relleno.OrderBy(r => r.NombreRelleno).ToList();
        }

        public bool Existe(Relleno relleno)
        {
            return relleno.IdRelleno == 0 ? _relleno.Any(p => p.NombreRelleno == relleno.NombreRelleno) :
                _relleno.Any(p => p.NombreRelleno == relleno.NombreRelleno && p.IdRelleno != relleno.IdRelleno);
        }

        public void Agregar(Relleno relleno)
        {
            relleno.IdRelleno = SetearRellenoId();
            _relleno.Add(relleno);
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
                string linea = ContruisLinea(relleno);
                escritor.WriteLine(linea);
            }
            ;
        }

        private string ContruisLinea(Relleno relleno)
        {
            return $"{relleno.IdRelleno}|{relleno.NombreRelleno}";
        }

        private int SetearRellenoId()
        {
            return _relleno.Any() ? _relleno.Max(p => p.IdRelleno) + 1 : 1;
        }

        public void Editar(Relleno relleno)
        {
            var rellenoEditado = _relleno.FirstOrDefault(p => p.IdRelleno == relleno.IdRelleno);
            if (rellenoEditado is null)
            {
                return;
            }
            rellenoEditado.NombreRelleno = relleno.NombreRelleno;
            var registros = _relleno.Select(p => ContruisLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);
        }

        public void Borrar(Relleno relleno)
        {
            Relleno? rellenoBorrar = _relleno.FirstOrDefault(p => p.NombreRelleno == relleno.NombreRelleno);
            if (rellenoBorrar is null)
            {
                return;
            }
            _relleno.Remove(rellenoBorrar);
            var registros = _relleno.Select(p => ContruisLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);
        }
    }
}
