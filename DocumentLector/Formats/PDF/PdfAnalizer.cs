using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using GlobalDatasLibrary;
using System.Drawing;
//using Color = iTextSharp.text.Color;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;
using iTextSharp.text.pdf.parser;
using System.IO;

namespace DocumentLector.Formats.PDF
{
    internal class PdfAnalizer : BaseDocumentAnalizer
    {
        #region constructors
        public PdfAnalizer(string sourceFile) : base(sourceFile)
        {
            //:D
        }
        #endregion
        #region functions
        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override BaseDataDocument ReadDocument()
        {
            PdfDocument document = new PdfDocument();
            using(PdfReader reader = new PdfReader(this._file))
            {
                if (!reader.IsEncrypted())
                {
                    StringBuilder sb = new StringBuilder();
                    //PdfStamper stamper=new PdfStamper(reader)
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    for (int page = 0; page < reader.NumberOfPages; page++)
                    {
                        string text = PdfTextExtractor.GetTextFromPage(reader, page + 1, strategy);

                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            sb.Append(Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text))));
                        }
                    }
                }
                else
                {

                }
            }
            return document;
        }

        public override void WriteDocument(BaseDataDocument document, object changes)
        {
            throw new NotImplementedException();
        }

        private bool PageContainsImage(int pageNumber)
        {
            using (var reader = new PdfReader(this._file))
            {
                var parser = new PdfReaderContentParser(reader);
                ImageRenderListener listener = null;
                parser.ProcessContent(pageNumber, (listener = new ImageRenderListener()));
                return listener.Images.Count > 0;
            }
        }

        private Dictionary<string,Image> ExtractImages(string filename)
        {
            var images = new Dictionary<string, Image>();
            using (var reader = new PdfReader(this._file))
            {
                PdfReaderContentParser parser = new PdfReaderContentParser(reader);
                ImageRenderListener listener = null;

                for(int x = 1; x < reader.NumberOfPages; x++)
                {
                    parser.ProcessContent(x, (listener = new ImageRenderListener()));
                    int index = 1;

                    if (listener.Images.Count > 0)
                    {

                    }
                }

                return images;
            }
        }

        //private string ParsePdf(string fileName)
        //{
        //    if (!File.Exists(fileName))
        //        throw new FileNotFoundException("fileName");
        //    using (PdfReader reader = new PdfReader(fileName))
        //    {
        //        StringBuilder sb = new StringBuilder();

        //        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
        //        for (int page = 0; page < reader.NumberOfPages; page++)
        //        {
        //            string text = PdfTextExtractor.GetTextFromPage(reader, page + 1, strategy);
        //            if (!string.IsNullOrWhiteSpace(text))
        //            {
        //                sb.Append(Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text))));
        //            }
        //        }

        //        return sb.ToString();
        //    }
        //}
        #endregion
    }

}

