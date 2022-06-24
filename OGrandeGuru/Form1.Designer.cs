namespace OGrandeGuru
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
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(12, 147);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 25);
            this.lblResposta.TabIndex = 0;
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPergunta
            // 
            this.txtPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPergunta.Location = new System.Drawing.Point(12, 14);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(607, 31);
            this.txtPergunta.TabIndex = 1;
            this.txtPergunta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPergunta_KeyDown);
            this.txtPergunta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPergunta_KeyPress);
            // 
            // btnResponder
            // 
            this.btnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.Location = new System.Drawing.Point(12, 55);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(607, 78);
            this.btnResponder.TabIndex = 2;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = true;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 233);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.lblResposta);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 271);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(647, 271);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O Grande GURU!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Button btnResponder;
    }
}

