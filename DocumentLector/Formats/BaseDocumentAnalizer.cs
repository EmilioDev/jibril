using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GlobalDatasLibrary;

namespace DocumentLector.Formats
{
    internal abstract class BaseDocumentAnalizer
    {
        #region properties
        protected FileStream _file;
        protected string _path;
        #endregion
        #region constructors
        public BaseDocumentAnalizer(string sourceFile)
        {
            //if (!File.Exists(sourceFile)) throw new FileNotFoundException(Current.GetPhraseInCurrentLanguaje("file_not_found"), sourceFile);
            this._path = sourceFile;
            this._file = new FileStream(sourceFile, FileMode.Open);
        }
        #endregion
        #region functions
        public static bool IsValidExtension(string extension)
        {
            switch (extension.ToLower())
            {
                case ".pdf":
                case ".html":
                case ".rtf":
                case ".jpg":
                case ".jpeg":
                case ".gif":
                case ".bmp":
                case ".dcm":
                case ".txt":
                    return true;
                default:
                    return false;

            }
        }
        /// <summary>
        /// Read the document
        /// </summary>
        /// <returns>The document read</returns>
        public abstract BaseDataDocument ReadDocument();

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
