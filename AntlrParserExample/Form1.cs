using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrParserExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void parseBtn_Click(object sender, EventArgs e)
        {
#if DEBUG && HELLO
            String input = editor.Text;
            ICharStream stream = CharStreams.fromstring(input);
            ITokenSource lexer = new HelloLexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            HelloParser parser = new HelloParser(tokens);

            HelloCustomListener helloListener = new HelloCustomListener();
            parser.r().EnterRule(helloListener);
#elif DEBUG && ADVANCED
            String input = editor.Text;
            ICharStream stream = CharStreams.fromstring(input);
            ITokenSource lexer = new VisualBasic6Lexer(stream);
            ITokenStream tokens = new CommonTokenStream(lexer);
            VisualBasic6Parser parser = new VisualBasic6Parser(tokens);
            IParseTree tree = parser.startRule();

            ParseTreeWalker walker = new ParseTreeWalker();
            VisualBasic6CustomListener listener = new VisualBasic6CustomListener();
            walker.Walk(listener, tree);
      
            //parser.startRule().EnterRule(listener);
#endif
        }

        private void Form1_Load(object sender, EventArgs e)
        {
#if DEBUG && HELLO
            editor.Text = "hello junhong";
#elif DEBUG && ADVANCED
            editor.Text = "Sub Hello()" + Environment.NewLine + 
                "\tDebug.Print \"Matthew where are you?\"" + Environment.NewLine + 
                "\nEnd Sub";
#endif
        }
    }
}
