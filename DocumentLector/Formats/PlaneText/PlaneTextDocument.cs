using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLector.Formats.PlaneText
{
    public class PlaneTextDocument:BaseDataDocument
    {
        #region datas
        #endregion
        #region constructors
        public PlaneTextDocument() : base()
        {

        }

        public PlaneTextDocument(bool IsReadOnly, bool IsSystemFile, bool IsEncrypted) : base(IsReadOnly, IsSystemFile, IsEncrypted)
        {

        }

        public PlaneTextDocument(bool IsReadOnly, bool IsSystemFile, bool IsEncripted, List<Page> Pages) : base(IsReadOnly, IsSystemFile, IsEncripted, Pages)
        {

        }

        public PlaneTextDocument(bool IsReadOnly, bool IsSystemFile, bool IsEncripted, Page Page) : base(IsReadOnly, IsSystemFile, IsEncripted, Page)
        {

        }
        #endregion
    }
}
