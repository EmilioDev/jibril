using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Shapes;

namespace DocumentLector.Formats
{
    public class Page
    {
        public List<Inline> Lines { get; set; }

        public Rectangle PageDimensions { get; set; }


        public Page() : this(new List<Inline>())
        {
            //lol
        }

        public Page(List<Inline> lines)
        {
            this.Lines = lines;
            this.PageDimensions = new Rectangle();
        }

        public Page(List<Inline>lines,Rectangle PageDimensions)
        {
            this.Lines = lines;
            this.PageDimensions = PageDimensions;
        }

        //example
        //public void Example()
        //{
        //    // create some inlines
        //    List<Inline> inlines = new List<Inline>();
        //    inlines.Add(new Run() { Text = "text" });
        //    Span span = new Span();
        //    span.Inlines.AddSafe(new Run() { Text = "text inside span" });
        //    inlines.Add(span);

        //    // now apply to a TextBlock
        //    TextBlock tb = new TextBlock() { TextWrapping = TextWrapping.Wrap };
        //    tb.Inlines.Clear();
        //    foreach (Inline i in inlines)
        //        tb.Inlines.Add(i);
        //}
    }
}
