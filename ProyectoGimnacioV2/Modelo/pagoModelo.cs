using Proyecto1.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto1.Modelo
{
    internal class pagoModelo
    {//valores
        public int UsuarioId { get; set; }
        public string MesPago{ get; set; }
        public decimal Monto { get; set; }

        public pagoModelo(int usuarioId, string mesPago, decimal monto)
        { //constructor
            UsuarioId = usuarioId;
            MesPago = mesPago;
            Monto = monto;
        }
            }
        }