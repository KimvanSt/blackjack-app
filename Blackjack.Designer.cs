namespace BlackjackGame
{
    partial class Blackjack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Player1Card1 = new PictureBox();
            Player1Card2 = new PictureBox();
            DealerCard1 = new PictureBox();
            DealerCard2 = new PictureBox();
            HitButton = new Button();
            PassButton = new Button();
            btnBox = new GroupBox();
            PlayerBetInput = new NumericUpDown();
            PlayerBetButton = new Button();
            PlayerChoice = new Label();
            StartButton = new Button();
            Player2Card2 = new PictureBox();
            Player2Card1 = new PictureBox();
            Player3Card2 = new PictureBox();
            Player3Card1 = new PictureBox();
            StartAgainButton = new Button();
            StopButton = new Button();
            Player2ChipImage = new PictureBox();
            Player3ChipImage = new PictureBox();
            Player1ChipImage = new PictureBox();
            StartUpBox = new GroupBox();
            groupBox1 = new GroupBox();
            BetPerRoundLabel = new Label();
            BetPerRoundInput = new RichTextBox();
            StartingChipsLabel = new Label();
            StartingChipsInput = new RichTextBox();
            label4 = new Label();
            SetUpComplete = new Button();
            Player3InputBox = new GroupBox();
            label3 = new Label();
            Player3Name = new RichTextBox();
            Player2InputBox = new GroupBox();
            label2 = new Label();
            Player2Name = new RichTextBox();
            Player1InputBox = new GroupBox();
            label1 = new Label();
            Player1Name = new RichTextBox();
            PlayerAmountBox = new GroupBox();
            ThreePlayers = new RadioButton();
            TwoPlayers = new RadioButton();
            OnePlayer = new RadioButton();
            PlayerAmountLabel = new Label();
            DealerNameBox = new Label();
            DealerChips = new Label();
            Player1Chips = new Label();
            Player2Chips = new Label();
            Player3Chips = new Label();
            GameTextBox = new Label();
            Player2NameBox = new Label();
            Player3NameBox = new Label();
            Player1NameBox = new Label();
            ((System.ComponentModel.ISupportInitialize)Player1Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player1Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DealerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DealerCard2).BeginInit();
            btnBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlayerBetInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player3Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player3Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player2ChipImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player3ChipImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player1ChipImage).BeginInit();
            StartUpBox.SuspendLayout();
            groupBox1.SuspendLayout();
            Player3InputBox.SuspendLayout();
            Player2InputBox.SuspendLayout();
            Player1InputBox.SuspendLayout();
            PlayerAmountBox.SuspendLayout();
            SuspendLayout();
            // 
            // Player1Card1
            // 
            Player1Card1.Location = new Point(11, 138);
            Player1Card1.Name = "Player1Card1";
            Player1Card1.Size = new Size(105, 178);
            Player1Card1.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1Card1.TabIndex = 0;
            Player1Card1.TabStop = false;
            // 
            // Player1Card2
            // 
            Player1Card2.Location = new Point(71, 138);
            Player1Card2.Name = "Player1Card2";
            Player1Card2.Size = new Size(105, 178);
            Player1Card2.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1Card2.TabIndex = 1;
            Player1Card2.TabStop = false;
            // 
            // DealerCard1
            // 
            DealerCard1.Location = new Point(495, 63);
            DealerCard1.Name = "DealerCard1";
            DealerCard1.Size = new Size(105, 178);
            DealerCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            DealerCard1.TabIndex = 2;
            DealerCard1.TabStop = false;
            // 
            // DealerCard2
            // 
            DealerCard2.Location = new Point(555, 63);
            DealerCard2.Name = "DealerCard2";
            DealerCard2.Size = new Size(105, 178);
            DealerCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            DealerCard2.TabIndex = 3;
            DealerCard2.TabStop = false;
            // 
            // HitButton
            // 
            HitButton.BackColor = Color.PaleGreen;
            HitButton.FlatStyle = FlatStyle.Popup;
            HitButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HitButton.Location = new Point(6, 103);
            HitButton.Name = "HitButton";
            HitButton.Size = new Size(118, 38);
            HitButton.TabIndex = 7;
            HitButton.Text = "Hit";
            HitButton.UseVisualStyleBackColor = false;
            HitButton.Visible = false;
            HitButton.Click += HitButton_Click;
            // 
            // PassButton
            // 
            PassButton.BackColor = Color.OrangeRed;
            PassButton.BackgroundImageLayout = ImageLayout.None;
            PassButton.FlatStyle = FlatStyle.Popup;
            PassButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PassButton.Location = new Point(149, 103);
            PassButton.Name = "PassButton";
            PassButton.Size = new Size(115, 38);
            PassButton.TabIndex = 8;
            PassButton.Text = "Pass";
            PassButton.UseVisualStyleBackColor = false;
            PassButton.Visible = false;
            PassButton.Click += PassButton_Click;
            // 
            // btnBox
            // 
            btnBox.Controls.Add(PlayerBetInput);
            btnBox.Controls.Add(PlayerBetButton);
            btnBox.Controls.Add(PlayerChoice);
            btnBox.Controls.Add(HitButton);
            btnBox.Controls.Add(PassButton);
            btnBox.FlatStyle = FlatStyle.Popup;
            btnBox.Location = new Point(12, 421);
            btnBox.Name = "btnBox";
            btnBox.Size = new Size(280, 198);
            btnBox.TabIndex = 9;
            btnBox.TabStop = false;
            btnBox.Visible = false;
            // 
            // PlayerBetInput
            // 
            PlayerBetInput.Location = new Point(21, 116);
            PlayerBetInput.Name = "PlayerBetInput";
            PlayerBetInput.Size = new Size(85, 23);
            PlayerBetInput.TabIndex = 5;
            PlayerBetInput.Visible = false;
            // 
            // PlayerBetButton
            // 
            PlayerBetButton.BackColor = Color.RoyalBlue;
            PlayerBetButton.FlatStyle = FlatStyle.Popup;
            PlayerBetButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerBetButton.Location = new Point(130, 103);
            PlayerBetButton.Name = "PlayerBetButton";
            PlayerBetButton.Size = new Size(118, 45);
            PlayerBetButton.TabIndex = 37;
            PlayerBetButton.Text = "Bet";
            PlayerBetButton.UseVisualStyleBackColor = false;
            PlayerBetButton.Visible = false;
            PlayerBetButton.Click += PlayerBetButton_Click;
            // 
            // PlayerChoice
            // 
            PlayerChoice.AutoSize = true;
            PlayerChoice.Font = new Font("Ebrima", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerChoice.Location = new Point(21, 25);
            PlayerChoice.Name = "PlayerChoice";
            PlayerChoice.Size = new Size(0, 30);
            PlayerChoice.TabIndex = 9;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.SlateBlue;
            StartButton.FlatStyle = FlatStyle.Popup;
            StartButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            StartButton.Location = new Point(463, 315);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(251, 49);
            StartButton.TabIndex = 10;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // Player2Card2
            // 
            Player2Card2.Location = new Point(555, 383);
            Player2Card2.Name = "Player2Card2";
            Player2Card2.Size = new Size(105, 178);
            Player2Card2.SizeMode = PictureBoxSizeMode.StretchImage;
            Player2Card2.TabIndex = 12;
            Player2Card2.TabStop = false;
            // 
            // Player2Card1
            // 
            Player2Card1.Location = new Point(495, 383);
            Player2Card1.Name = "Player2Card1";
            Player2Card1.Size = new Size(105, 178);
            Player2Card1.SizeMode = PictureBoxSizeMode.StretchImage;
            Player2Card1.TabIndex = 11;
            Player2Card1.TabStop = false;
            // 
            // Player3Card2
            // 
            Player3Card2.Location = new Point(919, 138);
            Player3Card2.Name = "Player3Card2";
            Player3Card2.Size = new Size(105, 178);
            Player3Card2.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3Card2.TabIndex = 15;
            Player3Card2.TabStop = false;
            // 
            // Player3Card1
            // 
            Player3Card1.Location = new Point(859, 138);
            Player3Card1.Name = "Player3Card1";
            Player3Card1.Size = new Size(105, 178);
            Player3Card1.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3Card1.TabIndex = 14;
            Player3Card1.TabStop = false;
            // 
            // StartAgainButton
            // 
            StartAgainButton.BackColor = Color.LimeGreen;
            StartAgainButton.FlatStyle = FlatStyle.Popup;
            StartAgainButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            StartAgainButton.Location = new Point(400, 315);
            StartAgainButton.Name = "StartAgainButton";
            StartAgainButton.Size = new Size(150, 50);
            StartAgainButton.TabIndex = 17;
            StartAgainButton.Text = "New Round";
            StartAgainButton.UseVisualStyleBackColor = false;
            StartAgainButton.Visible = false;
            StartAgainButton.Click += StartAgainButton_Click;
            // 
            // StopButton
            // 
            StopButton.BackColor = Color.Firebrick;
            StopButton.FlatStyle = FlatStyle.Popup;
            StopButton.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            StopButton.Location = new Point(577, 315);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(150, 50);
            StopButton.TabIndex = 18;
            StopButton.Text = "Exit Game";
            StopButton.UseVisualStyleBackColor = false;
            StopButton.Visible = false;
            StopButton.Click += StopButton_Click;
            // 
            // Player2ChipImage
            // 
            Player2ChipImage.BackColor = Color.Transparent;
            Player2ChipImage.Image = Properties.Resources.pokerchip;
            Player2ChipImage.InitialImage = Properties.Resources.pokerchip;
            Player2ChipImage.Location = new Point(495, 567);
            Player2ChipImage.Name = "Player2ChipImage";
            Player2ChipImage.Size = new Size(35, 33);
            Player2ChipImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Player2ChipImage.TabIndex = 19;
            Player2ChipImage.TabStop = false;
            Player2ChipImage.Visible = false;
            // 
            // Player3ChipImage
            // 
            Player3ChipImage.Image = Properties.Resources.pokerchip;
            Player3ChipImage.InitialImage = Properties.Resources.pokerchip;
            Player3ChipImage.Location = new Point(867, 99);
            Player3ChipImage.Name = "Player3ChipImage";
            Player3ChipImage.Size = new Size(35, 33);
            Player3ChipImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Player3ChipImage.TabIndex = 20;
            Player3ChipImage.TabStop = false;
            Player3ChipImage.Visible = false;
            // 
            // Player1ChipImage
            // 
            Player1ChipImage.Image = Properties.Resources.pokerchip;
            Player1ChipImage.InitialImage = Properties.Resources.pokerchip;
            Player1ChipImage.Location = new Point(12, 99);
            Player1ChipImage.Name = "Player1ChipImage";
            Player1ChipImage.Size = new Size(35, 33);
            Player1ChipImage.SizeMode = PictureBoxSizeMode.StretchImage;
            Player1ChipImage.TabIndex = 21;
            Player1ChipImage.TabStop = false;
            Player1ChipImage.Visible = false;
            // 
            // StartUpBox
            // 
            StartUpBox.Controls.Add(groupBox1);
            StartUpBox.Controls.Add(SetUpComplete);
            StartUpBox.Controls.Add(Player3InputBox);
            StartUpBox.Controls.Add(Player2InputBox);
            StartUpBox.Controls.Add(Player1InputBox);
            StartUpBox.Controls.Add(PlayerAmountBox);
            StartUpBox.Location = new Point(11, 0);
            StartUpBox.Name = "StartUpBox";
            StartUpBox.Size = new Size(1219, 633);
            StartUpBox.TabIndex = 26;
            StartUpBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BetPerRoundLabel);
            groupBox1.Controls.Add(BetPerRoundInput);
            groupBox1.Controls.Add(StartingChipsLabel);
            groupBox1.Controls.Add(StartingChipsInput);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(274, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(670, 128);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // BetPerRoundLabel
            // 
            BetPerRoundLabel.AutoSize = true;
            BetPerRoundLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            BetPerRoundLabel.Location = new Point(415, 68);
            BetPerRoundLabel.Name = "BetPerRoundLabel";
            BetPerRoundLabel.Size = new Size(208, 32);
            BetPerRoundLabel.TabIndex = 7;
            BetPerRoundLabel.Text = "10 bet per round";
            // 
            // BetPerRoundInput
            // 
            BetPerRoundInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BetPerRoundInput.Location = new Point(356, 68);
            BetPerRoundInput.Name = "BetPerRoundInput";
            BetPerRoundInput.Size = new Size(50, 41);
            BetPerRoundInput.TabIndex = 6;
            BetPerRoundInput.Text = "10";
            BetPerRoundInput.TextChanged += BetPerRoundInput_TextChanged;
            // 
            // StartingChipsLabel
            // 
            StartingChipsLabel.AutoSize = true;
            StartingChipsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            StartingChipsLabel.Location = new Point(78, 71);
            StartingChipsLabel.Name = "StartingChipsLabel";
            StartingChipsLabel.Size = new Size(205, 32);
            StartingChipsLabel.TabIndex = 5;
            StartingChipsLabel.Text = "30 starting chips";
            // 
            // StartingChipsInput
            // 
            StartingChipsInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            StartingChipsInput.Location = new Point(19, 71);
            StartingChipsInput.Name = "StartingChipsInput";
            StartingChipsInput.Size = new Size(50, 41);
            StartingChipsInput.TabIndex = 2;
            StartingChipsInput.Text = "30";
            StartingChipsInput.TextChanged += StartingChipsInput_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(144, 19);
            label4.Name = "label4";
            label4.Size = new Size(394, 32);
            label4.TabIndex = 4;
            label4.Text = "Starting chips and bet per round:";
            // 
            // SetUpComplete
            // 
            SetUpComplete.BackColor = Color.Gold;
            SetUpComplete.FlatStyle = FlatStyle.Flat;
            SetUpComplete.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            SetUpComplete.Location = new Point(474, 566);
            SetUpComplete.Name = "SetUpComplete";
            SetUpComplete.Size = new Size(290, 50);
            SetUpComplete.TabIndex = 3;
            SetUpComplete.Text = "Start Game";
            SetUpComplete.UseVisualStyleBackColor = false;
            SetUpComplete.Visible = false;
            SetUpComplete.Click += SetUpComplete_Click;
            // 
            // Player3InputBox
            // 
            Player3InputBox.Controls.Add(label3);
            Player3InputBox.Controls.Add(Player3Name);
            Player3InputBox.Location = new Point(274, 461);
            Player3InputBox.Name = "Player3InputBox";
            Player3InputBox.Size = new Size(670, 83);
            Player3InputBox.TabIndex = 2;
            Player3InputBox.TabStop = false;
            Player3InputBox.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Tomato;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 30);
            label3.Name = "label3";
            label3.Size = new Size(212, 32);
            label3.TabIndex = 2;
            label3.Text = "Red player name:";
            // 
            // Player3Name
            // 
            Player3Name.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Player3Name.Location = new Point(267, 31);
            Player3Name.Name = "Player3Name";
            Player3Name.Size = new Size(357, 31);
            Player3Name.TabIndex = 1;
            Player3Name.Text = "Player 3";
            // 
            // Player2InputBox
            // 
            Player2InputBox.Controls.Add(label2);
            Player2InputBox.Controls.Add(Player2Name);
            Player2InputBox.Location = new Point(274, 369);
            Player2InputBox.Name = "Player2InputBox";
            Player2InputBox.Size = new Size(670, 83);
            Player2InputBox.TabIndex = 2;
            Player2InputBox.TabStop = false;
            Player2InputBox.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 29);
            label2.Name = "label2";
            label2.Size = new Size(243, 32);
            label2.TabIndex = 2;
            label2.Text = "Yellow player name:";
            // 
            // Player2Name
            // 
            Player2Name.Font = new Font("Candara Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Player2Name.Location = new Point(267, 29);
            Player2Name.Name = "Player2Name";
            Player2Name.Size = new Size(357, 31);
            Player2Name.TabIndex = 1;
            Player2Name.Text = "Player 2";
            // 
            // Player1InputBox
            // 
            Player1InputBox.Controls.Add(label1);
            Player1InputBox.Controls.Add(Player1Name);
            Player1InputBox.Location = new Point(274, 280);
            Player1InputBox.Name = "Player1InputBox";
            Player1InputBox.Size = new Size(670, 83);
            Player1InputBox.TabIndex = 1;
            Player1InputBox.TabStop = false;
            Player1InputBox.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 30);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 1;
            label1.Text = "Blue player name:";
            // 
            // Player1Name
            // 
            Player1Name.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Player1Name.Location = new Point(267, 31);
            Player1Name.Name = "Player1Name";
            Player1Name.Size = new Size(357, 31);
            Player1Name.TabIndex = 0;
            Player1Name.Text = "Player 1";
            // 
            // PlayerAmountBox
            // 
            PlayerAmountBox.Controls.Add(ThreePlayers);
            PlayerAmountBox.Controls.Add(TwoPlayers);
            PlayerAmountBox.Controls.Add(OnePlayer);
            PlayerAmountBox.Controls.Add(PlayerAmountLabel);
            PlayerAmountBox.Location = new Point(274, 22);
            PlayerAmountBox.Name = "PlayerAmountBox";
            PlayerAmountBox.Size = new Size(670, 97);
            PlayerAmountBox.TabIndex = 0;
            PlayerAmountBox.TabStop = false;
            // 
            // ThreePlayers
            // 
            ThreePlayers.AutoSize = true;
            ThreePlayers.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ThreePlayers.Location = new Point(397, 54);
            ThreePlayers.Name = "ThreePlayers";
            ThreePlayers.Size = new Size(43, 32);
            ThreePlayers.TabIndex = 3;
            ThreePlayers.TabStop = true;
            ThreePlayers.Text = "3";
            ThreePlayers.UseVisualStyleBackColor = true;
            ThreePlayers.CheckedChanged += ThreePlayers_CheckedChanged;
            // 
            // TwoPlayers
            // 
            TwoPlayers.AutoSize = true;
            TwoPlayers.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TwoPlayers.Location = new Point(308, 54);
            TwoPlayers.Name = "TwoPlayers";
            TwoPlayers.Size = new Size(43, 32);
            TwoPlayers.TabIndex = 2;
            TwoPlayers.TabStop = true;
            TwoPlayers.Text = "2";
            TwoPlayers.UseVisualStyleBackColor = true;
            TwoPlayers.CheckedChanged += TwoPlayers_CheckedChanged;
            // 
            // OnePlayer
            // 
            OnePlayer.AutoSize = true;
            OnePlayer.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            OnePlayer.Location = new Point(209, 54);
            OnePlayer.Name = "OnePlayer";
            OnePlayer.Size = new Size(43, 32);
            OnePlayer.TabIndex = 1;
            OnePlayer.TabStop = true;
            OnePlayer.Text = "1";
            OnePlayer.UseVisualStyleBackColor = true;
            OnePlayer.CheckedChanged += OnePlayer_CheckedChanged;
            // 
            // PlayerAmountLabel
            // 
            PlayerAmountLabel.AutoSize = true;
            PlayerAmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerAmountLabel.Location = new Point(209, 19);
            PlayerAmountLabel.Name = "PlayerAmountLabel";
            PlayerAmountLabel.Size = new Size(236, 32);
            PlayerAmountLabel.TabIndex = 0;
            PlayerAmountLabel.Text = "How many players?";
            // 
            // DealerNameBox
            // 
            DealerNameBox.AutoSize = true;
            DealerNameBox.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DealerNameBox.Location = new Point(485, 15);
            DealerNameBox.Name = "DealerNameBox";
            DealerNameBox.Size = new Size(0, 25);
            DealerNameBox.TabIndex = 32;
            // 
            // DealerChips
            // 
            DealerChips.AutoSize = true;
            DealerChips.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DealerChips.Location = new Point(420, 19);
            DealerChips.Name = "DealerChips";
            DealerChips.Size = new Size(0, 25);
            DealerChips.TabIndex = 28;
            DealerChips.Visible = false;
            // 
            // Player1Chips
            // 
            Player1Chips.AutoSize = true;
            Player1Chips.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Player1Chips.Location = new Point(53, 99);
            Player1Chips.MaximumSize = new Size(75, 33);
            Player1Chips.Name = "Player1Chips";
            Player1Chips.Size = new Size(0, 25);
            Player1Chips.TabIndex = 29;
            // 
            // Player2Chips
            // 
            Player2Chips.AutoSize = true;
            Player2Chips.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Player2Chips.Location = new Point(536, 567);
            Player2Chips.MaximumSize = new Size(75, 33);
            Player2Chips.Name = "Player2Chips";
            Player2Chips.Size = new Size(0, 25);
            Player2Chips.TabIndex = 30;
            // 
            // Player3Chips
            // 
            Player3Chips.AutoSize = true;
            Player3Chips.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Player3Chips.Location = new Point(908, 99);
            Player3Chips.MaximumSize = new Size(75, 33);
            Player3Chips.Name = "Player3Chips";
            Player3Chips.Size = new Size(0, 25);
            Player3Chips.TabIndex = 31;
            // 
            // GameTextBox
            // 
            GameTextBox.AutoSize = true;
            GameTextBox.Font = new Font("Ebrima", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            GameTextBox.Location = new Point(369, 247);
            GameTextBox.Name = "GameTextBox";
            GameTextBox.Size = new Size(197, 50);
            GameTextBox.TabIndex = 32;
            GameTextBox.Text = "Welcome!";
            // 
            // Player2NameBox
            // 
            Player2NameBox.AutoSize = true;
            Player2NameBox.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Player2NameBox.Location = new Point(589, 567);
            Player2NameBox.MaximumSize = new Size(650, 55);
            Player2NameBox.Name = "Player2NameBox";
            Player2NameBox.Size = new Size(0, 25);
            Player2NameBox.TabIndex = 34;
            // 
            // Player3NameBox
            // 
            Player3NameBox.AutoSize = true;
            Player3NameBox.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Player3NameBox.Location = new Point(859, 319);
            Player3NameBox.MaximumSize = new Size(360, 180);
            Player3NameBox.Name = "Player3NameBox";
            Player3NameBox.Size = new Size(0, 25);
            Player3NameBox.TabIndex = 35;
            // 
            // Player1NameBox
            // 
            Player1NameBox.AutoSize = true;
            Player1NameBox.Font = new Font("Microsoft PhagsPa", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Player1NameBox.Location = new Point(11, 319);
            Player1NameBox.MaximumSize = new Size(360, 180);
            Player1NameBox.Name = "Player1NameBox";
            Player1NameBox.Size = new Size(0, 25);
            Player1NameBox.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            ClientSize = new Size(1242, 629);
            Controls.Add(DealerChips);
            Controls.Add(Player1Chips);
            Controls.Add(Player2Chips);
            Controls.Add(Player3Chips);
            Controls.Add(StartUpBox);
            Controls.Add(Player1ChipImage);
            Controls.Add(Player3ChipImage);
            Controls.Add(Player2ChipImage);
            Controls.Add(StopButton);
            Controls.Add(StartAgainButton);
            Controls.Add(Player3NameBox);
            Controls.Add(Player3Card2);
            Controls.Add(Player3Card1);
            Controls.Add(Player2NameBox);
            Controls.Add(Player1NameBox);
            Controls.Add(Player2Card2);
            Controls.Add(Player2Card1);
            Controls.Add(StartButton);
            Controls.Add(btnBox);
            Controls.Add(GameTextBox);
            Controls.Add(DealerCard2);
            Controls.Add(DealerNameBox);
            Controls.Add(DealerCard1);
            Controls.Add(Player1Card2);
            Controls.Add(Player1Card1);
            Name = "Form1";
            Text = "BlackJack";
            ((System.ComponentModel.ISupportInitialize)Player1Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player1Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DealerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DealerCard2).EndInit();
            btnBox.ResumeLayout(false);
            btnBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PlayerBetInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player3Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player3Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player2ChipImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player3ChipImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player1ChipImage).EndInit();
            StartUpBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Player3InputBox.ResumeLayout(false);
            Player3InputBox.PerformLayout();
            Player2InputBox.ResumeLayout(false);
            Player2InputBox.PerformLayout();
            Player1InputBox.ResumeLayout(false);
            Player1InputBox.PerformLayout();
            PlayerAmountBox.ResumeLayout(false);
            PlayerAmountBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Player1Card1;
        private PictureBox Player1Card2;
        private PictureBox DealerCard1;
        private PictureBox DealerCard2;
        private Button HitButton;
        private Button PassButton;
        private GroupBox btnBox;
        private RichTextBox PlayerChoiceText;
        private Button StartButton;
        private Label Player2NameBox;
        private PictureBox Player2Card2;
        private PictureBox Player2Card1;
        private PictureBox Player3Card2;
        private PictureBox Player3Card1;
        private Button StartAgainButton;
        private Button StopButton;
        private PictureBox Player2ChipImage;
        private PictureBox Player3ChipImage;
        private PictureBox Player1ChipImage;
        private GroupBox StartUpBox;
        private GroupBox PlayerAmountBox;
        private Label PlayerAmountLabel;
        private RadioButton ThreePlayers;
        private RadioButton TwoPlayers;
        private RadioButton OnePlayer;
        private GroupBox Player1InputBox;
        private GroupBox Player3InputBox;
        private GroupBox Player2InputBox;
        private Label label3;
        private RichTextBox Player3Name;
        private Label label2;
        private RichTextBox Player2Name;
        private Label label1;
        private RichTextBox Player1Name;
        private GroupBox groupBox1;
        private RichTextBox StartingChipsInput;
        private Label label4;
        private Button SetUpComplete;
        private Label StartingChipsLabel;
        private Label BetPerRoundLabel;
        private RichTextBox BetPerRoundInput;
        private Label DealerNameBox;
        private Label DealerChips;
        private Label Player1Chips;
        private Label Player2Chips;
        private Label Player3Chips;
        private Label GameTextBox;
        private Label label5;
        private Label Player3NameBox;
        private Label Player1NameBox;
        private Label PlayerChoice;
        private RichTextBox PlayerBet;
        private NumericUpDown numericUpDown1;
        private Button PlayerBetButton;
        private NumericUpDown PlayerBetInput;
    }
}