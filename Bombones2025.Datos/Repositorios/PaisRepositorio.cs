using Bombones2025.Entidades;
using System.Runtime.InteropServices;

namespace Bombones2025.Datos.Repositorios
{
    public class PaisRepositorio
    {
        private List<Pais> paises = new();
        private readonly string ruta = null!;
        public PaisRepositorio(string rutaArchivo)
        {
            ruta = rutaArchivo;
            LeerDatos();
        }

        public PaisRepositorio()
        {
        }

        public List<Pais> GetPaises()
        {
            return paises.OrderBy(p => p.NombrePais).ToList();
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
                Pais pais = ContruirPais(registro);
                paises.Add(pais);
            }
        }
        public bool Existe(Pais pais)
        {
            return pais.PaisId == 0 ? paises.Any(p => p.NombrePais == pais.NombrePais) :
                paises.Any(p => p.NombrePais == pais.NombrePais && p.PaisId != pais.PaisId);
        }

        private Pais ContruirPais(string registro)
        {
            var campos = registro.Split('|');
            var paisId = int.Parse(campos[0]);
            var nombrePais = campos[1];
            return new Pais()
            {
                NombrePais = nombrePais,
                PaisId = paisId
            };
        }
        private int SetearPaisId()
        {
            return paises.Max(p => p.PaisId) + 1;
        }

        public void Agregar(Pais pais)
        {
            pais.PaisId = SetearPaisId();
            paises.Add(pais);
            if (File.Exists(ruta))
            {
                var registros=File.ReadAllText(ruta);
                if (!string.IsNullOrEmpty(registros) && !registros.EndsWith(Environment.NewLine))
                {
                    File.WriteAllText(ruta, Environment.NewLine);
                }
            }
            using (var escritor = new StreamWriter(ruta, true))
            {
                string linea = ContruirLinea(pais);
                escritor.WriteLine(linea);
            }
        }

        private string ContruirLinea(Pais pais)
        {
            return $"{pais.PaisId}|{pais.NombrePais}";
        }

        public void Borrar(Pais pais)
        {
            Pais? paisBorrar = paises.FirstOrDefault(p => p.NombrePais == pais.NombrePais);
            if(paisBorrar is null)
            {
                return;
            }
            paises.Remove(paisBorrar);
            var registros = paises.Select(p => ContruirLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);
        }

        public void Editar(Pais pais)
        {
            var paisEditado = paises.FirstOrDefault(p => p.PaisId == pais.PaisId);
            if(paisEditado is null)
            {
                return;
            }
            paisEditado.NombrePais = pais.NombrePais;
            var registros = paises.Select(p => ContruirLinea(p)).ToArray();
            File.WriteAllLines(ruta, registros);
        }
    }
}
