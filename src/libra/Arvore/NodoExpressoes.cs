namespace Libra.Arvore
{
    public abstract class Expressao { }

    // TODO: melhorar isso!
    public class ExpressaoTermo : Expressao
    {
        public ExpressaoTermo(Token token)
        {
            Token = token;
        }

        public ExpressaoTermo(InstrucaoChamadaFuncao chamada)
        {
            ChamadaFuncao = chamada;
        }

        public InstrucaoChamadaFuncao ChamadaFuncao { get; private set; }

        public Token Token { get; private set; }

        public string Valor => Token.Valor;        
    }

    public class ExpressaoBinaria : Expressao
    {
        public Expressao Esquerda { get; private set; }
        public Token Operador { get; private set; }
        public Expressao Direita { get; private set; }

        public ExpressaoBinaria(Expressao esquerda, Token operador, Expressao direita)
        {
            Esquerda = esquerda;
            Operador = operador;
            Direita = direita;
        }

    }
    
}