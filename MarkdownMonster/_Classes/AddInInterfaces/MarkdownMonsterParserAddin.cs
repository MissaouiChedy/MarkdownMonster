using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkdownMonster.AddIns
{
    public abstract class MarkdownMonsterParserAddin : MarkdownMonsterAddin, IMarkdownMonsterAddin
    {
        public abstract IMarkdownParser GetParser();
        public abstract string Name { get; }
    }
}
