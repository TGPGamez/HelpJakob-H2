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
        public void SendMessage(string recipient, MessageCarrier messageCarrier, Message message, bool isHTML)
        {
            //Sends out a email to receiver
            if (messageCarrier.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    message.Body = HTMLConverter.ConvertBodyToHTML(message.Body);
                //Implement code to send with Smtp
            }

            if (messageCarrier.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    message.Body = HTMLConverter.ConvertBodyToHTML(message.Body);
                //Implement code to send with Smtp VMessage
            }
        }

        /// <summary>
        /// Used to send a message to all 
        /// </summary>
        public void SendMessageToAll(string[] recipients, MessageCarrier messageCarrier, Message message, bool isHTML)
        {
            for (int i = 0; i < recipients.Length; i++)
            {
                SendMessage(recipients[i], messageCarrier, message, isHTML);
            }
        }
    }
}
