using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitify.Code1
{
    internal class Automata
    {
        const int MAXTOKENS = 256;
        const int ANCHOTOKEN = 20;
        const int ANCHOLEXEMA = 255;

        public int iEdoAct { get; set; }
        public string psTexto { get; set; }
        public string NextChar(int iI)
        {
            return psTexto[iI++].ToString();
        }

        public int iReconoce(string a, int b, int c)
        {
            return 0;
        }
    }

    internal abstract class Lexico
    {
        private int iI, iIniToken, iNoTokens;
        private const int MAXTOKENS = 100;
        private const int ANCHOTOKEN = 50;
        private const int ANCHOLEXEMA = 50;
        private char[,] asTokens = new char[MAXTOKENS, ANCHOTOKEN];
        private char[,] asLexemas = new char[MAXTOKENS, ANCHOLEXEMA];
        private char[] sLexema = new char[255];
        private Automata oAFD;


        public abstract void Analiza(string input);
        public abstract void Inicia();
        public abstract void Lexema(string input);
    }
}
