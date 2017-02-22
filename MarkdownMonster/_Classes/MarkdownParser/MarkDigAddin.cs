using MarkdownMonster.AddIns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownMonster
{
    public class MarkDigAddin : MarkdownMonsterParserAddin
    {
        public override IMarkdownParser GetParser()
        {
            return new MarkdownParserMarkdig();
        }
        public override string Name => "MarkDig";
    }
}
