using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDDStore.Core.DomainObjects
{
    public class ValidacoesAfirmativas
    {
        public static void ValidarSeIgual(object obj1, object obj2, string mensagem) 
        {
            if(!obj1.Equals(obj2))
            {
                throw new DomainException(mensagem);
            }
        
        }

        public static void ValidarSeDiferente(object obj1, object obj2, string mensagem)
        {
            if (obj1.Equals(obj2))
            {
                throw new DomainException(mensagem);
            }

        }

        public static void ValidarCaracteres(string valor, int maximo, string mensagem) 
        {
            var length = valor.Trim().Length;
            if(length > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarCaracteres(string valor, int minimo, int maximo, string mensagem)
        {
            var length = valor.Trim().Length;
            if (length < minimo || length > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarExpressao(string padrao, string valor, string mensagem) 
        {
            var regex = new Regex(padrao);

            if (!regex.IsMatch(valor)) throw new DomainException(mensagem);
        }
        public static void ValidarSeVazio(string valor, string mensagem) 
        {
            if(valor == null || valor.Trim().Length == 0) throw new DomainException(mensagem);

        }
        public static void ValidarSeNulo(object obj, string mensagem)
        {
            if(obj is null) throw new DomainException(mensagem);
        }
        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(double valor, double minimo, double maximo, string mensagem)
        {
            if(valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(double valor, double minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(float valor, float minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(decimal valor, decimal minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(int valor, int minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeMenorIgualMinimo(long valor, long minimo, string mensagem)
        {
            if (valor <= minimo) throw new DomainException(mensagem);
        }
        public static void ValidarSeFalso(bool valor, string mensagem)
        {
            if(valor) throw new DomainException(mensagem);
        }
        public static void ValidarSeVerdadeiro(bool valor, string mensagem)
        {
            if (!valor) throw new DomainException(mensagem);
        }

    }
}
