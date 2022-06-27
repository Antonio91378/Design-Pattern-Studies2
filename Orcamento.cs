using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; set; }
        public Orcamento()
        {
            Itens = new List<Item>();
        }
        public void AdicionaItem(Item item)
        {
            this.Valor += item.Valor;
            Itens.Add(item);
        }
    }
}
