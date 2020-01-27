using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

namespace AntlrParserExample
{
    class HelloCustomListener: HelloBaseListener
    {
        override
        public void EnterR(HelloParser.RContext context)
        {
            Console.WriteLine(context.children[0].ToString());
            Console.WriteLine("EnterR");
        }
    }
}
