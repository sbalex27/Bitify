using Bitify.Code1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitify.Code8
{
    internal class Lexico
    {
        private const int MAXTOKENS = 500;
        private string[] lexemas;
        private string[] tokens;
        private string lexema;
        private int noTokens;
        private int i;
        private int iniToken;
        private Automata oAFD;

        public Lexico()
        {
            lexemas = new string[MAXTOKENS];
            tokens = new string[MAXTOKENS];
            oAFD = new Automata();
            i = 0;
            iniToken = 0;
            noTokens = 0;
        }

        public void Inicia()
        {
            i = 0;
            iniToken = 0;
            noTokens = 0;
            lexemas = new string[MAXTOKENS];
            tokens = new string[MAXTOKENS];
        }

        public void Analiza(string texto)
        {
            bool recAuto;
            int noAuto;
            while( i < texto.Length)
            {
                recAuto = false;
                noAuto = 0;
                
            }
        }

        public int getI()
        {
            return i;
        }

        public void setI(int i)
        {
            this.i = i;
        }

        public int getIniToken()
        {
            return iniToken;
        }

        public string[] Tokens()
        {
            return tokens;
        }

        public string[] Lexemas()
        {
            return lexemas;
        }



    }
}
