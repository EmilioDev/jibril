using System.Collections.Generic;
namespace DocumentLector.Formats
{
    public abstract class BaseDataDocument
    {
        #region datas
        protected readonly bool _readOnly;
        protected readonly bool _systemFile;
        protected readonly bool _encrypted;
        protected List<Page> _pages;
        #endregion

        #region properties
        /// <summary>
        /// Document Content
        /// </summary>
        public List<Page> Pages
        {
            get
            {
                return this._pages;
            }
            set
            {
                if (this._readOnly || this._systemFile || this._encrypted || value == null) return;
                this._pages = value;
            }
        }

        /// <summary>
        /// True if the document can not be modified, false in other case
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return this._readOnly;
            }
        }

        /// <summary>
        /// True if it is a system file, false in other case
        /// </summary>
        public bool IsSystemFile
        {
            get
            {
                return this._systemFile;
            }
        }

        /// <summary>
        /// True if the file is encrypted, false in other case
        /// </summary>
        public bool IsEncrypted
        {
            get
            {
                return this._encrypted;
            }
        }
        #endregion

        #region constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseDataDocument() : this(false, false, false)
        {
            //lol
        }

        
        public BaseDataDocument(bool IsReadOnly,bool IsSystemFile,bool IsEncripted)
        {
            this._readOnly = IsReadOnly;
            this._systemFile = IsSystemFile;
            this._encrypted = IsEncripted;
            this._pages = new List<Page>();
        }


        public BaseDataDocument(bool IsReadOnly, bool IsSystemFile, bool IsEncripted, List<Page> Pages)
        {
            this._readOnly = IsReadOnly;
            this._systemFile = IsSystemFile;
            this._encrypted = IsEncripted;
            this._pages = Pages;
        }


        public BaseDataDocument(bool IsReadOnly, bool IsSystemFile, bool IsEncripted, Page Page)
        {
            this._readOnly = IsReadOnly;
            this._systemFile = IsSystemFile;
            this._encrypted = IsEncripted;
            this._pages = new List<Page>();
            this._pages.Add(Page);
        }
        #endregion
    }
}
