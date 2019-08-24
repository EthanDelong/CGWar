namespace WarNET
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
            this.HomeFrame = new System.Windows.Forms.Panel();
            this.HomeButtonContinue = new System.Windows.Forms.Button();
            this.HomeButtonNewGame = new System.Windows.Forms.Button();
            this.HomeButtonSelectRules = new System.Windows.Forms.Button();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.framePageRules = new System.Windows.Forms.TabPage();
            this.RulesFrame = new System.Windows.Forms.Panel();
            this.RulesButtonSelect = new System.Windows.Forms.Button();
            this.RulesTextDescription = new System.Windows.Forms.RichTextBox();
            this.RulesList = new System.Windows.Forms.ComboBox();
            this.RulesListLabel = new System.Windows.Forms.Label();
            this.frameCollection.SuspendLayout();
            this.framePageHome.SuspendLayout();
            this.HomeFrame.SuspendLayout();
            this.framePageRules.SuspendLayout();
            this.RulesFrame.SuspendLayout();
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
            this.framePageHome.Controls.Add(this.HomeFrame);
            this.framePageHome.Location = new System.Drawing.Point(4, 22);
            this.framePageHome.Name = "framePageHome";
            this.framePageHome.Padding = new System.Windows.Forms.Padding(3);
            this.framePageHome.Size = new System.Drawing.Size(701, 387);
            this.framePageHome.TabIndex = 0;
            this.framePageHome.Text = "Home Frame";
            this.framePageHome.UseVisualStyleBackColor = true;
            // 
            // HomeFrame
            // 
            this.HomeFrame.Controls.Add(this.HomeButtonContinue);
            this.HomeFrame.Controls.Add(this.HomeButtonNewGame);
            this.HomeFrame.Controls.Add(this.HomeButtonSelectRules);
            this.HomeFrame.Controls.Add(this.HomeTitle);
            this.HomeFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeFrame.Location = new System.Drawing.Point(3, 3);
            this.HomeFrame.Name = "HomeFrame";
            this.HomeFrame.Size = new System.Drawing.Size(695, 381);
            this.HomeFrame.TabIndex = 0;
            // 
            // HomeButtonContinue
            // 
            this.HomeButtonContinue.Enabled = false;
            this.HomeButtonContinue.Location = new System.Drawing.Point(284, 194);
            this.HomeButtonContinue.Name = "HomeButtonContinue";
            this.HomeButtonContinue.Size = new System.Drawing.Size(108, 31);
            this.HomeButtonContinue.TabIndex = 3;
            this.HomeButtonContinue.Text = "Continue";
            this.HomeButtonContinue.UseVisualStyleBackColor = true;
            this.HomeButtonContinue.Click += new System.EventHandler(this.HomeButtonContinue_Click);
            // 
            // HomeButtonNewGame
            // 
            this.HomeButtonNewGame.Location = new System.Drawing.Point(170, 194);
            this.HomeButtonNewGame.Name = "HomeButtonNewGame";
            this.HomeButtonNewGame.Size = new System.Drawing.Size(108, 31);
            this.HomeButtonNewGame.TabIndex = 2;
            this.HomeButtonNewGame.Text = "New Game";
            this.HomeButtonNewGame.UseVisualStyleBackColor = true;
            this.HomeButtonNewGame.Click += new System.EventHandler(this.HomeButtonNewGame_Click);
            // 
            // HomeButtonSelectRules
            // 
            this.HomeButtonSelectRules.Location = new System.Drawing.Point(398, 194);
            this.HomeButtonSelectRules.Name = "HomeButtonSelectRules";
            this.HomeButtonSelectRules.Size = new System.Drawing.Size(108, 31);
            this.HomeButtonSelectRules.TabIndex = 1;
            this.HomeButtonSelectRules.Text = "Select Rules";
            this.HomeButtonSelectRules.UseVisualStyleBackColor = true;
            this.HomeButtonSelectRules.Click += new System.EventHandler(this.HomeButtonSelectRules_Click);
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(262, 84);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(158, 37);
            this.HomeTitle.TabIndex = 0;
            this.HomeTitle.Text = "War.NET";
            // 
            // framePageRules
            // 
            this.framePageRules.Controls.Add(this.RulesFrame);
            this.framePageRules.Location = new System.Drawing.Point(4, 22);
            this.framePageRules.Name = "framePageRules";
            this.framePageRules.Padding = new System.Windows.Forms.Padding(3);
            this.framePageRules.Size = new System.Drawing.Size(701, 387);
            this.framePageRules.TabIndex = 1;
            this.framePageRules.Text = "Rules Frame";
            this.framePageRules.UseVisualStyleBackColor = true;
            // 
            // RulesFrame
            // 
            this.RulesFrame.Controls.Add(this.RulesButtonSelect);
            this.RulesFrame.Controls.Add(this.RulesTextDescription);
            this.RulesFrame.Controls.Add(this.RulesList);
            this.RulesFrame.Controls.Add(this.RulesListLabel);
            this.RulesFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RulesFrame.Location = new System.Drawing.Point(3, 3);
            this.RulesFrame.Name = "RulesFrame";
            this.RulesFrame.Size = new System.Drawing.Size(695, 381);
            this.RulesFrame.TabIndex = 2;
            // 
            // RulesButtonSelect
            // 
            this.RulesButtonSelect.Location = new System.Drawing.Point(302, 355);
            this.RulesButtonSelect.Name = "RulesButtonSelect";
            this.RulesButtonSelect.Size = new System.Drawing.Size(97, 23);
            this.RulesButtonSelect.TabIndex = 3;
            this.RulesButtonSelect.Text = "Select Rules";
            this.RulesButtonSelect.UseVisualStyleBackColor = true;
            this.RulesButtonSelect.Click += new System.EventHandler(this.RulesSelectButton_Click);
            // 
            // RulesTextDescription
            // 
            this.RulesTextDescription.Location = new System.Drawing.Point(8, 39);
            this.RulesTextDescription.Name = "RulesTextDescription";
            this.RulesTextDescription.Size = new System.Drawing.Size(682, 313);
            this.RulesTextDescription.TabIndex = 2;
            this.RulesTextDescription.Text = "Standard Rules";
            // 
            // RulesList
            // 
            this.RulesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RulesList.FormattingEnabled = true;
            this.RulesList.Location = new System.Drawing.Point(81, 12);
            this.RulesList.Name = "RulesList";
            this.RulesList.Size = new System.Drawing.Size(121, 21);
            this.RulesList.TabIndex = 0;
            // 
            // RulesListLabel
            // 
            this.RulesListLabel.AutoSize = true;
            this.RulesListLabel.Location = new System.Drawing.Point(5, 15);
            this.RulesListLabel.Name = "RulesListLabel";
            this.RulesListLabel.Size = new System.Drawing.Size(70, 13);
            this.RulesListLabel.TabIndex = 1;
            this.RulesListLabel.Text = "Select Rules:";
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
            this.HomeFrame.ResumeLayout(false);
            this.HomeFrame.PerformLayout();
            this.framePageRules.ResumeLayout(false);
            this.RulesFrame.ResumeLayout(false);
            this.RulesFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl frameCollection;
        private System.Windows.Forms.TabPage framePageHome;
        private System.Windows.Forms.Panel HomeFrame;
        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.TabPage framePageRules;
        private System.Windows.Forms.Label RulesListLabel;
        private System.Windows.Forms.ComboBox RulesList;
        private System.Windows.Forms.Panel RulesFrame;
        private System.Windows.Forms.RichTextBox RulesTextDescription;
        private System.Windows.Forms.Button RulesButtonSelect;
        private System.Windows.Forms.Button HomeButtonContinue;
        private System.Windows.Forms.Button HomeButtonNewGame;
        private System.Windows.Forms.Button HomeButtonSelectRules;
    }
}

