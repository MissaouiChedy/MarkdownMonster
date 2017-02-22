using System;
using System.Windows;
using FontAwesome.WPF;
using MarkdownMonster;
using MarkdownMonster.AddIns;

namespace CustomParserAddin
{
    public class CustomParser : IMarkdownParser
    {
        public string Parse(string markdown, bool renderLinksExternal = false)
        {
            return "<h1>Kablam</h1>";
        }
    }

    public class CustomParserAddin : MarkdownMonsterParserAddin
    {
        public override string Name => "CustomParser";

        public override IMarkdownParser GetParser()
        {
            return new CustomParser();
        }

        public override void OnApplicationStart()
        {
            base.OnApplicationStart();

            Id = " CustomParserAddin";
        }

        public override bool OnCanExecute(object sender)
        {
            return true;
        }

    }
}
