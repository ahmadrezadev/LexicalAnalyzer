using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LexicalAnalyzer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sInfo = new ProcessStartInfo("https://ahmadrezadev.ir/");
            Process.Start(sInfo);
        }

        private async void btnBrowseFile_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                var res = fileDialog.ShowDialog();
                if (res != DialogResult.OK) return;

                lstSourceView.Items.Clear();
                using (var streamReader = File.OpenText(fileDialog.FileName))
                {
                    string result;
                    while ((result = await streamReader.ReadLineAsync()) != null)
                    {
                        lstSourceView.Items.Add(result);
                    }
                    lstLexicalOutputView.Items.Clear();
                    lstConsoleError.Items.Clear();
                    streamReader.Close();
                }
            }
        }

        private void btnStartLexical_Click(object sender, EventArgs e)
        {
            try
            {
                lstLexicalOutputView.Items.Clear();
                lstConsoleError.Items.Clear();

                var nextLine = 0;
                var tokenNumber = 0;
                var meetCounter = 1;
                var lineOfFile = lstSourceView.Items.Count;

                var temp = new char[100];
                var tokens = new string[100];
                var lexeme = new string[100];

                while (nextLine <= lineOfFile - 1)
                {
                    if ((string)lstSourceView.Items[nextLine] == "")
                    {
                        continue;
                    }

                    var j = 0;
                    var codeLine = lstSourceView.Items[nextLine].ToString();

                    for (var t = 0; t <= temp.Length - 1; t++)
                        temp[t] = ' ';

                    nextLine++;
                    codeLine += " EOL";
                    var lineMaxLength = codeLine.Length;
                    var token = " ";
                    while (token != " EOL")
                    {
                        token = " ";
                        var counter = j;
                        if (meetCounter == 2)
                        {

                        }

                        while (j <= lineMaxLength - 1)
                        {
                            if (codeLine[j] != ' ')
                            {
                                if (codeLine[j] == '{')
                                {
                                    temp[j] = '{';
                                    j++;
                                    break;
                                }

                                if (codeLine[j] == '}')
                                {
                                    temp[j] = '}';
                                    j++;
                                    break;
                                }

                                if (codeLine[j] == 'f' && codeLine[j + 1] == 'o' && codeLine[j + 2] == 'r')
                                {
                                    temp[j] = 'f';
                                    temp[j + 1] = 'o';
                                    temp[j + 2] = 'r';
                                    j += 3;
                                    break;
                                }

                                if (codeLine[j] == 't' && codeLine[j + 1] == 'h' && codeLine[j + 2] == 'e' && codeLine[j + 3] == 'n')
                                {
                                    temp[j] = 't';
                                    temp[j + 1] = 'h';
                                    temp[j + 2] = 'e';
                                    temp[j + 3] = 'n';
                                    j += 4;
                                    break;
                                }

                                if (codeLine[j] == 'w' && codeLine[j + 1] == 'h' && codeLine[j + 2] == 'i' && codeLine[j + 3] == 'l' && codeLine[j + 4] == 'e')
                                {
                                    temp[j] = 'w';
                                    temp[j + 1] = 'h';
                                    temp[j + 2] = 'i';
                                    temp[j + 3] = 'l';
                                    temp[j + 4] = 'e';
                                    j += 5;
                                    break;
                                }

                                if (codeLine[j] == '(')
                                {
                                    if (meetCounter == 1)
                                    {
                                        meetCounter = 2;
                                        break;
                                    }

                                    meetCounter = 1;
                                    temp[j] = '(';
                                    j++;
                                    break;
                                }

                                if (codeLine[j] == ')')
                                {
                                    if (meetCounter == 1)
                                    {
                                        meetCounter = 2;
                                        break;
                                    }

                                    meetCounter = 1;
                                    temp[j] = ')';
                                    j++;
                                    break;
                                }

                                if (codeLine[j] == 'i' && codeLine[j + 1] == 'f')
                                {
                                    temp[j] = 'i';
                                    temp[j + 1] = 'f';
                                    j += 2;
                                    break;
                                }

                                if (codeLine[j] == ';')
                                {
                                    if (meetCounter == 1)
                                    {
                                        meetCounter = 2;
                                        break;
                                    }

                                    meetCounter = 1;
                                    temp[j] = ';';
                                    j++;
                                    break;
                                }

                                if (codeLine[j] == '>' || codeLine[j] == '<' || codeLine[j] == '=' || codeLine[j] == '!')
                                {
                                    if (codeLine[j] == '=' && codeLine[j + 1] == '=')
                                    {
                                        if (meetCounter == 1)
                                        {
                                            meetCounter = 2;
                                            break;
                                        }

                                        meetCounter = 1;
                                        temp[j] = codeLine[j];
                                        temp[j + 1] = codeLine[j + 1];
                                        j += 2;
                                        break;
                                    }

                                    if (meetCounter == 1)
                                    {
                                        meetCounter = 2;
                                        break;
                                    }

                                    meetCounter = 1;
                                    temp[j] = codeLine[j];
                                    j++;
                                    break;
                                }

                                if (codeLine[j] == '+' || codeLine[j] == '-' || codeLine[j] == '*' || codeLine[j] == '/')
                                {
                                    if (meetCounter == 1)
                                    {
                                        meetCounter = 2;
                                        break;
                                    }

                                    meetCounter = 1;
                                    temp[j] = codeLine[j];
                                    j++;
                                    break;
                                }

                                if ((codeLine[j] == '"'))
                                {
                                    if (meetCounter == 1)
                                    {
                                        meetCounter = 2;
                                        break;
                                    }

                                    meetCounter = 1;
                                    temp[j] = '"';
                                    j++;
                                    break;
                                }

                                if (codeLine[j] == ' ')
                                {
                                    j++;
                                    break;
                                }

                                temp[j] = codeLine[j];
                                j++;
                            }
                            else
                            {
                                j++;
                                break;
                            }
                        }

                        for (; counter <= j - 1; counter++)
                            token += temp[counter];

                        if (temp[counter] == '"')
                            token = "litteral";

                        switch (token.Trim())
                        {
                            case "=":
                                {
                                    tokens[tokenNumber] = "ASSIGNMENT OPERATION";
                                    break;
                                }
                            case "litteral":
                                {
                                    tokens[tokenNumber] = "LITTERAL";
                                    break;
                                }
                            case "then":
                                {
                                    tokens[tokenNumber] = "THEN";
                                    break;
                                }
                            case "if":
                                {
                                    tokens[tokenNumber] = "IF";
                                    break;
                                }
                            case "for":
                                {
                                    tokens[tokenNumber] = "FOR";
                                    break;
                                }
                            case "while":
                                {
                                    tokens[tokenNumber] = "WHILE";
                                    break;
                                }
                            case "{":
                                {
                                    tokens[tokenNumber] = "{";
                                    break;
                                }
                            case "}":
                                {
                                    tokens[tokenNumber] = "}";
                                    break;
                                }
                            case "(":
                                {
                                    tokens[tokenNumber] = "(";
                                    break;
                                }
                            case ")":
                                {
                                    tokens[tokenNumber] = ")";
                                    break;
                                }
                            case ">":
                                {
                                    tokens[tokenNumber] = "RELATION OPERATION";
                                    break;
                                }
                            case "<":
                                {
                                    tokens[tokenNumber] = "RELATION OPERATION";
                                    break;
                                }
                            case ">=":
                                {
                                    tokens[tokenNumber] = "RELATION OPERATION";
                                    break;
                                }
                            case "<=":
                                {
                                    tokens[tokenNumber] = "RELATION OPERATION";
                                    break;
                                }
                            case "!=":
                                {
                                    tokens[tokenNumber] = "RELATION OPERATION";
                                    break;
                                }
                            case "==":
                                {
                                    tokens[tokenNumber] = "RELATION OPERATION";
                                    break;
                                }
                            case ";":
                                {
                                    tokens[tokenNumber] = ";";
                                    break;
                                }
                            case "+":
                                {
                                    tokens[tokenNumber] = "ARITHMETIC OPERATION";
                                    break;
                                }
                            case "-":
                                {
                                    tokens[tokenNumber] = "ARITHMETIC OPERATION";
                                    break;
                                }
                            case "*":
                                {
                                    tokens[tokenNumber] = "ARITHMETIC OPERATION";
                                    break;
                                }
                            case "/":
                                {
                                    tokens[tokenNumber] = "ARITHMETIC OPERATION";
                                    break;
                                }
                            case "\"":
                                {
                                    tokens[tokenNumber] = "\"";
                                    break;
                                }
                            case "EOL":
                                {
                                    break;
                                }
                            case "\0":
                                {
                                    break;
                                }
                            case "":
                                {
                                    break;
                                }
                            default:
                                {
                                    var statusValue = true;
                                    for (var i = 0; i <= token.Length - 1; i++)
                                    {
                                        if (token[i] >= 'a' && token[i] <= 'z' || token[i] >= 'A' && token[i] <= 'Z')
                                        {
                                            statusValue = false;
                                            break;
                                        }

                                        switch (token[i])
                                        {
                                            case '~':
                                                {
                                                    statusValue = false;
                                                    tokens[tokenNumber] = "~";
                                                    break;
                                                }
                                            case '@':
                                                {
                                                    statusValue = false;
                                                    tokens[tokenNumber] = "@";
                                                    break;
                                                }
                                            case '#':
                                                {
                                                    statusValue = false;
                                                    tokens[tokenNumber] = "#";
                                                    break;
                                                }
                                            case '$':
                                                {
                                                    statusValue = false;
                                                    tokens[tokenNumber] = "$";
                                                    break;
                                                }
                                            case '%':
                                                {
                                                    statusValue = false;
                                                    tokens[tokenNumber] = "%";
                                                    break;
                                                }
                                            case '^':
                                                {
                                                    statusValue = false;
                                                    tokens[tokenNumber] = "^";
                                                    break;
                                                }
                                            case '&':
                                                {
                                                    statusValue = false;
                                                    tokens[tokenNumber] = "&";
                                                    break;
                                                }
                                        }
                                    }

                                    if (statusValue)
                                        tokens[tokenNumber] = "VALUE";
                                    else
                                    {
                                        var isIdentifier = !(token.Trim()[0] >= '0' && token.Trim()[0] <= '9');

                                        for (var i = 0; i <= token.Length - 1; i++)
                                        {
                                            switch (token[i])
                                            {
                                                case '!':
                                                    {
                                                        isIdentifier = false;
                                                        break;
                                                    }
                                                case '@':
                                                    {
                                                        isIdentifier = false;
                                                        break;
                                                    }
                                            }
                                        }

                                        if (isIdentifier)
                                            tokens[tokenNumber] = "ID";
                                        else
                                        {
                                            lstSourceView.SetSelected(nextLine - 1, true);
                                            lstConsoleError.Items.Add("Lexical error at line " + nextLine);
                                            tokens[tokenNumber] = "ERROR";
                                        }
                                    }
                                }
                                break;

                        }

                        if (token.Trim() == "\0" || token.Trim() == "EOL" || token.Trim() == "")
                        {

                        }
                        else
                        {
                            lexeme[tokenNumber] = token;
                            tokenNumber++;
                        }
                    }
                }

                for (var count = 0; tokens[count] != null; count++)
                {
                    if (tokens[count] != "" && tokens[count] != " EOL")
                    {
                        lstLexicalOutputView.Items.Add(" < " + lexeme[count] + " > " + "       " + tokens[count]);
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Error!", "An eeror has occoured while processing! \r\n\r\n" + exception.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}