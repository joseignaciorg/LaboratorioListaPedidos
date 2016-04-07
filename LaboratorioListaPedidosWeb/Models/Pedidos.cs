using System;
using System.ComponentModel;

namespace LaboratorioListaPedidosWeb.Models
{
    //Clase para la informacion de cada pedido
    public class Pedidos
    {
        public String Cliente { get; set; }
        public String Pedido { get; set; }
        public int Unidades { get; set; }
        public double Total { get; set; }
        [DisplayName("Producto")]
        public int idProducto { get; set; }
    }
}