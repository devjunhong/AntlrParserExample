using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace AntlrParserExample
{
    class VisualBasic6CustomListener : VisualBasic6BaseListener
    {
        public override void EnterStartRule([NotNull] VisualBasic6Parser.StartRuleContext context)
        {
            base.EnterStartRule(context);

            Console.WriteLine("#include <stdio.h>");

            context.module();
        }

        public override void EnterSubStmt([NotNull] VisualBasic6Parser.SubStmtContext context)
        {
            base.EnterSubStmt(context);

            Console.WriteLine("void " + context.ambiguousIdentifier().GetText() + "(){");

            context.block();
        }

        public override void EnterModule([NotNull] VisualBasic6Parser.ModuleContext context)
        {
            base.EnterModule(context);

            context.moduleBody();
        }

        public override void EnterModuleBody([NotNull] VisualBasic6Parser.ModuleBodyContext context)
        {
            base.EnterModuleBody(context);

            context.moduleBodyElement();
        }

        public override void EnterModuleBodyElement([NotNull] VisualBasic6Parser.ModuleBodyElementContext context)
        {
            base.EnterModuleBodyElement(context);

            context.subStmt();
        }

        public override void EnterBlock([NotNull] VisualBasic6Parser.BlockContext context)
        {
            base.EnterBlock(context);

            context.blockStmt();
        }

        public override void EnterBlockStmt([NotNull] VisualBasic6Parser.BlockStmtContext context)
        {
            base.EnterBlockStmt(context);

            context.implicitCallStmt_InBlock();
        }

        public override void EnterImplicitCallStmt_InBlock([NotNull] VisualBasic6Parser.ImplicitCallStmt_InBlockContext context)
        {
            base.EnterImplicitCallStmt_InBlock(context);

            context.iCS_B_MemberProcedureCall();
        }

        public override void EnterICS_B_MemberProcedureCall([NotNull] VisualBasic6Parser.ICS_B_MemberProcedureCallContext context)
        {
            base.EnterICS_B_MemberProcedureCall(context);

            string caller = context.implicitCallStmt_InStmt().GetText() + context.DOT().GetText() + context.ambiguousIdentifier().GetText();
            if (caller == "Debug.Print")
            {
                Console.WriteLine("\tprintf(" + context.argsCall().GetText() + ");");
            }
        }

        public override void ExitSubStmt([NotNull] VisualBasic6Parser.SubStmtContext context)
        {
            base.ExitSubStmt(context);

            Console.WriteLine("\treturn 0;");
            Console.WriteLine("}");
        }
    }
}
