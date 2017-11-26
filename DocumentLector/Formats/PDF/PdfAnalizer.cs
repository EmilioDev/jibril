using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using GlobalDatasLibrary;

//using Color = iTextSharp.text.Color;
using Font = iTextSharp.text.Font;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;


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
            PdfReader reader = new PdfReader(this._file);
            if (reader.IsEncrypted())
            {

            }
            else
            {

            }

            return document;
        }

        public override void WriteDocument(BaseDataDocument document, object changes)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
