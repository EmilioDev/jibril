using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Documents;

namespace DocumentLector.Formats.PlaneText
{
    internal class PlaneTextAnalizer : BaseDocumentAnalizer
    {
        #region datas
        #endregion
        #region constructors
        public PlaneTextAnalizer(string sourceFile) : base(sourceFile)
        {
            //lol
        }
        #endregion
        #region functions
        public override void Close()
        {
            throw new NotImplementedException();
        }

        public override BaseDataDocument ReadDocument()
        {
            if (File.Exists(this._path))//esta comprobacion esta de mas
            {
                FileInfo info = new FileInfo(this._path);

                bool ro = info.IsReadOnly;
                bool fs = info.Attributes == FileAttributes.System;
                bool enc = info.Attributes == FileAttributes.Encrypted;

                List<Inline> doc = new List<Inline>();
                const Int32 BufferSize = 128;

                using (var fileStream = File.OpenRead(this._path))
                {
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                    {
                        String line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            doc.Add(new Run(line));
                        }
                    }
                }
                return new PlaneTextDocument(ro, fs, enc, new Page(doc));
            }
            else throw new FileNotFoundException();
        }

        public override void WriteDocument(BaseDataDocument document, object changes)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
