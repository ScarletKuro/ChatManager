using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Khendys.Controls;

namespace ChatManager
{

    public class ChatMessage
    {
        public enum MsgType
        {
            General,
            Whisper,
            Party,
            Guild,
            Region,
            World,
            Trade,
            Announcement,
            GameMaster

        }        
        public string Message { get; private set; }
        public MsgType Type { get; private set; }
        public ChatMessage(string msg, MsgType type)
        {
            Message = msg;
            Type = type;
        }
    }

    public class ChatControler
    {
        public ExRichTextBox ChatBox { get; private set; }
        public ChatMessage.MsgType Type { get; private set; }
        public RtfColor Color { get; private set; }
        public ChatControler(ExRichTextBox chatbox, ChatMessage.MsgType type, RtfColor color)
        {
            ChatBox = chatbox;
            Type = type;
            Color = color;
        }
    }
}
