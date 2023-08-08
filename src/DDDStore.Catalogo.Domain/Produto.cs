using DDDStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DDDStore.Catalogo.Domain
{
    //Raiz de Agregação
    public  class Produto : Entity, IAggrateRoot
    {
        
        public Guid CategoriaId { get;  private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int QuantidadeEstoque { get; private set; }

         public Categoria Categoria { get; private set; }

        public Produto(
            string nome, 
            string descricao, 
            bool ativo, 
            decimal valor, 
            Guid categoriaID, 
            DateTime dataCadastro, 
            string imagem
        )
        {
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            CategoriaId = categoriaID;
            Imagem = imagem;
            DataCadastro = dataCadastro;

            Validar();
        }

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;

        public void AlterarCategoria(Categoria categoria)
        {
            Categoria = categoria;
            CategoriaId = categoria.Id;
        }

        public void AlterarDescricao(string descricao)
        {
            ValidacoesAfirmativas.ValidarSeVazio(Descricao, "O Campo Descrição não pode estar vazio");
            Descricao = descricao;
        }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            if (!PossuiEstoque(quantidade)) throw new DomainException("Estoque Insuficiente");
            QuantidadeEstoque -= quantidade;
        }
        public void ReporEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public bool PossuiEstoque(int quantidade)
        {
            return QuantidadeEstoque >= quantidade;
        }

        public void Validar()
        {
            ValidacoesAfirmativas.ValidarSeVazio(Nome, "O Campo Nome não pode estar vazio");
            ValidacoesAfirmativas.ValidarSeVazio(Descricao, "O Campo Descrição não pode estar vazio");
            ValidacoesAfirmativas.ValidarSeDiferente(CategoriaId, Guid.Empty, "O Campo CategoriaId do Produto deve ser preenchido");
            ValidacoesAfirmativas.ValidarSeMenorIgualMinimo(Valor, 0, "O Campo Valor não pode ser Zero ou Menor");
            ValidacoesAfirmativas.ValidarSeVazio(Imagem, "O Campo Imagem Deve ser Preenchido");
        }

    }
}
