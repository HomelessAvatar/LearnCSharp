namespace Server
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Declerations
        /// </summary>
        private System.Net.Sockets.TcpListener tcplistener;
        private System.Threading.Thread listenThread;
        private int connectedClients = 0;
        private delegate void WriteMessageDelegate(string msg);

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label_conlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_noofcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtb_Server = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_conlabel,
            this.label_noofcon});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "server_status";
            // 
            // label_conlabel
            // 
            this.label_conlabel.Name = "label_conlabel";
            this.label_conlabel.Size = new System.Drawing.Size(136, 17);
            this.label_conlabel.Text = "Number of connections:";
            // 
            // label_noofcon
            // 
            this.label_noofcon.Name = "label_noofcon";
            this.label_noofcon.Size = new System.Drawing.Size(13, 17);
            this.label_noofcon.Text = "0";
            // 
            // rtb_Server
            // 
            this.rtb_Server.BackColor = System.Drawing.SystemColors.Window;
            this.rtb_Server.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Server.Location = new System.Drawing.Point(0, 0);
            this.rtb_Server.Name = "rtb_Server";
            this.rtb_Server.Size = new System.Drawing.Size(584, 339);
            this.rtb_Server.TabIndex = 2;
            this.rtb_Server.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.rtb_Server);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Server";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Server Code

        /// <summary>
        /// Server client listener. Waits until a client is connected.
        /// </summary>

        private void Server()
        {
            this.tcplistener = new System.Net.Sockets.TcpListener(System.Net.IPAddress.Loopback, 3000);
            this.listenThread = new System.Threading.Thread(new System.Threading.ThreadStart(ListenforClients));
            this.listenThread.Start();
        }

        /// <summary>
        /// Listening for clients code.
        /// </summary>
        private void ListenforClients()
        {
            this.tcplistener.Start();

            while (true) // does not stop until the Server is closed.
            {
                System.Net.Sockets.TcpClient client = this.tcplistener.AcceptTcpClient();

                connectedClients++;
                label_noofcon.Text = connectedClients.ToString();

                System.Threading.Thread clientThread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        /// <summary>
        /// Handling communications.
        /// </summary>
        private void HandleClientComm(object client)
        {
            System.Net.Sockets.TcpClient tcpclient = (System.Net.Sockets.TcpClient)client;
            System.Net.Sockets.NetworkStream clientStream = tcpclient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while(true)
            {
                bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    break;
                }

                if (bytesRead == 0)
                {
                    connectedClients--;
                    label_noofcon.Text = connectedClients.ToString();
                    break;
                }

                System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();

                string msg = encoder.GetString(message, 0, bytesRead);
                WriteMessage(msg);

                Echo(msg, encoder, clientStream);
            }

            tcpclient.Close();
        }

        /// <summary>
        /// Message writer.
        /// </summary>
        private void WriteMessage(string msg)
        {
            if (this.rtb_Server.InvokeRequired)
            {
                WriteMessageDelegate d = new WriteMessageDelegate(WriteMessage);
                this.rtb_Server.Invoke(d, new object[] { msg });
            }
            else
            {
                this.rtb_Server.AppendText(msg + System.Environment.NewLine);
            }
        }

        /// <summary> 
        /// Echo the message back to the sending client 
        /// </summary> 
        /// <param name="msg"> 
        /// String: The Message to send back 
        /// </param> 
        /// <param name="encoder"> 
        /// Our ASCIIEncoder 
        /// </param> 
        /// <param name="clientStream"> 
        /// The Client to communicate with 
        /// </param>
        private void Echo(string msg, System.Text.ASCIIEncoding encoder, System.Net.Sockets.NetworkStream clientstream)
        {
            byte[] buffer = encoder.GetBytes(msg);

            clientstream.Write(buffer, 0, buffer.Length);
            clientstream.Flush();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel label_conlabel;
        private System.Windows.Forms.ToolStripStatusLabel label_noofcon;
        private System.Windows.Forms.RichTextBox rtb_Server;
    }
}

