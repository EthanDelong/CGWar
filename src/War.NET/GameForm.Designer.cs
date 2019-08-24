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
            this.HomeButtonSettings = new System.Windows.Forms.Button();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.framePageRules = new System.Windows.Forms.TabPage();
            this.RulesFrame = new System.Windows.Forms.Panel();
            this.RulesButtonSave = new System.Windows.Forms.Button();
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
            this.frameCollection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frameCollection.Name = "frameCollection";
            this.frameCollection.SelectedIndex = 0;
            this.frameCollection.Size = new System.Drawing.Size(1064, 635);
            this.frameCollection.TabIndex = 0;
            // 
            // framePageHome
            // 
            this.framePageHome.Controls.Add(this.HomeFrame);
            this.framePageHome.Location = new System.Drawing.Point(4, 29);
            this.framePageHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.framePageHome.Name = "framePageHome";
            this.framePageHome.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.framePageHome.Size = new System.Drawing.Size(1056, 602);
            this.framePageHome.TabIndex = 0;
            this.framePageHome.Text = "Home Frame";
            this.framePageHome.UseVisualStyleBackColor = true;
            // 
            // HomeFrame
            // 
            this.HomeFrame.Controls.Add(this.HomeButtonContinue);
            this.HomeFrame.Controls.Add(this.HomeButtonNewGame);
            this.HomeFrame.Controls.Add(this.HomeButtonSettings);
            this.HomeFrame.Controls.Add(this.HomeTitle);
            this.HomeFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeFrame.Location = new System.Drawing.Point(4, 5);
            this.HomeFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeFrame.Name = "HomeFrame";
            this.HomeFrame.Size = new System.Drawing.Size(1048, 592);
            this.HomeFrame.TabIndex = 0;
            // 
            // HomeButtonContinue
            // 
            this.HomeButtonContinue.Enabled = false;
            this.HomeButtonContinue.Location = new System.Drawing.Point(427, 351);
            this.HomeButtonContinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeButtonContinue.Name = "HomeButtonContinue";
            this.HomeButtonContinue.Size = new System.Drawing.Size(162, 50);
            this.HomeButtonContinue.TabIndex = 3;
            this.HomeButtonContinue.Text = "Continue";
            this.HomeButtonContinue.UseVisualStyleBackColor = true;
            // 
            // HomeButtonNewGame
            // 
            this.HomeButtonNewGame.Location = new System.Drawing.Point(256, 351);
            this.HomeButtonNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeButtonNewGame.Name = "HomeButtonNewGame";
            this.HomeButtonNewGame.Size = new System.Drawing.Size(162, 50);
            this.HomeButtonNewGame.TabIndex = 2;
            this.HomeButtonNewGame.Text = "New Game";
            this.HomeButtonNewGame.UseVisualStyleBackColor = true;
            // 
            // HomeButtonSettings
            // 
            this.HomeButtonSettings.Location = new System.Drawing.Point(598, 351);
            this.HomeButtonSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeButtonSettings.Name = "HomeButtonSettings";
            this.HomeButtonSettings.Size = new System.Drawing.Size(162, 50);
            this.HomeButtonSettings.TabIndex = 1;
            this.HomeButtonSettings.Text = "Settings";
            this.HomeButtonSettings.UseVisualStyleBackColor = true;
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(394, 182);
            this.HomeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(228, 55);
            this.HomeTitle.TabIndex = 0;
            this.HomeTitle.Text = "War.NET";
            // 
            // framePageRules
            // 
            this.framePageRules.Controls.Add(this.RulesFrame);
            this.framePageRules.Location = new System.Drawing.Point(4, 29);
            this.framePageRules.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.framePageRules.Name = "framePageRules";
            this.framePageRules.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.framePageRules.Size = new System.Drawing.Size(1056, 602);
            this.framePageRules.TabIndex = 1;
            this.framePageRules.Text = "Rules Frame";
            this.framePageRules.UseVisualStyleBackColor = true;
            // 
            // RulesFrame
            // 
            this.RulesFrame.Controls.Add(this.RulesButtonSave);
            this.RulesFrame.Controls.Add(this.RulesTextDescription);
            this.RulesFrame.Controls.Add(this.RulesList);
            this.RulesFrame.Controls.Add(this.RulesListLabel);
            this.RulesFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RulesFrame.Location = new System.Drawing.Point(4, 5);
            this.RulesFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesFrame.Name = "RulesFrame";
            this.RulesFrame.Size = new System.Drawing.Size(1048, 592);
            this.RulesFrame.TabIndex = 2;
            // 
            // RulesButtonSave
            // 
            this.RulesButtonSave.Location = new System.Drawing.Point(453, 546);
            this.RulesButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesButtonSave.Name = "RulesButtonSave";
            this.RulesButtonSave.Size = new System.Drawing.Size(146, 50);
            this.RulesButtonSave.TabIndex = 3;
            this.RulesButtonSave.Text = "Save Settings";
            this.RulesButtonSave.UseVisualStyleBackColor = true;
            // 
            // RulesTextDescription
            // 
            this.RulesTextDescription.Location = new System.Drawing.Point(12, 60);
            this.RulesTextDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesTextDescription.Name = "RulesTextDescription";
            this.RulesTextDescription.Size = new System.Drawing.Size(1021, 479);
            this.RulesTextDescription.TabIndex = 2;
            this.RulesTextDescription.Text = "Standard Rules";
            // 
            // RulesList
            // 
            this.RulesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RulesList.FormattingEnabled = true;
            this.RulesList.Location = new System.Drawing.Point(122, 18);
            this.RulesList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RulesList.Name = "RulesList";
            this.RulesList.Size = new System.Drawing.Size(180, 28);
            this.RulesList.TabIndex = 0;
            // 
            // RulesListLabel
            // 
            this.RulesListLabel.AutoSize = true;
            this.RulesListLabel.Location = new System.Drawing.Point(8, 23);
            this.RulesListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RulesListLabel.Name = "RulesListLabel";
            this.RulesListLabel.Size = new System.Drawing.Size(103, 20);
            this.RulesListLabel.TabIndex = 1;
            this.RulesListLabel.Text = "Select Rules:";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 635);
            this.Controls.Add(this.frameCollection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button RulesButtonSave;
        private System.Windows.Forms.Button HomeButtonContinue;
        private System.Windows.Forms.Button HomeButtonNewGame;
        private System.Windows.Forms.Button HomeButtonSettings;
    }
}

