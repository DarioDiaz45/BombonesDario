using Bombones2025.Entidades;

namespace Bombones2025.Datos.Repositorios
{
    public class RepositorioFrutos
    {

        private readonly string ruta = null!;
            private List<FrutosSecos> frutosSecos = new();

           
        
        public RepositorioFrutos(string rutaArchivo)
        {
            ruta = rutaArchivo;
            CargarDesdeArchivo();
        }

        public RepositorioFrutos()
        {
        }

        public List<FrutosSecos> GetFrutoSeco()
            {
                return frutosSecos.OrderBy(f => f.NombreFruto).ToList();
            }

            private void CargarDesdeArchivo()
            {
                if (!File.Exists(ruta))
                {
                    File.Create(ruta).Close();
                    return;
                }

                var lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {
                    if (!string.IsNullOrWhiteSpace(linea))
                    {
                        var datos = linea.Split('|');
                        if (datos.Length == 2)
                        {
                            frutosSecos.Add(new FrutosSecos
                            {
                                IdFruto = int.Parse(datos[0]),
                                NombreFruto = datos[1],
                               
                            });
                        }
                        else
                        {
                            Console.WriteLine($"Error al leer la línea: {linea}");
                        }
                    }
                }
            }

            private string ConstruirLinea(FrutosSecos fruto)
            {
                return $"{fruto.IdFruto}|{fruto.NombreFruto}";
            }

            private int SetearId()
            {
                return frutosSecos.Any() ? frutosSecos.Max(f => f.IdFruto) + 1 : 1;
            }

            public void Agregar(FrutosSecos fruto)
            {
                fruto.IdFruto = SetearId();
                frutosSecos.Add(fruto);
                GuardarEnArchivo();
            }

            public void Borrar(FrutosSecos fruto)
            {
                var frutoABorrar = frutosSecos.FirstOrDefault(f => f.IdFruto == fruto.IdFruto);
                if (frutoABorrar is not null)
                {
                    frutosSecos.Remove(frutoABorrar);
                    GuardarEnArchivo();
                }
            }

            public void Editar(FrutosSecos fruto)
            {
                var frutoExistente = frutosSecos.FirstOrDefault(f => f.IdFruto == fruto.IdFruto);
                if (frutoExistente is not null)
                {
                    frutoExistente.NombreFruto = fruto.NombreFruto;

                    GuardarEnArchivo();
                }
            }

            public bool Existe(FrutosSecos fruto)
            {
                return fruto.IdFruto == 0
                    ? frutosSecos.Any(f => f.NombreFruto == fruto.NombreFruto )
                    : frutosSecos.Any(f => f.NombreFruto == fruto.NombreFruto && f.IdFruto != fruto.IdFruto);
            }

            private void GuardarEnArchivo()
            {
                try
                {
                    File.WriteAllLines(ruta, frutosSecos.Select(f => ConstruirLinea(f)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al guardar el archivo: {ex.Message}");
                }
            }
        }
    }
