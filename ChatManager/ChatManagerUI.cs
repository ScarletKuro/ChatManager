using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ChatManager.Properties;
using Khendys.Controls;

namespace ChatManager
{
    public partial class ChatManagerUI : Form
    {
        private readonly Hashtable _emotions;
        private readonly List<ChatControler> _chatControlers;
        public ChatManagerUI()
        {
            _emotions = new Hashtable(20);
            CreateEmotions();
            InitializeComponent();
            _chatControlers = new List<ChatControler>
            {
                new ChatControler(richTextBox1, ChatMessage.MsgType.General, RtfColor.Black),
                new ChatControler(richTextBox2, ChatMessage.MsgType.Whisper, RtfColor.Purple),
                new ChatControler(richTextBox3, ChatMessage.MsgType.Party, RtfColor.Blue),
                new ChatControler(richTextBox4, ChatMessage.MsgType.Guild, RtfColor.Green),
                new ChatControler(richTextBox5, ChatMessage.MsgType.Region, RtfColor.Navy),
                new ChatControler(richTextBox6, ChatMessage.MsgType.World, RtfColor.Teal),
                new ChatControler(richTextBox7, ChatMessage.MsgType.Trade, RtfColor.Maroon),
                new ChatControler(richTextBox8, ChatMessage.MsgType.Announcement, RtfColor.Black),
                new ChatControler(richTextBox9, ChatMessage.MsgType.GameMaster, RtfColor.Black)
            };
          
        }

        private void CreateEmotions()
        {
            _emotions.Add("(:))", Resources.smile);
            _emotions.Add("(XD)", Resources.laugh);
            _emotions.Add("(fight)", Resources.fight);
            _emotions.Add("(:P)", Resources.tease);
            _emotions.Add("(:o)", Resources.shock);
            _emotions.Add("(:'()", Resources.sad);
            _emotions.Add("(unsure)", Resources.unsure);
            _emotions.Add("(angry)", Resources.angry);
            _emotions.Add("(:$)", Resources.blush);
            _emotions.Add("(:()", Resources.stare);
            _emotions.Add("(cry)", Resources.cry);
            _emotions.Add("(kiss)", Resources.kiss);
            _emotions.Add("(heart)", Resources.heart);
            _emotions.Add("(brokenheart)", Resources.brokenheart);
            _emotions.Add("(:&)", Resources.drool);
            _emotions.Add("(:X)", Resources.deny);
            _emotions.Add("(sleep)", Resources.sleep);
            _emotions.Add("(evil)", Resources.evil);
            _emotions.Add("(nosebleed)", Resources.nosebleed);
            _emotions.Add("(goodjob)", Resources.goodjob);

        }
        private void ChatManagerUI_Load(object sender, EventArgs e)
        {
            ChatManager.IsRunning = true;
        }

        void AddEmotions(ExRichTextBox richTextBox)
        {
            foreach (string emote in _emotions.Keys)
            {
                while (richTextBox.Text.Contains(emote))
                {
                    int ind = richTextBox.Text.IndexOf(emote, StringComparison.Ordinal);
                    richTextBox.Select(ind, emote.Length);
                    richTextBox.InsertImage((Image)_emotions[emote]);          
                }
            }
        }

        private void ParseWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var backgroundWorker = sender as BackgroundWorker;
            if (backgroundWorker != null)
            {
                while (!backgroundWorker.CancellationPending)
                {
                    if (!ChatManager.IsRunning)
                    {
                        if (backgroundWorker.CancellationPending)
                        {
                            break;
                        }
                        Thread.Sleep(300);
                    }
                    else
                    {
                        if (backgroundWorker.CancellationPending)
                        {
                            e.Cancel = true;
                            break;
                        }
                        while (!ChatManager.MessageData.IsEmpty)
                        {
                            if (backgroundWorker.CancellationPending)
                            {
                                e.Cancel = true;
                                break;
                            }
                            ChatMessage chat;
                            
                            if (ChatManager.MessageData.TryDequeue(out chat))
                            {
                                base.Invoke(new MethodInvoker(delegate
                                {
                                    foreach (var chatControler in _chatControlers)
                                    {
                                        if (chatControler.Type == chat.Type)
                                        {
                                            chatControler.ChatBox.AppendTextAsRtf(chat.Message, chatControler.ChatBox.Font, chatControler.Color);
                                            chatControler.ChatBox.AppendTextAsRtf(Environment.NewLine);
                                            AddEmotions(chatControler.ChatBox);
                                            chatControler.ChatBox.ScrollToBottom();
                                            //chatControler.ChatBox.SelectionStart = chatControler.ChatBox.TextLength;
                                            //chatControler.ChatBox.ScrollToCaret();
                                        }
                                    }
                                }));
                               
                            }
                        }
                        Thread.Sleep(300);
                    }
                }
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            base.Hide();
            base.OnClosing(e);
        }
        private void ChatManagerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatManager.IsRunning = false;
        }

        private void ChatManagerUI_VisibleChanged(object sender, EventArgs e)
        {
            if (base.Visible)
            {
                if (!ParseWorker.IsBusy)
                {
                    ParseWorker.RunWorkerAsync();
                }
            }
        }
    }
}
