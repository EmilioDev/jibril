using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLector.Formats
{
    internal abstract class BaseDocumentAnalizer
    {
        #region functions
        /// <summary>
        /// Read the document
        /// </summary>
        /// <param name="address">Adress to document</param>
        /// <returns>The document read</returns>
        public abstract BaseDataDocument ReadDocument(string address);

        /// <summary>
        /// Modifies a document
        /// </summary>
        /// <param name="document">Document to mudify</param>
        /// <param name="changes">Changes to apply</param>
        public abstract void WriteDocument(BaseDataDocument document, object changes);

        /// <summary>
        /// Closes the reader
        /// </summary>
        public abstract void Close();
        #endregion
    }
}
