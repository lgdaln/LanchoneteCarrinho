using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanchoneteCore.Models
{
    public class Pedido
    {
   
        public int PedidoID { get; set; }

        public DateTime Data { get; set; }
      
        public String Hora { get; set; }
    
        public String Statusp { get; set; }
      
        public double ValorAtual { get; set; }
        public int AtendenteID { get; set; }

        public Atendente Atendente { get; set; }
        public int ClienteID { get; set; }

        public Cliente Cliente { get; set; }
        public List<PedidoDetalhe> ListaPedidoDetalhe { get; set; }

        public Pedido()
        {
        }

        public Pedido(int pedidoID, DateTime data, string hora, string statusp, double valorAtual, int atendenteID, Atendente atendente, int clienteID, Cliente cliente)
        {
            PedidoID = pedidoID;
            Data = data;
            Hora = hora;
            Statusp = statusp;
            ValorAtual = valorAtual;
            AtendenteID = atendenteID;
            Atendente = atendente;
            ClienteID = clienteID;
            Cliente = cliente;
        }
    }
}
