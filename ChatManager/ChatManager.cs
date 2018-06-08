using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PluginsCommon;

namespace ChatManager
{
    public class ChatManager : IPlugin, IPluginChat
    {
        private ChatManagerUI _gui;
        private Thread _guiManager;
        public static bool IsRunning;
        public static readonly ConcurrentQueue<ChatMessage> MessageData = new ConcurrentQueue<ChatMessage>();
        public void OnChatMessage(string message, uint type, bool isWhisper)
        {
            if (IsRunning)
            {
                if (type == 0u)
                {
                   MessageData.Enqueue(new ChatMessage(message,ChatMessage.MsgType.General));
                }
                else if (type == 1u)
                {
                    MessageData.Enqueue(new ChatMessage(message, ChatMessage.MsgType.Whisper));
                }
                else if (type == 2u)
                {
                    MessageData.Enqueue(new ChatMessage(message, ChatMessage.MsgType.Party));
                }
                else if (type == 3u)
                {
                    MessageData.Enqueue(new ChatMessage(message, ChatMessage.MsgType.Guild));
                }
                else if (type == 4u)
                {
                    MessageData.Enqueue(new ChatMessage(message, ChatMessage.MsgType.Region));
                }
                else if (type == 5u || type == 17u)
                {
                    MessageData.Enqueue(new ChatMessage(message, ChatMessage.MsgType.World));
                }
                else if (type == 7u)
                {
                    MessageData.Enqueue(new ChatMessage(message, ChatMessage.MsgType.Trade));
                }
                else if (type == 18u)
                {
                    MessageData.Enqueue(new ChatMessage(message, ChatMessage.MsgType.Announcement));
                }
                else if (type == 19u)
                {
                    MessageData.Enqueue(new ChatMessage(message, ChatMessage.MsgType.GameMaster));
                }
            }
        }

        public string Author
        {
            get { return "LayerSlayer"; }
        }

        public string Description
        {
            get { return "Logs your ingame chat"; }
        }

        public string Name
        {
            get { return "Chat Manager"; }
        }

        public void OnButtonClick()
        {
            if (_guiManager == null || _guiManager.ThreadState == ThreadState.Unstarted ||
                _guiManager.ThreadState == ThreadState.Aborted || _guiManager.ThreadState == ThreadState.Stopped)
            {
                _guiManager = new Thread(_guiManagment);
                _guiManager.SetApartmentState(ApartmentState.STA);
                _guiManager.Start();
            }
            else if (_gui != null)
            {
                _gui.Invoke(new MethodInvoker(() => _gui.Close()));
            }
        }

        private void _guiManagment()
        {
            if (_gui == null)
            {
                _gui = new ChatManagerUI();
            }
            _gui.ShowDialog();  
        }

        public void OnStart()
        {
            
        }

        public void OnStop(bool off)
        {
            try
            {
                if (_gui.InvokeRequired)
                {
                    _gui.Invoke(new MethodInvoker(delegate
                    {
                        if (_gui.ParseWorker.IsBusy)
                        {
                            _gui.ParseWorker.CancelAsync();
                        }
                        _gui.Close();
                    }));
                }
                else
                {
                    if (_gui.ParseWorker.IsBusy)
                    {
                        _gui.ParseWorker.CancelAsync();
                    }
                    _gui.Close();
                } 
            }
            catch (Exception)
            {
               
                
            }
        }

        public void Pulse()
        {
           
        }

        public Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }
    }
}
