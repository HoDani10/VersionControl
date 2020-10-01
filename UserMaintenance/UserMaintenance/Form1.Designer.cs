namespace UserMaintenance
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.textboxFirstname = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttoniras = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(12, 12);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(243, 420);
            this.listUsers.TabIndex = 0;
            // 
            // textboxFirstname
            // 
            this.textboxFirstname.Location = new System.Drawing.Point(409, 37);
            this.textboxFirstname.Name = "textboxFirstname";
            this.textboxFirstname.Size = new System.Drawing.Size(153, 20);
            this.textboxFirstname.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(324, 40);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(35, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "label1";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(306, 146);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(255, 35);
            this.ButtonAdd.TabIndex = 5;
            this.ButtonAdd.Text = "button1";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(324, 90);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(35, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "label1";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(408, 90);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(153, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // buttoniras
            // 
            this.buttoniras.Location = new System.Drawing.Point(306, 257);
            this.buttoniras.Name = "buttoniras";
            this.buttoniras.Size = new System.Drawing.Size(255, 35);
            this.buttoniras.TabIndex = 8;
            this.buttoniras.Text = "button1";
            this.buttoniras.UseVisualStyleBackColor = true;
            this.buttoniras.Click += new System.EventHandler(this.buttoniras_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Location = new System.Drawing.Point(329, 339);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(151, 32);
            this.buttonTorles.TabIndex = 9;
            this.buttonTorles.Text = "button1";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttoniras);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textboxFirstname);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.TextBox textboxFirstname;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttoniras;
        private System.Windows.Forms.Button buttonTorles;
    }
}

