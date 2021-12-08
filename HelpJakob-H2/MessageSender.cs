using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob_H2
{
    public class MessageSender
    {
        /// <summary>
        /// Used to send message to recipient 
        /// </summary>
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            //Sends out a email to receiver
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = HTMLConverter.ConvertBodyToHTML(m.Body);
                //Implement code to send with Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = HTMLConverter.ConvertBodyToHTML(m.Body);
                //Implement code to send with Smtp VMessage
            }
        }

        /// <summary>
        /// Used to send a message to all 
        /// </summary>
        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = HTMLConverter.ConvertBodyToHTML(m.Body);
                //Implement code to send with Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = HTMLConverter.ConvertBodyToHTML(m.Body);
                //Implement code to send with Smtp VMessage
            }
        }
    }
}
