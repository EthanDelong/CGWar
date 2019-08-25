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
            this.framePageNewGame = new System.Windows.Forms.TabPage();
            this.NewGameFrame = new System.Windows.Forms.Panel();
            this.NewGameButtonCancel = new System.Windows.Forms.Button();
            this.NewGameBoxCut = new System.Windows.Forms.GroupBox();
            this.NewGameDeckCutSlider = new System.Windows.Forms.TrackBar();
            this.NewGameBoxShuffle = new System.Windows.Forms.GroupBox();
            this.NewGameDeckShuffleSlider = new System.Windows.Forms.TrackBar();
            this.NewGameLabelOpponent = new System.Windows.Forms.Label();
            this.NewGameButtonStart = new System.Windows.Forms.Button();
            this.NewGameLabelName = new System.Windows.Forms.Label();
            this.NewGameTextName = new System.Windows.Forms.TextBox();
            this.NewGameTextOpponent = new System.Windows.Forms.TextBox();
            this.framePagePlay = new System.Windows.Forms.TabPage();
            this.PlayFrame = new System.Windows.Forms.Panel();
            this.PlayFrameLabelRoundCount = new System.Windows.Forms.Label();
            this.PlayFrameLabelRound = new System.Windows.Forms.Label();
            this.PlayFrameButtonPlay = new System.Windows.Forms.Button();
            this.PlayFrameOpponentCard = new System.Windows.Forms.Panel();
            this.PlayFramePlayerCard = new System.Windows.Forms.Panel();
            this.PlayFrameLabelOpponentHandSize = new System.Windows.Forms.Label();
            this.PlayFrameLabelPlayerHandSize = new System.Windows.Forms.Label();
            this.PlayFrameLabelOpponentCards = new System.Windows.Forms.Label();
            this.PlayFrameLabelPlayerCards = new System.Windows.Forms.Label();
            this.PlayFrameOpponentDeck = new System.Windows.Forms.Panel();
            this.PlayFramePlayerDeck = new System.Windows.Forms.Panel();
            this.PlayFrameLabelPlayer = new System.Windows.Forms.Label();
            this.PlayFrameLabelOpponent = new System.Windows.Forms.Label();
            this.frameCollection.SuspendLayout();
            this.framePageHome.SuspendLayout();
            this.HomeFrame.SuspendLayout();
            this.framePageRules.SuspendLayout();
            this.RulesFrame.SuspendLayout();
            this.framePageNewGame.SuspendLayout();
            this.NewGameFrame.SuspendLayout();
            this.NewGameBoxCut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewGameDeckCutSlider)).BeginInit();
            this.NewGameBoxShuffle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewGameDeckShuffleSlider)).BeginInit();
            this.framePagePlay.SuspendLayout();
            this.PlayFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // frameCollection
            // 
            this.frameCollection.Controls.Add(this.framePageHome);
            this.frameCollection.Controls.Add(this.framePageRules);
            this.frameCollection.Controls.Add(this.framePageNewGame);
            this.frameCollection.Controls.Add(this.framePagePlay);
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
            this.HomeFrame.Controls.Add(this.HomeButtonSettings);
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
            this.HomeButtonContinue.Location = new System.Drawing.Point(285, 228);
            this.HomeButtonContinue.Name = "HomeButtonContinue";
            this.HomeButtonContinue.Size = new System.Drawing.Size(108, 32);
            this.HomeButtonContinue.TabIndex = 3;
            this.HomeButtonContinue.Text = "Continue";
            this.HomeButtonContinue.UseVisualStyleBackColor = true;
            // 
            // HomeButtonNewGame
            // 
            this.HomeButtonNewGame.Location = new System.Drawing.Point(171, 228);
            this.HomeButtonNewGame.Name = "HomeButtonNewGame";
            this.HomeButtonNewGame.Size = new System.Drawing.Size(108, 32);
            this.HomeButtonNewGame.TabIndex = 2;
            this.HomeButtonNewGame.Text = "New Game";
            this.HomeButtonNewGame.UseVisualStyleBackColor = true;
            // 
            // HomeButtonSettings
            // 
            this.HomeButtonSettings.Location = new System.Drawing.Point(399, 228);
            this.HomeButtonSettings.Name = "HomeButtonSettings";
            this.HomeButtonSettings.Size = new System.Drawing.Size(108, 32);
            this.HomeButtonSettings.TabIndex = 1;
            this.HomeButtonSettings.Text = "Settings";
            this.HomeButtonSettings.UseVisualStyleBackColor = true;
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(263, 118);
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
            this.RulesFrame.Controls.Add(this.RulesButtonSave);
            this.RulesFrame.Controls.Add(this.RulesTextDescription);
            this.RulesFrame.Controls.Add(this.RulesList);
            this.RulesFrame.Controls.Add(this.RulesListLabel);
            this.RulesFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RulesFrame.Location = new System.Drawing.Point(3, 3);
            this.RulesFrame.Name = "RulesFrame";
            this.RulesFrame.Size = new System.Drawing.Size(695, 381);
            this.RulesFrame.TabIndex = 2;
            // 
            // RulesButtonSave
            // 
            this.RulesButtonSave.Location = new System.Drawing.Point(302, 355);
            this.RulesButtonSave.Name = "RulesButtonSave";
            this.RulesButtonSave.Size = new System.Drawing.Size(97, 32);
            this.RulesButtonSave.TabIndex = 3;
            this.RulesButtonSave.Text = "Save Settings";
            this.RulesButtonSave.UseVisualStyleBackColor = true;
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
            // framePageNewGame
            // 
            this.framePageNewGame.Controls.Add(this.NewGameFrame);
            this.framePageNewGame.Location = new System.Drawing.Point(4, 22);
            this.framePageNewGame.Margin = new System.Windows.Forms.Padding(2);
            this.framePageNewGame.Name = "framePageNewGame";
            this.framePageNewGame.Size = new System.Drawing.Size(701, 387);
            this.framePageNewGame.TabIndex = 2;
            this.framePageNewGame.Text = "NewGame Frame";
            this.framePageNewGame.UseVisualStyleBackColor = true;
            // 
            // NewGameFrame
            // 
            this.NewGameFrame.Controls.Add(this.NewGameButtonCancel);
            this.NewGameFrame.Controls.Add(this.NewGameBoxCut);
            this.NewGameFrame.Controls.Add(this.NewGameBoxShuffle);
            this.NewGameFrame.Controls.Add(this.NewGameLabelOpponent);
            this.NewGameFrame.Controls.Add(this.NewGameButtonStart);
            this.NewGameFrame.Controls.Add(this.NewGameLabelName);
            this.NewGameFrame.Controls.Add(this.NewGameTextName);
            this.NewGameFrame.Controls.Add(this.NewGameTextOpponent);
            this.NewGameFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameFrame.Location = new System.Drawing.Point(0, 0);
            this.NewGameFrame.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameFrame.Name = "NewGameFrame";
            this.NewGameFrame.Size = new System.Drawing.Size(701, 387);
            this.NewGameFrame.TabIndex = 0;
            // 
            // NewGameButtonCancel
            // 
            this.NewGameButtonCancel.Location = new System.Drawing.Point(345, 274);
            this.NewGameButtonCancel.Name = "NewGameButtonCancel";
            this.NewGameButtonCancel.Size = new System.Drawing.Size(108, 32);
            this.NewGameButtonCancel.TabIndex = 12;
            this.NewGameButtonCancel.Text = "Cancel";
            this.NewGameButtonCancel.UseVisualStyleBackColor = true;
            // 
            // NewGameBoxCut
            // 
            this.NewGameBoxCut.Controls.Add(this.NewGameDeckCutSlider);
            this.NewGameBoxCut.Location = new System.Drawing.Point(175, 205);
            this.NewGameBoxCut.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameBoxCut.Name = "NewGameBoxCut";
            this.NewGameBoxCut.Padding = new System.Windows.Forms.Padding(2);
            this.NewGameBoxCut.Size = new System.Drawing.Size(336, 43);
            this.NewGameBoxCut.TabIndex = 11;
            this.NewGameBoxCut.TabStop = false;
            this.NewGameBoxCut.Text = "Cut Deck At: 0";
            // 
            // NewGameDeckCutSlider
            // 
            this.NewGameDeckCutSlider.AutoSize = false;
            this.NewGameDeckCutSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameDeckCutSlider.Location = new System.Drawing.Point(2, 15);
            this.NewGameDeckCutSlider.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameDeckCutSlider.Name = "NewGameDeckCutSlider";
            this.NewGameDeckCutSlider.Size = new System.Drawing.Size(332, 26);
            this.NewGameDeckCutSlider.TabIndex = 3;
            this.NewGameDeckCutSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // NewGameBoxShuffle
            // 
            this.NewGameBoxShuffle.Controls.Add(this.NewGameDeckShuffleSlider);
            this.NewGameBoxShuffle.Location = new System.Drawing.Point(175, 137);
            this.NewGameBoxShuffle.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameBoxShuffle.Name = "NewGameBoxShuffle";
            this.NewGameBoxShuffle.Padding = new System.Windows.Forms.Padding(2);
            this.NewGameBoxShuffle.Size = new System.Drawing.Size(336, 43);
            this.NewGameBoxShuffle.TabIndex = 10;
            this.NewGameBoxShuffle.TabStop = false;
            this.NewGameBoxShuffle.Text = "Shuffle Count: 0";
            // 
            // NewGameDeckShuffleSlider
            // 
            this.NewGameDeckShuffleSlider.AutoSize = false;
            this.NewGameDeckShuffleSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameDeckShuffleSlider.Location = new System.Drawing.Point(2, 15);
            this.NewGameDeckShuffleSlider.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameDeckShuffleSlider.Name = "NewGameDeckShuffleSlider";
            this.NewGameDeckShuffleSlider.Size = new System.Drawing.Size(332, 26);
            this.NewGameDeckShuffleSlider.TabIndex = 2;
            this.NewGameDeckShuffleSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // NewGameLabelOpponent
            // 
            this.NewGameLabelOpponent.AutoSize = true;
            this.NewGameLabelOpponent.Location = new System.Drawing.Point(172, 103);
            this.NewGameLabelOpponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewGameLabelOpponent.Name = "NewGameLabelOpponent";
            this.NewGameLabelOpponent.Size = new System.Drawing.Size(57, 13);
            this.NewGameLabelOpponent.TabIndex = 9;
            this.NewGameLabelOpponent.Text = "Opponent:";
            // 
            // NewGameButtonStart
            // 
            this.NewGameButtonStart.Location = new System.Drawing.Point(232, 274);
            this.NewGameButtonStart.Name = "NewGameButtonStart";
            this.NewGameButtonStart.Size = new System.Drawing.Size(108, 32);
            this.NewGameButtonStart.TabIndex = 8;
            this.NewGameButtonStart.Text = "Start Game";
            this.NewGameButtonStart.UseVisualStyleBackColor = true;
            // 
            // NewGameLabelName
            // 
            this.NewGameLabelName.AutoSize = true;
            this.NewGameLabelName.Location = new System.Drawing.Point(191, 69);
            this.NewGameLabelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewGameLabelName.Name = "NewGameLabelName";
            this.NewGameLabelName.Size = new System.Drawing.Size(38, 13);
            this.NewGameLabelName.TabIndex = 7;
            this.NewGameLabelName.Text = "Name:";
            // 
            // NewGameTextName
            // 
            this.NewGameTextName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GamePlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NewGameTextName.Location = new System.Drawing.Point(232, 67);
            this.NewGameTextName.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameTextName.Name = "NewGameTextName";
            this.NewGameTextName.Size = new System.Drawing.Size(280, 20);
            this.NewGameTextName.TabIndex = 5;
            this.NewGameTextName.Text = global::WarNET.Properties.Settings.Default.GamePlayerName;
            // 
            // NewGameTextOpponent
            // 
            this.NewGameTextOpponent.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GameOpponentName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NewGameTextOpponent.Location = new System.Drawing.Point(232, 101);
            this.NewGameTextOpponent.Margin = new System.Windows.Forms.Padding(2);
            this.NewGameTextOpponent.Name = "NewGameTextOpponent";
            this.NewGameTextOpponent.Size = new System.Drawing.Size(280, 20);
            this.NewGameTextOpponent.TabIndex = 6;
            this.NewGameTextOpponent.Text = global::WarNET.Properties.Settings.Default.GameOpponentName;
            // 
            // framePagePlay
            // 
            this.framePagePlay.Controls.Add(this.PlayFrame);
            this.framePagePlay.Location = new System.Drawing.Point(4, 22);
            this.framePagePlay.Margin = new System.Windows.Forms.Padding(2);
            this.framePagePlay.Name = "framePagePlay";
            this.framePagePlay.Size = new System.Drawing.Size(701, 387);
            this.framePagePlay.TabIndex = 3;
            this.framePagePlay.Text = "Play Frame";
            this.framePagePlay.UseVisualStyleBackColor = true;
            // 
            // PlayFrame
            // 
            this.PlayFrame.Controls.Add(this.PlayFrameLabelRoundCount);
            this.PlayFrame.Controls.Add(this.PlayFrameLabelRound);
            this.PlayFrame.Controls.Add(this.PlayFrameButtonPlay);
            this.PlayFrame.Controls.Add(this.PlayFrameOpponentCard);
            this.PlayFrame.Controls.Add(this.PlayFramePlayerCard);
            this.PlayFrame.Controls.Add(this.PlayFrameLabelOpponentHandSize);
            this.PlayFrame.Controls.Add(this.PlayFrameLabelPlayerHandSize);
            this.PlayFrame.Controls.Add(this.PlayFrameLabelOpponentCards);
            this.PlayFrame.Controls.Add(this.PlayFrameLabelPlayerCards);
            this.PlayFrame.Controls.Add(this.PlayFrameOpponentDeck);
            this.PlayFrame.Controls.Add(this.PlayFramePlayerDeck);
            this.PlayFrame.Controls.Add(this.PlayFrameLabelPlayer);
            this.PlayFrame.Controls.Add(this.PlayFrameLabelOpponent);
            this.PlayFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayFrame.Location = new System.Drawing.Point(0, 0);
            this.PlayFrame.Margin = new System.Windows.Forms.Padding(2);
            this.PlayFrame.Name = "PlayFrame";
            this.PlayFrame.Size = new System.Drawing.Size(701, 387);
            this.PlayFrame.TabIndex = 0;
            // 
            // PlayFrameLabelRoundCount
            // 
            this.PlayFrameLabelRoundCount.AutoSize = true;
            this.PlayFrameLabelRoundCount.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GameRound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayFrameLabelRoundCount.Location = new System.Drawing.Point(47, 8);
            this.PlayFrameLabelRoundCount.Name = "PlayFrameLabelRoundCount";
            this.PlayFrameLabelRoundCount.Size = new System.Drawing.Size(13, 13);
            this.PlayFrameLabelRoundCount.TabIndex = 11;
            this.PlayFrameLabelRoundCount.Text = global::WarNET.Properties.Settings.Default.GameRound;
            // 
            // PlayFrameLabelRound
            // 
            this.PlayFrameLabelRound.AutoSize = true;
            this.PlayFrameLabelRound.Location = new System.Drawing.Point(8, 8);
            this.PlayFrameLabelRound.Name = "PlayFrameLabelRound";
            this.PlayFrameLabelRound.Size = new System.Drawing.Size(42, 13);
            this.PlayFrameLabelRound.TabIndex = 10;
            this.PlayFrameLabelRound.Text = "Round:";
            // 
            // PlayFrameButtonPlay
            // 
            this.PlayFrameButtonPlay.Location = new System.Drawing.Point(585, 347);
            this.PlayFrameButtonPlay.Name = "PlayFrameButtonPlay";
            this.PlayFrameButtonPlay.Size = new System.Drawing.Size(108, 32);
            this.PlayFrameButtonPlay.TabIndex = 9;
            this.PlayFrameButtonPlay.Text = "Play Card";
            this.PlayFrameButtonPlay.UseVisualStyleBackColor = true;
            // 
            // PlayFrameOpponentCard
            // 
            this.PlayFrameOpponentCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFrameOpponentCard.Location = new System.Drawing.Point(378, 110);
            this.PlayFrameOpponentCard.Margin = new System.Windows.Forms.Padding(2);
            this.PlayFrameOpponentCard.Name = "PlayFrameOpponentCard";
            this.PlayFrameOpponentCard.Size = new System.Drawing.Size(90, 125);
            this.PlayFrameOpponentCard.TabIndex = 3;
            // 
            // PlayFramePlayerCard
            // 
            this.PlayFramePlayerCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFramePlayerCard.Location = new System.Drawing.Point(252, 110);
            this.PlayFramePlayerCard.Margin = new System.Windows.Forms.Padding(2);
            this.PlayFramePlayerCard.Name = "PlayFramePlayerCard";
            this.PlayFramePlayerCard.Size = new System.Drawing.Size(90, 125);
            this.PlayFramePlayerCard.TabIndex = 3;
            // 
            // PlayFrameLabelOpponentHandSize
            // 
            this.PlayFrameLabelOpponentHandSize.AutoSize = true;
            this.PlayFrameLabelOpponentHandSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GameOpponentHandSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayFrameLabelOpponentHandSize.Location = new System.Drawing.Point(665, 8);
            this.PlayFrameLabelOpponentHandSize.Name = "PlayFrameLabelOpponentHandSize";
            this.PlayFrameLabelOpponentHandSize.Size = new System.Drawing.Size(13, 13);
            this.PlayFrameLabelOpponentHandSize.TabIndex = 7;
            this.PlayFrameLabelOpponentHandSize.Text = global::WarNET.Properties.Settings.Default.GameOpponentHandSize;
            // 
            // PlayFrameLabelPlayerHandSize
            // 
            this.PlayFrameLabelPlayerHandSize.AutoSize = true;
            this.PlayFrameLabelPlayerHandSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GamePlayerHandSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayFrameLabelPlayerHandSize.Location = new System.Drawing.Point(87, 369);
            this.PlayFrameLabelPlayerHandSize.Name = "PlayFrameLabelPlayerHandSize";
            this.PlayFrameLabelPlayerHandSize.Size = new System.Drawing.Size(13, 13);
            this.PlayFrameLabelPlayerHandSize.TabIndex = 6;
            this.PlayFrameLabelPlayerHandSize.Text = global::WarNET.Properties.Settings.Default.GamePlayerHandSize;
            // 
            // PlayFrameLabelOpponentCards
            // 
            this.PlayFrameLabelOpponentCards.AutoSize = true;
            this.PlayFrameLabelOpponentCards.Location = new System.Drawing.Point(610, 8);
            this.PlayFrameLabelOpponentCards.Name = "PlayFrameLabelOpponentCards";
            this.PlayFrameLabelOpponentCards.Size = new System.Drawing.Size(58, 13);
            this.PlayFrameLabelOpponentCards.TabIndex = 5;
            this.PlayFrameLabelOpponentCards.Text = "Cards Left:";
            // 
            // PlayFrameLabelPlayerCards
            // 
            this.PlayFrameLabelPlayerCards.AutoSize = true;
            this.PlayFrameLabelPlayerCards.Location = new System.Drawing.Point(32, 369);
            this.PlayFrameLabelPlayerCards.Name = "PlayFrameLabelPlayerCards";
            this.PlayFrameLabelPlayerCards.Size = new System.Drawing.Size(58, 13);
            this.PlayFrameLabelPlayerCards.TabIndex = 4;
            this.PlayFrameLabelPlayerCards.Text = "Cards Left:";
            // 
            // PlayFrameOpponentDeck
            // 
            this.PlayFrameOpponentDeck.BackgroundImage = global::WarNET.Properties.Resources.Back;
            this.PlayFrameOpponentDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFrameOpponentDeck.Location = new System.Drawing.Point(604, 29);
            this.PlayFrameOpponentDeck.Margin = new System.Windows.Forms.Padding(2);
            this.PlayFrameOpponentDeck.Name = "PlayFrameOpponentDeck";
            this.PlayFrameOpponentDeck.Size = new System.Drawing.Size(90, 125);
            this.PlayFrameOpponentDeck.TabIndex = 3;
            // 
            // PlayFramePlayerDeck
            // 
            this.PlayFramePlayerDeck.BackgroundImage = global::WarNET.Properties.Resources.Back;
            this.PlayFramePlayerDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFramePlayerDeck.Location = new System.Drawing.Point(21, 237);
            this.PlayFramePlayerDeck.Margin = new System.Windows.Forms.Padding(2);
            this.PlayFramePlayerDeck.Name = "PlayFramePlayerDeck";
            this.PlayFramePlayerDeck.Size = new System.Drawing.Size(90, 125);
            this.PlayFramePlayerDeck.TabIndex = 2;
            // 
            // PlayFrameLabelPlayer
            // 
            this.PlayFrameLabelPlayer.AutoEllipsis = true;
            this.PlayFrameLabelPlayer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GamePlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayFrameLabelPlayer.Location = new System.Drawing.Point(21, 217);
            this.PlayFrameLabelPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayFrameLabelPlayer.Name = "PlayFrameLabelPlayer";
            this.PlayFrameLabelPlayer.Size = new System.Drawing.Size(90, 18);
            this.PlayFrameLabelPlayer.TabIndex = 1;
            this.PlayFrameLabelPlayer.Text = global::WarNET.Properties.Settings.Default.GamePlayerName;
            this.PlayFrameLabelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayFrameLabelOpponent
            // 
            this.PlayFrameLabelOpponent.AutoEllipsis = true;
            this.PlayFrameLabelOpponent.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GameOpponentName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayFrameLabelOpponent.Location = new System.Drawing.Point(601, 156);
            this.PlayFrameLabelOpponent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlayFrameLabelOpponent.Name = "PlayFrameLabelOpponent";
            this.PlayFrameLabelOpponent.Size = new System.Drawing.Size(93, 18);
            this.PlayFrameLabelOpponent.TabIndex = 0;
            this.PlayFrameLabelOpponent.Text = global::WarNET.Properties.Settings.Default.GameOpponentName;
            this.PlayFrameLabelOpponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.framePageNewGame.ResumeLayout(false);
            this.NewGameFrame.ResumeLayout(false);
            this.NewGameFrame.PerformLayout();
            this.NewGameBoxCut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewGameDeckCutSlider)).EndInit();
            this.NewGameBoxShuffle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewGameDeckShuffleSlider)).EndInit();
            this.framePagePlay.ResumeLayout(false);
            this.PlayFrame.ResumeLayout(false);
            this.PlayFrame.PerformLayout();
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
        private System.Windows.Forms.TabPage framePageNewGame;
        private System.Windows.Forms.Panel NewGameFrame;
        private System.Windows.Forms.TextBox NewGameTextName;
        private System.Windows.Forms.TextBox NewGameTextOpponent;
        private System.Windows.Forms.TrackBar NewGameDeckCutSlider;
        private System.Windows.Forms.TrackBar NewGameDeckShuffleSlider;
        private System.Windows.Forms.GroupBox NewGameBoxCut;
        private System.Windows.Forms.GroupBox NewGameBoxShuffle;
        private System.Windows.Forms.Label NewGameLabelOpponent;
        private System.Windows.Forms.Button NewGameButtonStart;
        private System.Windows.Forms.Label NewGameLabelName;
        private System.Windows.Forms.Button NewGameButtonCancel;
        private System.Windows.Forms.TabPage framePagePlay;
        private System.Windows.Forms.Panel PlayFrame;
        private System.Windows.Forms.Label PlayFrameLabelPlayer;
        private System.Windows.Forms.Label PlayFrameLabelOpponent;
        private System.Windows.Forms.Panel PlayFramePlayerDeck;
        private System.Windows.Forms.Label PlayFrameLabelOpponentHandSize;
        private System.Windows.Forms.Label PlayFrameLabelPlayerHandSize;
        private System.Windows.Forms.Label PlayFrameLabelOpponentCards;
        private System.Windows.Forms.Label PlayFrameLabelPlayerCards;
        private System.Windows.Forms.Panel PlayFrameOpponentDeck;
        private System.Windows.Forms.Panel PlayFrameOpponentCard;
        private System.Windows.Forms.Panel PlayFramePlayerCard;
        private System.Windows.Forms.Label PlayFrameLabelRound;
        private System.Windows.Forms.Button PlayFrameButtonPlay;
        private System.Windows.Forms.Label PlayFrameLabelRoundCount;
    }
}

