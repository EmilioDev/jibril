using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLector.Formats.PDF
{
    public class PdfDocument:BaseDataDocument
    {
        #region constructors
        public PdfDocument() : base()
        {
            //lol
        }

        public PdfDocument(bool IsReadOnly, bool IsSystemFile, bool IsEncripted) : base(IsReadOnly, IsSystemFile, IsEncripted)
        {

        }
        #endregion
        #region functions

        #endregion
    }
}
