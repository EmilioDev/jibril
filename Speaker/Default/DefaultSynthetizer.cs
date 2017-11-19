using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Speaker.Default
{
    public class DefaultSynthetizer : VoiceSynthetizer
    {
        #region constructors
        public DefaultSynthetizer() : base()
        {

        }
        #endregion
        #region functions
        public override string ListenConversation()
        {
            return string.Empty;
        }

        public override void SpeakText(string text)
        {
            using(SpeechSynthesizer syn=new SpeechSynthesizer())
            {
                if (this.output == null || this.format == null) syn.SetOutputToDefaultAudioDevice();
                else syn.SetOutputToAudioStream(this.output, this.format);
                syn.Speak(text);
            }
        }
        #endregion
    }
}
