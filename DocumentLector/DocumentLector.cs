using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DocumentLector.Formats;
using DocumentLector.Formats.PlaneText;

namespace DocumentLector
{
    public class DocumentLector
    {
        #region constructors
        public DocumentLector()
        {

        }
        #endregion
        #region functions
        public BaseDataDocument ReadDocument(string source)
        {
            switch (Path.GetExtension(source).ToLower())
            {
                default://read as plane text

                    PlaneTextAnalizer analizer = new PlaneTextAnalizer(source);

                    try
                    {
                        return analizer.ReadDocument();
                    }

                    catch(FileNotFoundException notFound)
                    {

                    }

                    catch(Exception x)
                    {

                    }

                    break;
            }
            throw new IOException();
        }
        #endregion
    }
}
