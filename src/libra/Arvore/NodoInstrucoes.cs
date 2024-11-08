
namespace Libra.Arvore
{
    public abstract class Instrucao { }

    public class InstrucaoSair : Instrucao
    {
        public InstrucaoSair(Expressao expressao)
        {
            Expressao = expressao;
        }

        public Expressao Expressao { get; private set; }

    }

    public class InstrucaoVar : Instrucao
    {
        public InstrucaoVar(string identificador, object valor, bool constante, bool declaracao, TokenTipo tipo = TokenTipo.TokenInvalido, Expressao indice = null)
        {
            Valor = valor;
            Identificador = identificador;
            EhDeclaracao = declaracao;
            Constante = constante;
            Tipo = tipo;   
            IndiceVetor = indice; 
        }

        public object Valor { get; private set; }
        public TokenTipo Tipo { get; private set; }
        public string Identificador {get; private set; }
        public Expressao IndiceVetor { get; private set; }
        internal bool EhDeclaracao; // usada para saber se estamos declarando uma nova variável ou só modificando uma
        public bool Constante { get; private set; }

    }

    public class InstrucaoFuncao : Instrucao
    {
        public InstrucaoFuncao(string identificador, Instrucao[] instrucoes, List<string> parametros = null)
        {
            Instrucoes = instrucoes;
            Identificador = identificador;
            Parametros = parametros;
        }

        public Instrucao[] Instrucoes { get; private set; }
        public string Identificador {get; private set; }
        public List<string> Parametros { get; private set; }

    }

    public class InstrucaoSe : Instrucao
    {
        public InstrucaoSe(Expressao expressao, Instrucao[] instrucoes, Instrucao[] senaoInstrucoes = null)
        {
            Expressao = expressao;
            Instrucoes = instrucoes;
            SenaoInstrucoes = senaoInstrucoes;
        }

        public Expressao Expressao { get; private set; }
        public Instrucao[] Instrucoes {get; private set; }
        public Instrucao[] SenaoInstrucoes {get; private set; }

    }

    public class InstrucaoEnquanto : Instrucao
    {
        public InstrucaoEnquanto(Expressao expressao, Instrucao[] instrucoes)
        {
            Expressao = expressao;
            Instrucoes = instrucoes;
        }

        public Expressao Expressao { get; private set; }
        public Instrucao[] Instrucoes {get; private set; }

    }

    public class InstrucaoRomper : Instrucao
    {
        // Nada de interessante...
    }

    public class InstrucaoRetornar : Instrucao
    {
        public Expressao Expressao { get; private set; }

        public InstrucaoRetornar(Expressao expressao)
        {
            Expressao = expressao;
        }
    }

    public class InstrucaoChamadaFuncao : Instrucao
    {
        public InstrucaoChamadaFuncao(ExpressaoChamadaFuncao chamada)
        {
            Chamada = chamada;
        }

        public ExpressaoChamadaFuncao Chamada { get; private set; }
    }
}