using MarkdownMonster.AddIns;
using System;
using System.Linq;
namespace MarkdownMonster
{
    /// <summary>
    /// Retrieves an instance of a markdown parser
    /// </summary>
    public static class MarkdownParserFactory
    {

        /// <summary>
        /// Retrieves a cached instance of the markdown parser
        /// </summary>        
        /// <param name="renderLinksAsExternal"></param>
        /// <returns></returns>
        public static IMarkdownParser GetParser(bool renderLinksAsExternal = false, bool usePragmaLines = false, bool forceLoad = false)
        {
            try
            {
                MarkdownMonsterParserAddin parser = AddinManager.Current.ParserAddins
                    .Where(p => p.Name.Equals(mmApp.Configuration.ParserName))
                    .First();

                return parser.GetParser();
            }
            // In case the parser is not found
            // return the default parser
            catch (InvalidOperationException)
            {
                return new MarkdownParserMarkdig(usePragmaLines: usePragmaLines, force: forceLoad);
            }
        }

    }

    
}