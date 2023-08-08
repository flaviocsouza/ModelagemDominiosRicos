using DDDStore.Core.DomainObjects;

namespace DDDStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }



        public int Codigo { get; private set; }

        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;

            Validar();
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            ValidacoesAfirmativas.ValidarSeVazio(Nome, "O Campo Nome não pode estar vazio");
            ValidacoesAfirmativas.ValidarSeIgual(Codigo, 0, "O Campo Código não pode ser zero");
        }

    }
}
