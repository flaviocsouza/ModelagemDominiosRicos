using DDDStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDStore.Catalogo.Domain
{
    //Objeto de Valor não herda de Entity
    public class Dimensoes
    {
        public decimal Altura { get; private set; }
        public decimal Largura { get; private set; }
        public decimal Profundidade { get; private set; }

        public Dimensoes(
            decimal altura, 
            decimal largura, 
            decimal profundidade
        )
        {
            ValidacoesAfirmativas.ValidarSeMenorIgualMinimo(altura, 1, "o Campo Altura Deve Ser Maior que Um Milimetro");
            ValidacoesAfirmativas.ValidarSeMenorIgualMinimo(largura, 1, "o Campo Largura Deve Ser Maior que Um Milimetro");
            ValidacoesAfirmativas.ValidarSeMenorIgualMinimo(profundidade, 1, "o Campo Profundidade Deve Ser Maior que Um Milimetro");

            Altura = altura;
            Largura = largura;
            Profundidade = profundidade;
        }

        public string DescricaoFormatada()
        {
            return $"LxAxP {Largura} X {Altura} x {Profundidade} ";
        }

        public override string ToString()
        {
            return DescricaoFormatada();
        }
    }
}
