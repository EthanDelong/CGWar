namespace CGWar
{
    partial class GameForm
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
            this.frameCollection = new System.Windows.Forms.TabControl();
            this.framePageHome = new System.Windows.Forms.TabPage();
            this.framePageRules = new System.Windows.Forms.TabPage();
            this.frameHome = new System.Windows.Forms.Panel();
            this.lblHomeTitle = new System.Windows.Forms.Label();
            this.cbRulesList = new System.Windows.Forms.ComboBox();
            this.lblRulesSelect = new System.Windows.Forms.Label();
            this.frameRules = new System.Windows.Forms.Panel();
            this.txtRulesDescription = new System.Windows.Forms.RichTextBox();
            this.btnRulesSelect = new System.Windows.Forms.Button();
            this.btnHomeSelectRules = new System.Windows.Forms.Button();
            this.btnHomeNewGame = new System.Windows.Forms.Button();
            this.btnHomeContinue = new System.Windows.Forms.Button();
            this.frameCollection.SuspendLayout();
            this.framePageHome.SuspendLayout();
            this.framePageRules.SuspendLayout();
            this.frameHome.SuspendLayout();
            this.frameRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // frameCollection
            // 
            this.frameCollection.Controls.Add(this.framePageHome);
            this.frameCollection.Controls.Add(this.framePageRules);
            this.frameCollection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameCollection.Location = new System.Drawing.Point(0, 0);
            this.frameCollection.Name = "frameCollection";
            this.frameCollection.SelectedIndex = 0;
            this.frameCollection.Size = new System.Drawing.Size(709, 413);
            this.frameCollection.TabIndex = 0;
            // 
            // framePageHome
            // 
            this.framePageHome.Controls.Add(this.frameHome);
            this.framePageHome.Location = new System.Drawing.Point(4, 22);
            this.framePageHome.Name = "framePageHome";
            this.framePageHome.Padding = new System.Windows.Forms.Padding(3);
            this.framePageHome.Size = new System.Drawing.Size(701, 387);
            this.framePageHome.TabIndex = 0;
            this.framePageHome.Text = "Home Frame";
            this.framePageHome.UseVisualStyleBackColor = true;
            // 
            // framePageRules
            // 
            this.framePageRules.Controls.Add(this.frameRules);
            this.framePageRules.Location = new System.Drawing.Point(4, 22);
            this.framePageRules.Name = "framePageRules";
            this.framePageRules.Padding = new System.Windows.Forms.Padding(3);
            this.framePageRules.Size = new System.Drawing.Size(701, 387);
            this.framePageRules.TabIndex = 1;
            this.framePageRules.Text = "Rules Frame";
            this.framePageRules.UseVisualStyleBackColor = true;
            // 
            // frameHome
            // 
            this.frameHome.Controls.Add(this.btnHomeContinue);
            this.frameHome.Controls.Add(this.btnHomeNewGame);
            this.frameHome.Controls.Add(this.btnHomeSelectRules);
            this.frameHome.Controls.Add(this.lblHomeTitle);
            this.frameHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameHome.Location = new System.Drawing.Point(3, 3);
            this.frameHome.Name = "frameHome";
            this.frameHome.Size = new System.Drawing.Size(695, 381);
            this.frameHome.TabIndex = 0;
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeTitle.Location = new System.Drawing.Point(262, 84);
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(158, 37);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "War.NET";
            // 
            // cbRulesList
            // 
            this.cbRulesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRulesList.FormattingEnabled = true;
            this.cbRulesList.Location = new System.Drawing.Point(81, 12);
            this.cbRulesList.Name = "cbRulesList";
            this.cbRulesList.Size = new System.Drawing.Size(121, 21);
            this.cbRulesList.TabIndex = 0;
            // 
            // lblRulesSelect
            // 
            this.lblRulesSelect.AutoSize = true;
            this.lblRulesSelect.Location = new System.Drawing.Point(5, 15);
            this.lblRulesSelect.Name = "lblRulesSelect";
            this.lblRulesSelect.Size = new System.Drawing.Size(70, 13);
            this.lblRulesSelect.TabIndex = 1;
            this.lblRulesSelect.Text = "Select Rules:";
            // 
            // frameRules
            // 
            this.frameRules.Controls.Add(this.btnRulesSelect);
            this.frameRules.Controls.Add(this.txtRulesDescription);
            this.frameRules.Controls.Add(this.cbRulesList);
            this.frameRules.Controls.Add(this.lblRulesSelect);
            this.frameRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frameRules.Location = new System.Drawing.Point(3, 3);
            this.frameRules.Name = "frameRules";
            this.frameRules.Size = new System.Drawing.Size(695, 381);
            this.frameRules.TabIndex = 2;
            // 
            // txtRulesDescription
            // 
            this.txtRulesDescription.Location = new System.Drawing.Point(8, 39);
            this.txtRulesDescription.Name = "txtRulesDescription";
            this.txtRulesDescription.Size = new System.Drawing.Size(682, 309);
            this.txtRulesDescription.TabIndex = 2;
            this.txtRulesDescription.Text = "Standard Rules";
            // 
            // btnRulesSelect
            // 
            this.btnRulesSelect.Location = new System.Drawing.Point(296, 353);
            this.btnRulesSelect.Name = "btnRulesSelect";
            this.btnRulesSelect.Size = new System.Drawing.Size(97, 23);
            this.btnRulesSelect.TabIndex = 3;
            this.btnRulesSelect.Text = "Select Rules";
            this.btnRulesSelect.UseVisualStyleBackColor = true;
            // 
            // btnHomeSelectRules
            // 
            this.btnHomeSelectRules.Location = new System.Drawing.Point(398, 194);
            this.btnHomeSelectRules.Name = "btnHomeSelectRules";
            this.btnHomeSelectRules.Size = new System.Drawing.Size(108, 31);
            this.btnHomeSelectRules.TabIndex = 1;
            this.btnHomeSelectRules.Text = "Select Rules";
            this.btnHomeSelectRules.UseVisualStyleBackColor = true;
            // 
            // btnHomeNewGame
            // 
            this.btnHomeNewGame.Location = new System.Drawing.Point(170, 194);
            this.btnHomeNewGame.Name = "btnHomeNewGame";
            this.btnHomeNewGame.Size = new System.Drawing.Size(108, 31);
            this.btnHomeNewGame.TabIndex = 2;
            this.btnHomeNewGame.Text = "New Game";
            this.btnHomeNewGame.UseVisualStyleBackColor = true;
            // 
            // btnHomeContinue
            // 
            this.btnHomeContinue.Enabled = false;
            this.btnHomeContinue.Location = new System.Drawing.Point(284, 194);
            this.btnHomeContinue.Name = "btnHomeContinue";
            this.btnHomeContinue.Size = new System.Drawing.Size(108, 31);
            this.btnHomeContinue.TabIndex = 3;
            this.btnHomeContinue.Text = "Continue";
            this.btnHomeContinue.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 413);
            this.Controls.Add(this.frameCollection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "War.NET - Home";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.frameCollection.ResumeLayout(false);
            this.framePageHome.ResumeLayout(false);
            this.framePageRules.ResumeLayout(false);
            this.frameHome.ResumeLayout(false);
            this.frameHome.PerformLayout();
            this.frameRules.ResumeLayout(false);
            this.frameRules.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl frameCollection;
        private System.Windows.Forms.TabPage framePageHome;
        private System.Windows.Forms.Panel frameHome;
        private System.Windows.Forms.Label lblHomeTitle;
        private System.Windows.Forms.TabPage framePageRules;
        private System.Windows.Forms.Label lblRulesSelect;
        private System.Windows.Forms.ComboBox cbRulesList;
        private System.Windows.Forms.Panel frameRules;
        private System.Windows.Forms.RichTextBox txtRulesDescription;
        private System.Windows.Forms.Button btnRulesSelect;
        private System.Windows.Forms.Button btnHomeContinue;
        private System.Windows.Forms.Button btnHomeNewGame;
        private System.Windows.Forms.Button btnHomeSelectRules;
    }
}

