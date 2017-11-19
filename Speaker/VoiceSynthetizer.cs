using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;
using System.Speech.AudioFormat;

namespace Speaker
{
    /// <summary>
    /// Base class for the talking synthetizers
    /// </summary>
    public abstract class VoiceSynthetizer
    {
        #region datas
        protected CultureInfo culture;
        private bool talking;
        protected Stream output;
        protected SpeechAudioFormatInfo format;
        #endregion

        #region properties
        public SpeechAudioFormatInfo Format_Info
        {
            get
            {
                return this.format;
            }
            set
            {
                this.format = value;
            }
        }

        /// <summary>
        /// Output of the Synthetizer
        /// </summary>
        public Stream Voice_Output_Stream
        {
            get
            {
                return this.output;
            }
            set
            {
                this.output = value;
            }
        }

        /// <summary>
        /// Current culture employed by the synthetizer
        /// </summary>
        public CultureInfo Current_Culture
        {
            get
            {
                return this.culture;
            }
            set
            {
                this.culture = value;
            }
        }

        /// <summary>
        /// True if the synthetizer is talking, false if not
        /// </summary>
        public bool Is_Talking
        {
            get
            {
                return this.talking;
            }
        }
        #endregion

        #region delegates and events

        #endregion

        #region constructors
        public VoiceSynthetizer()
        {
            this.culture = new CultureInfo("es-ES");
            this.output = null;
            this.format = null;
            this.InitializeComponents();
        }

        public VoiceSynthetizer(CultureInfo culture)
        {
            this.culture = culture;
            this.output = null;
            this.format = null;
            this.InitializeComponents();
        }
        #endregion

        #region functions
        /// <summary>
        /// Initializes events and components
        /// </summary>
        protected virtual void InitializeComponents()
        {
            this.talking = false;
        }

        public abstract void SpeakText(string text);

        public abstract string ListenConversation();
        
        #endregion
    }
}
