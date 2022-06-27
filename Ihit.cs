namespace CursoDesignPatterns
{
    public class Ihit : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return IdentificadorDeItensIguais(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count();
        }
        public bool IdentificadorDeItensIguais(Orcamento orcamento)
        {
            var lista = new List<string>();
            foreach (var item in orcamento.Itens)
            {
                lista.Add(item.Nome);
            }
            bool condicao = false;
            for (var i = 0; i < lista.Count - 1; i++)
            {
                if (lista.Count() >= 2)
                {
                    condicao = lista[0].Equals(lista[i + 1]);
                }
            }
            if (condicao)
            {
                global::System.Console.WriteLine("foram encontrados itens iguais");
            }
            else
            {
                global::System.Console.WriteLine("nao foram encontrados itens iguais");
            }
            return condicao;
        }
    }
}