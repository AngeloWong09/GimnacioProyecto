using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Proyecto1.Modelo;

namespace Proyecto1.Controlador
{
    internal class controladorPagos
    {
        private List<pagoModelo> pagos;

        public controladorPagos()
        {
            pagos = new List<pagoModelo>();
            CargarPagosDesdeCSV("Assets/Pagos.csv");
        }

        private void CargarPagosDesdeCSV(string rutaArchivo) //agarramos la info de pagos csv
        {
            if (File.Exists(rutaArchivo))
            {
                foreach (var linea in File.ReadAllLines(rutaArchivo))
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    var valores = linea.Split(';');
                    if (valores.Length >= 3)
                    {
                        int usuarioId = int.TryParse(valores[0].Trim(), out int tempId) ? tempId : 0;
                        string mesPago = valores[1].Trim();
                        decimal monto = decimal.TryParse(valores[2].Trim(), out decimal tempMonto) ? tempMonto : 0;

                        pagos.Add(new pagoModelo(usuarioId, mesPago, monto));
                    }
                }
            }
        }

        public List<pagoModelo> ObtenerPagosPorUsuario(int usuarioId)
        {
            return pagos.Where(pago => pago.UsuarioId == usuarioId).ToList();
        }
    }
}