using System;

namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.rtb_Client = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtb_Client
            // 
            this.rtb_Client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Client.Location = new System.Drawing.Point(0, 0);
            this.rtb_Client.Name = "rtb_Client";
            this.rtb_Client.Size = new System.Drawing.Size(584, 361);
            this.rtb_Client.TabIndex = 0;
            this.rtb_Client.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.rtb_Client);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        #region Client code

        private string myMessage = "";
        private System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();
        private System.Net.IPEndPoint serverEndPoint = new System.Net.IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 3000);

        private void Rtb_ClientKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyData != System.Windows.Forms.Keys.Enter || e.KeyData != System.Windows.Forms.Keys.Return)
            {
                myMessage += (char)e.KeyValue;
            }
            else
            {
                SendMessage(myMessage);
                myMessage = "";
            }
        }

        private void SendMessage(string msg)
        {
            System.Net.Sockets.NetworkStream clientstream = client.GetStream();

            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(msg);

            clientstream.Write(buffer, 0, buffer.Length);
            clientstream.Flush();

            Byte[] data = new Byte[256];

            String responseData = String.Empty;

            Int32 bytes = clientstream.Read(data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);

            rtb_Client.AppendText(System.Environment.NewLine + "From Server: " + responseData);
        }
        #endregion

        private System.Windows.Forms.RichTextBox rtb_Client;
    }
}

