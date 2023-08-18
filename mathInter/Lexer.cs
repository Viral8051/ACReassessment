using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathInter
{
    public class Lexer
    {
        private readonly List<Tokens> tokens;
        private readonly string _input;
        private readonly string _inputX;
        private readonly string _inputY;

        // LIST CHECKER
        private List<char> NumberList = new List<char> { '.', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-','√'};
        private List<char> VarList = new List<char> {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };


        private Int32 pos = 0;
        private char curr_input;

        public Lexer(string input, string inputX = "", string inputY = "")
        {
            this._input = input;
            this._inputX = inputX;
            this._inputY = inputY;
            tokens = new List<Tokens>();
            this.curr_input = input.Length > 0 ? this._input[pos] : '\0'; // set first char
        }

        private void Get_Next()
        {
            if (pos < this._input.Length - 1)
            {
                pos++;
                this.curr_input = this._input[pos];

            }
            else
            {
                curr_input = '\0';
            }
        }

        public List<Tokens> Get_Tokens()
        {

            while (true)
            {
                if (curr_input == ' ' || curr_input == '\t')
                {
                    // Skip empty space
                    Get_Next();
                    continue;
                }
                else if (VarList.Contains(curr_input))
                {
                    Tokens varToken = Generate_Varvalue();
                    if (varToken == null)
                    {
                        throw new InvalidCastException("Could not parse to integer");
                    }
                    tokens.Add(varToken);
                }
                else if (NumberList.Contains(curr_input))
                {
                    Tokens numberToken = Generate_Number();
                    if (numberToken == null)
                    {
                        throw new InvalidCastException("Could not parse to integer");
                    }
                    tokens.Add(numberToken);
                }
                else if (curr_input == '=')
                {
                    Tokens assignToken = new Tokens (Token.ASSIGN, null);
                    tokens.Add(assignToken);
                    Console.WriteLine("Assign Token is added" +assignToken);
                    Get_Next();
                }
                else if (curr_input == '+')
                {
                    Tokens additionToken = new Tokens(Token.ADD, null);
                    tokens.Add(additionToken);
                    Get_Next();
                }
                else if (curr_input == '-')
                {
                    Tokens minusToken = new Tokens(Token.MINUS, null);
                    tokens.Add(minusToken);
                    Get_Next();
                }
                else if (curr_input == '*')
                {
                    Tokens multiplyToken = new Tokens(Token.MULTIPLY, null);
                    tokens.Add(multiplyToken);
                    Get_Next();
                }
                else if (curr_input == '/')
                {
                    Tokens divideToken = new Tokens(Token.DIVISION, null);
                    tokens.Add(divideToken);
                    Get_Next();
                }
                else if (curr_input == '(')
                {
                    Tokens lbraceToken = new Tokens(Token.LBRACE, null);
                    tokens.Add(lbraceToken);
                    Get_Next();
                }
                else if (curr_input == ')')
                {
                    Tokens rbraceToken = new Tokens(Token.RBRACE, null);
                    tokens.Add(rbraceToken);
                    Get_Next();
                }
                else if (curr_input == '√')
                {
                    Tokens sqrtToken = new Tokens(Token.SQRT, null);
                    tokens.Add(sqrtToken);
                    Console.WriteLine($"SQRT Token is added: {sqrtToken}");
                    Get_Next();
                }
                else if (curr_input == '\0')
                {
                    Tokens eofToken = new Tokens(Token.EOF, null);
                    tokens.Add(eofToken);
                    break;
                }
                /*else
                {
                    throw new InvalidOperationException($"{curr_input} is an unsupported type");
                }*/
            }


            return tokens;
        }

        private Tokens Generate_Number()
        {
            int decimal_count = 0;
            StringBuilder sb = new StringBuilder();
            while (NumberList.Contains(curr_input))
            {
                if (curr_input == '.' && decimal_count < 1)
                {
                    decimal_count++;
                }

                if (sb.Length < 1 && decimal_count > 0)
                {
                    // You have a decimal place starting
                    // with no preceding number i.e .6767 = 0.6767
                    sb.Append("0");
                }
                sb.Append(curr_input);
                Get_Next();
            }

            string str = sb.ToString();
            decimal val = Convert.ToDecimal(str);
            return new Tokens(Token.NUMBER, val);
        }

        private Tokens Generate_Varvalue()
        {
            decimal val;
            Tokens token = null;
            StringBuilder sb1 = new StringBuilder();
            while (VarList.Contains(curr_input) )
            {
                if(curr_input.ToString().ToLower() == "x")
                {
                    val = Convert.ToDecimal(_inputX);
                    token = new Tokens(Token.NUMBER, val);
                }
                else if(curr_input.ToString().ToLower() == "y")
                {
                    val = Convert.ToDecimal(_inputY);
                    token = new Tokens(Token.NUMBER, val);
                }
                Get_Next();
            }
            return token;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var token in tokens)
            {
                sb.Append(token.ToString());
            }

            return sb.ToString();
        }
    
    }
}
