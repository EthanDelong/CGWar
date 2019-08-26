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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HomeButtonAbout = new System.Windows.Forms.Button();
            this.HomeTitle = new System.Windows.Forms.Label();
            this.HomeButtonNewGame = new System.Windows.Forms.Button();
            this.framePageNewGame = new System.Windows.Forms.TabPage();
            this.NewGameFrame = new System.Windows.Forms.Panel();
            this.NewGameTitle = new System.Windows.Forms.Label();
            this.gbWarBet = new System.Windows.Forms.GroupBox();
            this.NewGameWarBetSlider = new System.Windows.Forms.TrackBar();
            this.NewGameBoxShuffle = new System.Windows.Forms.GroupBox();
            this.NewGameDeckShuffleSlider = new System.Windows.Forms.TrackBar();
            this.NewGameBoxMaxRounds = new System.Windows.Forms.GroupBox();
            this.NewGameMaxRoundsSlider = new System.Windows.Forms.TrackBar();
            this.NewGameTextOpponent = new System.Windows.Forms.TextBox();
            this.NewGameTextName = new System.Windows.Forms.TextBox();
            this.NewGameBoxCut = new System.Windows.Forms.GroupBox();
            this.NewGameDeckCutSlider = new System.Windows.Forms.TrackBar();
            this.NewGameButtonCancel = new System.Windows.Forms.Button();
            this.NewGameLabelName = new System.Windows.Forms.Label();
            this.NewGameButtonStart = new System.Windows.Forms.Button();
            this.NewGameLabelOpponent = new System.Windows.Forms.Label();
            this.framePagePlay = new System.Windows.Forms.TabPage();
            this.PlayFrame = new System.Windows.Forms.Panel();
            this.PlayFrameStatus = new System.Windows.Forms.Label();
            this.PlayFrameButtonRestart = new System.Windows.Forms.Button();
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
            this.framePageAbout = new System.Windows.Forms.TabPage();
            this.AboutFrame = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AboutButtonHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AboutFrameBrowser = new System.Windows.Forms.WebBrowser();
            this.frameCollection.SuspendLayout();
            this.framePageHome.SuspendLayout();
            this.HomeFrame.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.framePageNewGame.SuspendLayout();
            this.NewGameFrame.SuspendLayout();
            this.gbWarBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewGameWarBetSlider)).BeginInit();
            this.NewGameBoxShuffle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewGameDeckShuffleSlider)).BeginInit();
            this.NewGameBoxMaxRounds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewGameMaxRoundsSlider)).BeginInit();
            this.NewGameBoxCut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewGameDeckCutSlider)).BeginInit();
            this.framePagePlay.SuspendLayout();
            this.PlayFrame.SuspendLayout();
            this.framePageAbout.SuspendLayout();
            this.AboutFrame.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frameCollection
            // 
            this.frameCollection.Controls.Add(this.framePageHome);
            this.frameCollection.Controls.Add(this.framePageNewGame);
            this.frameCollection.Controls.Add(this.framePagePlay);
            this.frameCollection.Controls.Add(this.framePageAbout);
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
            this.HomeFrame.Controls.Add(this.tableLayoutPanel1);
            this.HomeFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeFrame.Location = new System.Drawing.Point(4, 5);
            this.HomeFrame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeFrame.Name = "HomeFrame";
            this.HomeFrame.Size = new System.Drawing.Size(1048, 592);
            this.HomeFrame.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HomeButtonAbout, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.HomeTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HomeButtonNewGame, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1048, 592);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // HomeButtonAbout
            // 
            this.HomeButtonAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeButtonAbout.Location = new System.Drawing.Point(534, 325);
            this.HomeButtonAbout.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButtonAbout.Name = "HomeButtonAbout";
            this.HomeButtonAbout.Size = new System.Drawing.Size(162, 49);
            this.HomeButtonAbout.TabIndex = 3;
            this.HomeButtonAbout.Text = "About";
            this.HomeButtonAbout.UseVisualStyleBackColor = true;
            // 
            // HomeTitle
            // 
            this.HomeTitle.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.HomeTitle, 5);
            this.HomeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTitle.Location = new System.Drawing.Point(0, 0);
            this.HomeTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.HomeTitle.Name = "HomeTitle";
            this.HomeTitle.Size = new System.Drawing.Size(1048, 225);
            this.HomeTitle.TabIndex = 0;
            this.HomeTitle.Text = "War.NET";
            this.HomeTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HomeButtonNewGame
            // 
            this.HomeButtonNewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeButtonNewGame.Location = new System.Drawing.Point(352, 325);
            this.HomeButtonNewGame.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButtonNewGame.Name = "HomeButtonNewGame";
            this.HomeButtonNewGame.Size = new System.Drawing.Size(162, 49);
            this.HomeButtonNewGame.TabIndex = 2;
            this.HomeButtonNewGame.Text = "Play";
            this.HomeButtonNewGame.UseVisualStyleBackColor = true;
            // 
            // framePageNewGame
            // 
            this.framePageNewGame.Controls.Add(this.NewGameFrame);
            this.framePageNewGame.Location = new System.Drawing.Point(4, 29);
            this.framePageNewGame.Name = "framePageNewGame";
            this.framePageNewGame.Size = new System.Drawing.Size(1056, 602);
            this.framePageNewGame.TabIndex = 2;
            this.framePageNewGame.Text = "NewGame Frame";
            this.framePageNewGame.UseVisualStyleBackColor = true;
            // 
            // NewGameFrame
            // 
            this.NewGameFrame.Controls.Add(this.NewGameTitle);
            this.NewGameFrame.Controls.Add(this.gbWarBet);
            this.NewGameFrame.Controls.Add(this.NewGameBoxShuffle);
            this.NewGameFrame.Controls.Add(this.NewGameBoxMaxRounds);
            this.NewGameFrame.Controls.Add(this.NewGameTextOpponent);
            this.NewGameFrame.Controls.Add(this.NewGameTextName);
            this.NewGameFrame.Controls.Add(this.NewGameBoxCut);
            this.NewGameFrame.Controls.Add(this.NewGameButtonCancel);
            this.NewGameFrame.Controls.Add(this.NewGameLabelName);
            this.NewGameFrame.Controls.Add(this.NewGameButtonStart);
            this.NewGameFrame.Controls.Add(this.NewGameLabelOpponent);
            this.NewGameFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameFrame.Location = new System.Drawing.Point(0, 0);
            this.NewGameFrame.Name = "NewGameFrame";
            this.NewGameFrame.Size = new System.Drawing.Size(1056, 602);
            this.NewGameFrame.TabIndex = 0;
            // 
            // NewGameTitle
            // 
            this.NewGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameTitle.Location = new System.Drawing.Point(19, 27);
            this.NewGameTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 100);
            this.NewGameTitle.Name = "NewGameTitle";
            this.NewGameTitle.Size = new System.Drawing.Size(1016, 124);
            this.NewGameTitle.TabIndex = 14;
            this.NewGameTitle.Text = "Game Settings";
            this.NewGameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbWarBet
            // 
            this.gbWarBet.Controls.Add(this.NewGameWarBetSlider);
            this.gbWarBet.Location = new System.Drawing.Point(539, 398);
            this.gbWarBet.Name = "gbWarBet";
            this.gbWarBet.Size = new System.Drawing.Size(484, 66);
            this.gbWarBet.TabIndex = 13;
            this.gbWarBet.TabStop = false;
            this.gbWarBet.Text = "# Cards Bet for War: 0";
            // 
            // NewGameWarBetSlider
            // 
            this.NewGameWarBetSlider.AutoSize = false;
            this.NewGameWarBetSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameWarBetSlider.Location = new System.Drawing.Point(3, 22);
            this.NewGameWarBetSlider.Name = "NewGameWarBetSlider";
            this.NewGameWarBetSlider.Size = new System.Drawing.Size(478, 41);
            this.NewGameWarBetSlider.TabIndex = 3;
            this.NewGameWarBetSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // NewGameBoxShuffle
            // 
            this.NewGameBoxShuffle.Controls.Add(this.NewGameDeckShuffleSlider);
            this.NewGameBoxShuffle.Location = new System.Drawing.Point(29, 298);
            this.NewGameBoxShuffle.Name = "NewGameBoxShuffle";
            this.NewGameBoxShuffle.Size = new System.Drawing.Size(484, 66);
            this.NewGameBoxShuffle.TabIndex = 10;
            this.NewGameBoxShuffle.TabStop = false;
            this.NewGameBoxShuffle.Text = "Shuffle Count: 0";
            // 
            // NewGameDeckShuffleSlider
            // 
            this.NewGameDeckShuffleSlider.AutoSize = false;
            this.NewGameDeckShuffleSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameDeckShuffleSlider.Location = new System.Drawing.Point(3, 22);
            this.NewGameDeckShuffleSlider.Name = "NewGameDeckShuffleSlider";
            this.NewGameDeckShuffleSlider.Size = new System.Drawing.Size(478, 41);
            this.NewGameDeckShuffleSlider.TabIndex = 2;
            this.NewGameDeckShuffleSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // NewGameBoxMaxRounds
            // 
            this.NewGameBoxMaxRounds.Controls.Add(this.NewGameMaxRoundsSlider);
            this.NewGameBoxMaxRounds.Location = new System.Drawing.Point(539, 298);
            this.NewGameBoxMaxRounds.Name = "NewGameBoxMaxRounds";
            this.NewGameBoxMaxRounds.Size = new System.Drawing.Size(484, 66);
            this.NewGameBoxMaxRounds.TabIndex = 12;
            this.NewGameBoxMaxRounds.TabStop = false;
            this.NewGameBoxMaxRounds.Text = "Max Rounds: 0";
            // 
            // NewGameMaxRoundsSlider
            // 
            this.NewGameMaxRoundsSlider.AutoSize = false;
            this.NewGameMaxRoundsSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameMaxRoundsSlider.LargeChange = 100;
            this.NewGameMaxRoundsSlider.Location = new System.Drawing.Point(3, 22);
            this.NewGameMaxRoundsSlider.Name = "NewGameMaxRoundsSlider";
            this.NewGameMaxRoundsSlider.Size = new System.Drawing.Size(478, 41);
            this.NewGameMaxRoundsSlider.SmallChange = 10;
            this.NewGameMaxRoundsSlider.TabIndex = 3;
            this.NewGameMaxRoundsSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // NewGameTextOpponent
            // 
            this.NewGameTextOpponent.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GameOpponentName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NewGameTextOpponent.Location = new System.Drawing.Point(364, 231);
            this.NewGameTextOpponent.Name = "NewGameTextOpponent";
            this.NewGameTextOpponent.Size = new System.Drawing.Size(337, 26);
            this.NewGameTextOpponent.TabIndex = 6;
            this.NewGameTextOpponent.Text = global::WarNET.Properties.Settings.Default.GameOpponentName;
            // 
            // NewGameTextName
            // 
            this.NewGameTextName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GamePlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NewGameTextName.Location = new System.Drawing.Point(365, 176);
            this.NewGameTextName.Name = "NewGameTextName";
            this.NewGameTextName.Size = new System.Drawing.Size(336, 26);
            this.NewGameTextName.TabIndex = 5;
            this.NewGameTextName.Text = global::WarNET.Properties.Settings.Default.GamePlayerName;
            // 
            // NewGameBoxCut
            // 
            this.NewGameBoxCut.Controls.Add(this.NewGameDeckCutSlider);
            this.NewGameBoxCut.Location = new System.Drawing.Point(29, 398);
            this.NewGameBoxCut.Name = "NewGameBoxCut";
            this.NewGameBoxCut.Size = new System.Drawing.Size(484, 66);
            this.NewGameBoxCut.TabIndex = 11;
            this.NewGameBoxCut.TabStop = false;
            this.NewGameBoxCut.Text = "Cut Deck At: 0";
            // 
            // NewGameDeckCutSlider
            // 
            this.NewGameDeckCutSlider.AutoSize = false;
            this.NewGameDeckCutSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameDeckCutSlider.Location = new System.Drawing.Point(3, 22);
            this.NewGameDeckCutSlider.Name = "NewGameDeckCutSlider";
            this.NewGameDeckCutSlider.Size = new System.Drawing.Size(478, 41);
            this.NewGameDeckCutSlider.TabIndex = 3;
            this.NewGameDeckCutSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // NewGameButtonCancel
            // 
            this.NewGameButtonCancel.Location = new System.Drawing.Point(539, 510);
            this.NewGameButtonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewGameButtonCancel.Name = "NewGameButtonCancel";
            this.NewGameButtonCancel.Size = new System.Drawing.Size(162, 49);
            this.NewGameButtonCancel.TabIndex = 12;
            this.NewGameButtonCancel.Text = "Cancel";
            this.NewGameButtonCancel.UseVisualStyleBackColor = true;
            // 
            // NewGameLabelName
            // 
            this.NewGameLabelName.AutoSize = true;
            this.NewGameLabelName.Location = new System.Drawing.Point(303, 179);
            this.NewGameLabelName.Name = "NewGameLabelName";
            this.NewGameLabelName.Size = new System.Drawing.Size(55, 20);
            this.NewGameLabelName.TabIndex = 7;
            this.NewGameLabelName.Text = "Name:";
            // 
            // NewGameButtonStart
            // 
            this.NewGameButtonStart.Location = new System.Drawing.Point(351, 510);
            this.NewGameButtonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewGameButtonStart.Name = "NewGameButtonStart";
            this.NewGameButtonStart.Size = new System.Drawing.Size(162, 49);
            this.NewGameButtonStart.TabIndex = 8;
            this.NewGameButtonStart.Text = "Start Game";
            this.NewGameButtonStart.UseVisualStyleBackColor = true;
            // 
            // NewGameLabelOpponent
            // 
            this.NewGameLabelOpponent.AutoSize = true;
            this.NewGameLabelOpponent.Location = new System.Drawing.Point(274, 234);
            this.NewGameLabelOpponent.Name = "NewGameLabelOpponent";
            this.NewGameLabelOpponent.Size = new System.Drawing.Size(84, 20);
            this.NewGameLabelOpponent.TabIndex = 9;
            this.NewGameLabelOpponent.Text = "Opponent:";
            // 
            // framePagePlay
            // 
            this.framePagePlay.Controls.Add(this.PlayFrame);
            this.framePagePlay.Location = new System.Drawing.Point(4, 29);
            this.framePagePlay.Name = "framePagePlay";
            this.framePagePlay.Size = new System.Drawing.Size(1056, 602);
            this.framePagePlay.TabIndex = 3;
            this.framePagePlay.Text = "Play Frame";
            this.framePagePlay.UseVisualStyleBackColor = true;
            // 
            // PlayFrame
            // 
            this.PlayFrame.Controls.Add(this.PlayFrameStatus);
            this.PlayFrame.Controls.Add(this.PlayFrameButtonRestart);
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
            this.PlayFrame.Name = "PlayFrame";
            this.PlayFrame.Size = new System.Drawing.Size(1056, 602);
            this.PlayFrame.TabIndex = 0;
            // 
            // PlayFrameStatus
            // 
            this.PlayFrameStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayFrameStatus.Location = new System.Drawing.Point(150, 12);
            this.PlayFrameStatus.Name = "PlayFrameStatus";
            this.PlayFrameStatus.Size = new System.Drawing.Size(740, 63);
            this.PlayFrameStatus.TabIndex = 13;
            this.PlayFrameStatus.Text = "Player wins round!";
            this.PlayFrameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayFrameButtonRestart
            // 
            this.PlayFrameButtonRestart.Enabled = false;
            this.PlayFrameButtonRestart.Location = new System.Drawing.Point(699, 554);
            this.PlayFrameButtonRestart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayFrameButtonRestart.Name = "PlayFrameButtonRestart";
            this.PlayFrameButtonRestart.Size = new System.Drawing.Size(162, 49);
            this.PlayFrameButtonRestart.TabIndex = 12;
            this.PlayFrameButtonRestart.Text = "Play Again";
            this.PlayFrameButtonRestart.UseVisualStyleBackColor = true;
            this.PlayFrameButtonRestart.Visible = false;
            // 
            // PlayFrameLabelRoundCount
            // 
            this.PlayFrameLabelRoundCount.AutoSize = true;
            this.PlayFrameLabelRoundCount.Location = new System.Drawing.Point(70, 12);
            this.PlayFrameLabelRoundCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayFrameLabelRoundCount.Name = "PlayFrameLabelRoundCount";
            this.PlayFrameLabelRoundCount.Size = new System.Drawing.Size(18, 20);
            this.PlayFrameLabelRoundCount.TabIndex = 11;
            this.PlayFrameLabelRoundCount.Text = "0";
            // 
            // PlayFrameLabelRound
            // 
            this.PlayFrameLabelRound.AutoSize = true;
            this.PlayFrameLabelRound.Location = new System.Drawing.Point(12, 12);
            this.PlayFrameLabelRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayFrameLabelRound.Name = "PlayFrameLabelRound";
            this.PlayFrameLabelRound.Size = new System.Drawing.Size(61, 20);
            this.PlayFrameLabelRound.TabIndex = 10;
            this.PlayFrameLabelRound.Text = "Round:";
            // 
            // PlayFrameButtonPlay
            // 
            this.PlayFrameButtonPlay.Location = new System.Drawing.Point(869, 554);
            this.PlayFrameButtonPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlayFrameButtonPlay.Name = "PlayFrameButtonPlay";
            this.PlayFrameButtonPlay.Size = new System.Drawing.Size(162, 49);
            this.PlayFrameButtonPlay.TabIndex = 9;
            this.PlayFrameButtonPlay.Text = "Play Card";
            this.PlayFrameButtonPlay.UseVisualStyleBackColor = true;
            // 
            // PlayFrameOpponentCard
            // 
            this.PlayFrameOpponentCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFrameOpponentCard.Location = new System.Drawing.Point(567, 159);
            this.PlayFrameOpponentCard.Name = "PlayFrameOpponentCard";
            this.PlayFrameOpponentCard.Size = new System.Drawing.Size(135, 188);
            this.PlayFrameOpponentCard.TabIndex = 3;
            // 
            // PlayFramePlayerCard
            // 
            this.PlayFramePlayerCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFramePlayerCard.Location = new System.Drawing.Point(367, 261);
            this.PlayFramePlayerCard.Name = "PlayFramePlayerCard";
            this.PlayFramePlayerCard.Size = new System.Drawing.Size(135, 188);
            this.PlayFramePlayerCard.TabIndex = 3;
            // 
            // PlayFrameLabelOpponentHandSize
            // 
            this.PlayFrameLabelOpponentHandSize.AutoSize = true;
            this.PlayFrameLabelOpponentHandSize.Location = new System.Drawing.Point(977, 296);
            this.PlayFrameLabelOpponentHandSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayFrameLabelOpponentHandSize.Name = "PlayFrameLabelOpponentHandSize";
            this.PlayFrameLabelOpponentHandSize.Size = new System.Drawing.Size(18, 20);
            this.PlayFrameLabelOpponentHandSize.TabIndex = 7;
            this.PlayFrameLabelOpponentHandSize.Text = "0";
            // 
            // PlayFrameLabelPlayerHandSize
            // 
            this.PlayFrameLabelPlayerHandSize.AutoSize = true;
            this.PlayFrameLabelPlayerHandSize.Location = new System.Drawing.Point(129, 567);
            this.PlayFrameLabelPlayerHandSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayFrameLabelPlayerHandSize.Name = "PlayFrameLabelPlayerHandSize";
            this.PlayFrameLabelPlayerHandSize.Size = new System.Drawing.Size(18, 20);
            this.PlayFrameLabelPlayerHandSize.TabIndex = 6;
            this.PlayFrameLabelPlayerHandSize.Text = "0";
            // 
            // PlayFrameLabelOpponentCards
            // 
            this.PlayFrameLabelOpponentCards.AutoSize = true;
            this.PlayFrameLabelOpponentCards.Location = new System.Drawing.Point(926, 296);
            this.PlayFrameLabelOpponentCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayFrameLabelOpponentCards.Name = "PlayFrameLabelOpponentCards";
            this.PlayFrameLabelOpponentCards.Size = new System.Drawing.Size(55, 20);
            this.PlayFrameLabelOpponentCards.TabIndex = 5;
            this.PlayFrameLabelOpponentCards.Text = "Cards:";
            // 
            // PlayFrameLabelPlayerCards
            // 
            this.PlayFrameLabelPlayerCards.AutoSize = true;
            this.PlayFrameLabelPlayerCards.Location = new System.Drawing.Point(80, 567);
            this.PlayFrameLabelPlayerCards.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayFrameLabelPlayerCards.Name = "PlayFrameLabelPlayerCards";
            this.PlayFrameLabelPlayerCards.Size = new System.Drawing.Size(55, 20);
            this.PlayFrameLabelPlayerCards.TabIndex = 4;
            this.PlayFrameLabelPlayerCards.Text = "Cards:";
            // 
            // PlayFrameOpponentDeck
            // 
            this.PlayFrameOpponentDeck.BackgroundImage = global::WarNET.Properties.Resources.Empty;
            this.PlayFrameOpponentDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFrameOpponentDeck.Location = new System.Drawing.Point(896, 94);
            this.PlayFrameOpponentDeck.Name = "PlayFrameOpponentDeck";
            this.PlayFrameOpponentDeck.Size = new System.Drawing.Size(135, 188);
            this.PlayFrameOpponentDeck.TabIndex = 3;
            // 
            // PlayFramePlayerDeck
            // 
            this.PlayFramePlayerDeck.BackgroundImage = global::WarNET.Properties.Resources.Empty;
            this.PlayFramePlayerDeck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayFramePlayerDeck.Location = new System.Drawing.Point(47, 363);
            this.PlayFramePlayerDeck.Name = "PlayFramePlayerDeck";
            this.PlayFramePlayerDeck.Size = new System.Drawing.Size(135, 188);
            this.PlayFramePlayerDeck.TabIndex = 2;
            // 
            // PlayFrameLabelPlayer
            // 
            this.PlayFrameLabelPlayer.AutoEllipsis = true;
            this.PlayFrameLabelPlayer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GamePlayerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayFrameLabelPlayer.Location = new System.Drawing.Point(16, 291);
            this.PlayFrameLabelPlayer.Name = "PlayFrameLabelPlayer";
            this.PlayFrameLabelPlayer.Size = new System.Drawing.Size(194, 28);
            this.PlayFrameLabelPlayer.TabIndex = 1;
            this.PlayFrameLabelPlayer.Text = global::WarNET.Properties.Settings.Default.GamePlayerName;
            this.PlayFrameLabelPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayFrameLabelOpponent
            // 
            this.PlayFrameLabelOpponent.AutoEllipsis = true;
            this.PlayFrameLabelOpponent.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WarNET.Properties.Settings.Default, "GameOpponentName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayFrameLabelOpponent.Location = new System.Drawing.Point(869, 12);
            this.PlayFrameLabelOpponent.Name = "PlayFrameLabelOpponent";
            this.PlayFrameLabelOpponent.Size = new System.Drawing.Size(179, 28);
            this.PlayFrameLabelOpponent.TabIndex = 0;
            this.PlayFrameLabelOpponent.Text = global::WarNET.Properties.Settings.Default.GameOpponentName;
            this.PlayFrameLabelOpponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // framePageAbout
            // 
            this.framePageAbout.Controls.Add(this.AboutFrame);
            this.framePageAbout.Location = new System.Drawing.Point(4, 29);
            this.framePageAbout.Name = "framePageAbout";
            this.framePageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.framePageAbout.Size = new System.Drawing.Size(1056, 602);
            this.framePageAbout.TabIndex = 4;
            this.framePageAbout.Text = "About Frame";
            this.framePageAbout.UseVisualStyleBackColor = true;
            // 
            // AboutFrame
            // 
            this.AboutFrame.Controls.Add(this.tableLayoutPanel2);
            this.AboutFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutFrame.Location = new System.Drawing.Point(3, 3);
            this.AboutFrame.Name = "AboutFrame";
            this.AboutFrame.Size = new System.Drawing.Size(1050, 596);
            this.AboutFrame.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.AboutButtonHome, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1050, 596);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 180);
            this.label1.TabIndex = 0;
            this.label1.Text = "War.NET";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutButtonHome
            // 
            this.AboutButtonHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutButtonHome.Location = new System.Drawing.Point(444, 496);
            this.AboutButtonHome.Margin = new System.Windows.Forms.Padding(0);
            this.AboutButtonHome.Name = "AboutButtonHome";
            this.AboutButtonHome.Size = new System.Drawing.Size(162, 49);
            this.AboutButtonHome.TabIndex = 3;
            this.AboutButtonHome.Text = "Return Home";
            this.AboutButtonHome.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.groupBox1, 5);
            this.groupBox1.Controls.Add(this.AboutFrameBrowser);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(50, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel2.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(950, 266);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // AboutFrameBrowser
            // 
            this.AboutFrameBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutFrameBrowser.Location = new System.Drawing.Point(3, 22);
            this.AboutFrameBrowser.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.AboutFrameBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.AboutFrameBrowser.Name = "AboutFrameBrowser";
            this.AboutFrameBrowser.Size = new System.Drawing.Size(944, 241);
            this.AboutFrameBrowser.TabIndex = 4;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.framePageNewGame.ResumeLayout(false);
            this.NewGameFrame.ResumeLayout(false);
            this.NewGameFrame.PerformLayout();
            this.gbWarBet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewGameWarBetSlider)).EndInit();
            this.NewGameBoxShuffle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewGameDeckShuffleSlider)).EndInit();
            this.NewGameBoxMaxRounds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewGameMaxRoundsSlider)).EndInit();
            this.NewGameBoxCut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NewGameDeckCutSlider)).EndInit();
            this.framePagePlay.ResumeLayout(false);
            this.PlayFrame.ResumeLayout(false);
            this.PlayFrame.PerformLayout();
            this.framePageAbout.ResumeLayout(false);
            this.AboutFrame.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl frameCollection;
        private System.Windows.Forms.TabPage framePageHome;
        private System.Windows.Forms.Panel HomeFrame;
        private System.Windows.Forms.Label HomeTitle;
        private System.Windows.Forms.Button HomeButtonNewGame;
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
        private System.Windows.Forms.Button PlayFrameButtonRestart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox NewGameBoxMaxRounds;
        private System.Windows.Forms.TrackBar NewGameMaxRoundsSlider;
        private System.Windows.Forms.GroupBox gbWarBet;
        private System.Windows.Forms.TrackBar NewGameWarBetSlider;
        private System.Windows.Forms.Label NewGameTitle;
        private System.Windows.Forms.Label PlayFrameStatus;
        private System.Windows.Forms.Button HomeButtonAbout;
        private System.Windows.Forms.TabPage framePageAbout;
        private System.Windows.Forms.Panel AboutFrame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button AboutButtonHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.WebBrowser AboutFrameBrowser;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

