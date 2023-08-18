using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;

namespace mathInter
{
    public class Parser
    {
        private List<Token> TermItems = new List<Token>() { Token.ADD, Token.MINUS };
        private List<Token> FactorItems = new List<Token>() { Token.MULTIPLY, Token.DIVISION, Token.SQRT };
        private List<Token> AssignItems = new List<Token>() { Token.ASSIGN, Token.VARIABLE };
        private readonly List<Tokens> _tokens;
        private int pos = 0;
        private Tokens curr_token = null;

        //BNF
        //<expression> ::= <term> | <term> <add_op> <expression>
        //<term>       ::= <factor> | <factor> <mul_op> <term>
        //<factor>     ::= <number> | <variable> | <sqrt_expression> | '(' <expression> ')'

        //<add_op>     ::= '+' | '-'
        //<mul_op>     ::= '*' | '/'

        //<number>     ::= [0-9]+
        //<variable>   ::= 'x' | 'y'

        //<sqrt_expression> ::= '√' '(' <expression> ')'


        public Parser(List<Tokens> tokens)
        {
            this._tokens = tokens;
            // set the current token
            Get_Next();
        }

        private void Get_Next()
        {
            if (pos < this._tokens.Count)
            {
                curr_token = this._tokens[pos];
                pos++;
            }
        }

        public AST ParseExp()
        {
            AST result = Factor();
            while (curr_token._tokenType != Token.EOF && result != null && TermItems.Contains(curr_token._tokenType))
            {
                if (curr_token._tokenType == Token.ADD)
                {
                    Get_Next();
                    AST rigthNode = Factor();
                    result = new ASTPlus(result, rigthNode);
                }
                else if (curr_token._tokenType == Token.MINUS)
                {
                    Get_Next();
                    AST rigthNode = Factor();
                    result = new ASTMinus(result, rigthNode);
                }
            }

            return result;
        }

        public AST Factor()
        {
            AST factor = Term();
            while (curr_token._tokenType != Token.EOF && factor != null && FactorItems.Contains(curr_token._tokenType))
            {
                if (curr_token._tokenType == Token.MULTIPLY)
                {
                    Get_Next();
                    AST rigthNode = Term();
                    factor = new ASTMultiply(factor, rigthNode);
                }
                else if (curr_token._tokenType == Token.DIVISION)
                {
                    Get_Next();
                    AST rigthNode = Term();
                    factor = new ASTDivide(factor, rigthNode);
                }
                
                
                else if (curr_token._tokenType == Token.SQRT && (string)curr_token._value == "√")
                {
                    Console.WriteLine("SQRT Token is being handled");
                    Get_Next();
                    if (curr_token._tokenType != Token.LBRACE)
                    {
                        throw new FormatException("Missing ( after SQRT");
                    }
                    Get_Next();
                    AST expression = ParseExp();
                    if (curr_token._tokenType != Token.RBRACE)
                    {
                        throw new FormatException("Missing ) after SQRT expression");
                    }
                    Get_Next();

                    Console.WriteLine("SQRT expression parsed: " + expression);
                    return new ASTSqrt(expression); // Construct ASTSqrt node
                }

                }
            return factor;
        }

        public AST Term()
        {
            AST term = null;

            if (curr_token._tokenType == Token.LBRACE)
            {
                Get_Next();
                term = ParseExp();
                if (curr_token._tokenType != Token.RBRACE)
                {
                    throw new FormatException("Missing )");
                }
            }
            else if (curr_token._tokenType == Token.NUMBER)
            {
                term = new ASTLeaf((decimal)curr_token._value);
            }
            Console.WriteLine("current token is : " + curr_token);
            Get_Next();
            return term;
        }

       

    }
}
