using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;

namespace mathInter
{
    public enum Token
    {
        NUMBER = 0,


        ADD, // +
        MINUS, // -
        MULTIPLY, // *
        DIVISION, // /

        RBRACE, // (
        LBRACE, // )
        ASSIGN,
        VARIABLE,
        SQRT,//√
        EOF // END OF FILE
    }
    public class Tokens
    {
        public readonly Token _tokenType;
        public readonly object _value;

        public Tokens(Token tokenType, object value)
        {
            this._tokenType = tokenType;
            this._value = value;
        }


        public override string ToString()
        {
            return " " + this._tokenType + ":" + this._value;
        }
    }
}
