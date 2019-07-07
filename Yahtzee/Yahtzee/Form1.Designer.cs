namespace Yahtzee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_rollDice = new System.Windows.Forms.Button();
            this.layoutPanel_dices = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_totalScore = new System.Windows.Forms.Label();
            this.lbl_sixes = new System.Windows.Forms.Label();
            this.lbl_fives = new System.Windows.Forms.Label();
            this.lbl_fours = new System.Windows.Forms.Label();
            this.lbl_threes = new System.Windows.Forms.Label();
            this.lbl_twos = new System.Windows.Forms.Label();
            this.lbl_aces = new System.Windows.Forms.Label();
            this.picBox_d1 = new System.Windows.Forms.PictureBox();
            this.picBox_d2 = new System.Windows.Forms.PictureBox();
            this.picBox_d3 = new System.Windows.Forms.PictureBox();
            this.picBox_d4 = new System.Windows.Forms.PictureBox();
            this.picBox_d5 = new System.Windows.Forms.PictureBox();
            this.picBox_d6 = new System.Windows.Forms.PictureBox();
            this.lbl_score3Kind = new System.Windows.Forms.Label();
            this.lbl_scoreBonus = new System.Windows.Forms.Label();
            this.lbl_4ofAKind = new System.Windows.Forms.Label();
            this.lbl_3ofAKind = new System.Windows.Forms.Label();
            this.lbl_bonus = new System.Windows.Forms.Label();
            this.lbl_4KindScore = new System.Windows.Forms.Label();
            this.lbl_scoreFH = new System.Windows.Forms.Label();
            this.lbl_scoreLStraight = new System.Windows.Forms.Label();
            this.lbl_FH = new System.Windows.Forms.Label();
            this.lbl_LScore = new System.Windows.Forms.Label();
            this.lbl_HSCore = new System.Windows.Forms.Label();
            this.lbl_scoreHStraight = new System.Windows.Forms.Label();
            this.lbl_scoreChance = new System.Windows.Forms.Label();
            this.lbl_chance = new System.Windows.Forms.Label();
            this.lbl_scoreYat = new System.Windows.Forms.Label();
            this.lbl_yaht = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dicePlay_ctrl = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_d1Txt = new System.Windows.Forms.Label();
            this.lbl_displayDice5 = new System.Windows.Forms.Label();
            this.lbl_displayDice1 = new System.Windows.Forms.Label();
            this.lbl_d5Txt = new System.Windows.Forms.Label();
            this.lbl_displayDice4 = new System.Windows.Forms.Label();
            this.lbl_d2Txt = new System.Windows.Forms.Label();
            this.lbl_displayDice3 = new System.Windows.Forms.Label();
            this.lbl_d4Txt = new System.Windows.Forms.Label();
            this.lbl_displayDice2 = new System.Windows.Forms.Label();
            this.lbl_d3Txt = new System.Windows.Forms.Label();
            this.chk_holdD1 = new System.Windows.Forms.CheckBox();
            this.chk_holdD2 = new System.Windows.Forms.CheckBox();
            this.chk_holdD3 = new System.Windows.Forms.CheckBox();
            this.chk_holdD4 = new System.Windows.Forms.CheckBox();
            this.chk_holdD5 = new System.Windows.Forms.CheckBox();
            this.lbl_rollsLeft = new System.Windows.Forms.Label();
            this.layoutPanel_dices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d6)).BeginInit();
            this.scoreBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.dicePlay_ctrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_rollDice
            // 
            this.btn_rollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rollDice.Location = new System.Drawing.Point(34, 417);
            this.btn_rollDice.Name = "btn_rollDice";
            this.btn_rollDice.Size = new System.Drawing.Size(456, 60);
            this.btn_rollDice.TabIndex = 0;
            this.btn_rollDice.Text = "Roll Dice";
            this.btn_rollDice.UseVisualStyleBackColor = true;
            this.btn_rollDice.Click += new System.EventHandler(this.Btn_rollDice_Click);
            // 
            // layoutPanel_dices
            // 
            this.layoutPanel_dices.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.layoutPanel_dices.ColumnCount = 2;
            this.layoutPanel_dices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.layoutPanel_dices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.layoutPanel_dices.Controls.Add(this.lbl_totalScore, 0, 14);
            this.layoutPanel_dices.Controls.Add(this.lbl_sixes, 1, 5);
            this.layoutPanel_dices.Controls.Add(this.lbl_fives, 1, 4);
            this.layoutPanel_dices.Controls.Add(this.lbl_fours, 1, 3);
            this.layoutPanel_dices.Controls.Add(this.lbl_threes, 1, 2);
            this.layoutPanel_dices.Controls.Add(this.lbl_twos, 1, 1);
            this.layoutPanel_dices.Controls.Add(this.lbl_aces, 1, 0);
            this.layoutPanel_dices.Controls.Add(this.picBox_d1, 0, 0);
            this.layoutPanel_dices.Controls.Add(this.picBox_d2, 0, 1);
            this.layoutPanel_dices.Controls.Add(this.picBox_d3, 0, 2);
            this.layoutPanel_dices.Controls.Add(this.picBox_d4, 0, 3);
            this.layoutPanel_dices.Controls.Add(this.picBox_d5, 0, 4);
            this.layoutPanel_dices.Controls.Add(this.picBox_d6, 0, 5);
            this.layoutPanel_dices.Controls.Add(this.lbl_score3Kind, 1, 7);
            this.layoutPanel_dices.Controls.Add(this.lbl_scoreBonus, 1, 6);
            this.layoutPanel_dices.Controls.Add(this.lbl_4ofAKind, 0, 8);
            this.layoutPanel_dices.Controls.Add(this.lbl_3ofAKind, 0, 7);
            this.layoutPanel_dices.Controls.Add(this.lbl_bonus, 0, 6);
            this.layoutPanel_dices.Controls.Add(this.lbl_4KindScore, 1, 8);
            this.layoutPanel_dices.Controls.Add(this.lbl_scoreFH, 1, 9);
            this.layoutPanel_dices.Controls.Add(this.lbl_scoreLStraight, 1, 10);
            this.layoutPanel_dices.Controls.Add(this.lbl_FH, 0, 9);
            this.layoutPanel_dices.Controls.Add(this.lbl_LScore, 0, 10);
            this.layoutPanel_dices.Controls.Add(this.lbl_HSCore, 0, 11);
            this.layoutPanel_dices.Controls.Add(this.lbl_scoreHStraight, 1, 11);
            this.layoutPanel_dices.Controls.Add(this.lbl_scoreChance, 1, 12);
            this.layoutPanel_dices.Controls.Add(this.lbl_chance, 0, 12);
            this.layoutPanel_dices.Controls.Add(this.lbl_scoreYat, 1, 13);
            this.layoutPanel_dices.Controls.Add(this.lbl_yaht, 0, 13);
            this.layoutPanel_dices.Location = new System.Drawing.Point(95, 18);
            this.layoutPanel_dices.Name = "layoutPanel_dices";
            this.layoutPanel_dices.RowCount = 15;
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutPanel_dices.Size = new System.Drawing.Size(242, 701);
            this.layoutPanel_dices.TabIndex = 1;
            this.layoutPanel_dices.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutPanel_dices_Paint);
            // 
            // lbl_totalScore
            // 
            this.lbl_totalScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_totalScore.AutoSize = true;
            this.lbl_totalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_totalScore.Location = new System.Drawing.Point(6, 655);
            this.lbl_totalScore.Name = "lbl_totalScore";
            this.lbl_totalScore.Size = new System.Drawing.Size(149, 43);
            this.lbl_totalScore.TabIndex = 29;
            this.lbl_totalScore.Text = "Final Score";
            this.lbl_totalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sixes
            // 
            this.lbl_sixes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_sixes.AutoSize = true;
            this.lbl_sixes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sixes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_sixes.Location = new System.Drawing.Point(164, 268);
            this.lbl_sixes.Name = "lbl_sixes";
            this.lbl_sixes.Size = new System.Drawing.Size(72, 56);
            this.lbl_sixes.TabIndex = 11;
            this.lbl_sixes.Text = "0";
            this.lbl_sixes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fives
            // 
            this.lbl_fives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fives.AutoSize = true;
            this.lbl_fives.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fives.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fives.Location = new System.Drawing.Point(164, 215);
            this.lbl_fives.Name = "lbl_fives";
            this.lbl_fives.Size = new System.Drawing.Size(72, 50);
            this.lbl_fives.TabIndex = 10;
            this.lbl_fives.Text = "0";
            this.lbl_fives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fours
            // 
            this.lbl_fours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fours.AutoSize = true;
            this.lbl_fours.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fours.Location = new System.Drawing.Point(164, 162);
            this.lbl_fours.Name = "lbl_fours";
            this.lbl_fours.Size = new System.Drawing.Size(72, 50);
            this.lbl_fours.TabIndex = 9;
            this.lbl_fours.Text = "0";
            this.lbl_fours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_threes
            // 
            this.lbl_threes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_threes.AutoSize = true;
            this.lbl_threes.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_threes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_threes.Location = new System.Drawing.Point(164, 109);
            this.lbl_threes.Name = "lbl_threes";
            this.lbl_threes.Size = new System.Drawing.Size(72, 50);
            this.lbl_threes.TabIndex = 8;
            this.lbl_threes.Text = "0";
            this.lbl_threes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_twos
            // 
            this.lbl_twos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_twos.AutoSize = true;
            this.lbl_twos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_twos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_twos.Location = new System.Drawing.Point(164, 56);
            this.lbl_twos.Name = "lbl_twos";
            this.lbl_twos.Size = new System.Drawing.Size(72, 50);
            this.lbl_twos.TabIndex = 7;
            this.lbl_twos.Text = "0";
            this.lbl_twos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_aces
            // 
            this.lbl_aces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_aces.AutoSize = true;
            this.lbl_aces.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aces.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_aces.Location = new System.Drawing.Point(164, 3);
            this.lbl_aces.Name = "lbl_aces";
            this.lbl_aces.Size = new System.Drawing.Size(72, 50);
            this.lbl_aces.TabIndex = 6;
            this.lbl_aces.Text = "0";
            this.lbl_aces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_aces.Click += new System.EventHandler(this.Lbl_aces_Click);
            // 
            // picBox_d1
            // 
            this.picBox_d1.Image = ((System.Drawing.Image)(resources.GetObject("picBox_d1.Image")));
            this.picBox_d1.Location = new System.Drawing.Point(6, 6);
            this.picBox_d1.Name = "picBox_d1";
            this.picBox_d1.Size = new System.Drawing.Size(149, 44);
            this.picBox_d1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_d1.TabIndex = 0;
            this.picBox_d1.TabStop = false;
            // 
            // picBox_d2
            // 
            this.picBox_d2.Image = ((System.Drawing.Image)(resources.GetObject("picBox_d2.Image")));
            this.picBox_d2.Location = new System.Drawing.Point(6, 59);
            this.picBox_d2.Name = "picBox_d2";
            this.picBox_d2.Size = new System.Drawing.Size(149, 44);
            this.picBox_d2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_d2.TabIndex = 1;
            this.picBox_d2.TabStop = false;
            // 
            // picBox_d3
            // 
            this.picBox_d3.Image = ((System.Drawing.Image)(resources.GetObject("picBox_d3.Image")));
            this.picBox_d3.Location = new System.Drawing.Point(6, 112);
            this.picBox_d3.Name = "picBox_d3";
            this.picBox_d3.Size = new System.Drawing.Size(149, 44);
            this.picBox_d3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_d3.TabIndex = 2;
            this.picBox_d3.TabStop = false;
            // 
            // picBox_d4
            // 
            this.picBox_d4.Image = ((System.Drawing.Image)(resources.GetObject("picBox_d4.Image")));
            this.picBox_d4.Location = new System.Drawing.Point(6, 165);
            this.picBox_d4.Name = "picBox_d4";
            this.picBox_d4.Size = new System.Drawing.Size(149, 44);
            this.picBox_d4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_d4.TabIndex = 3;
            this.picBox_d4.TabStop = false;
            // 
            // picBox_d5
            // 
            this.picBox_d5.Image = ((System.Drawing.Image)(resources.GetObject("picBox_d5.Image")));
            this.picBox_d5.Location = new System.Drawing.Point(6, 218);
            this.picBox_d5.Name = "picBox_d5";
            this.picBox_d5.Size = new System.Drawing.Size(149, 44);
            this.picBox_d5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_d5.TabIndex = 4;
            this.picBox_d5.TabStop = false;
            // 
            // picBox_d6
            // 
            this.picBox_d6.Image = ((System.Drawing.Image)(resources.GetObject("picBox_d6.Image")));
            this.picBox_d6.Location = new System.Drawing.Point(6, 271);
            this.picBox_d6.Name = "picBox_d6";
            this.picBox_d6.Size = new System.Drawing.Size(149, 50);
            this.picBox_d6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_d6.TabIndex = 5;
            this.picBox_d6.TabStop = false;
            // 
            // lbl_score3Kind
            // 
            this.lbl_score3Kind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_score3Kind.AutoSize = true;
            this.lbl_score3Kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score3Kind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_score3Kind.Location = new System.Drawing.Point(164, 368);
            this.lbl_score3Kind.Name = "lbl_score3Kind";
            this.lbl_score3Kind.Size = new System.Drawing.Size(72, 38);
            this.lbl_score3Kind.TabIndex = 14;
            this.lbl_score3Kind.Text = "0";
            this.lbl_score3Kind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scoreBonus
            // 
            this.lbl_scoreBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_scoreBonus.AutoSize = true;
            this.lbl_scoreBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreBonus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_scoreBonus.Location = new System.Drawing.Point(164, 327);
            this.lbl_scoreBonus.Name = "lbl_scoreBonus";
            this.lbl_scoreBonus.Size = new System.Drawing.Size(72, 38);
            this.lbl_scoreBonus.TabIndex = 15;
            this.lbl_scoreBonus.Text = "0";
            this.lbl_scoreBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_4ofAKind
            // 
            this.lbl_4ofAKind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_4ofAKind.AutoSize = true;
            this.lbl_4ofAKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4ofAKind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_4ofAKind.Location = new System.Drawing.Point(6, 409);
            this.lbl_4ofAKind.Name = "lbl_4ofAKind";
            this.lbl_4ofAKind.Size = new System.Drawing.Size(149, 38);
            this.lbl_4ofAKind.TabIndex = 16;
            this.lbl_4ofAKind.Text = "Four of a Kind";
            this.lbl_4ofAKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_3ofAKind
            // 
            this.lbl_3ofAKind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_3ofAKind.AutoSize = true;
            this.lbl_3ofAKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3ofAKind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_3ofAKind.Location = new System.Drawing.Point(6, 368);
            this.lbl_3ofAKind.Name = "lbl_3ofAKind";
            this.lbl_3ofAKind.Size = new System.Drawing.Size(149, 38);
            this.lbl_3ofAKind.TabIndex = 13;
            this.lbl_3ofAKind.Text = "Three of a Kind";
            this.lbl_3ofAKind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_bonus
            // 
            this.lbl_bonus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_bonus.AutoSize = true;
            this.lbl_bonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bonus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_bonus.Location = new System.Drawing.Point(6, 327);
            this.lbl_bonus.Name = "lbl_bonus";
            this.lbl_bonus.Size = new System.Drawing.Size(149, 38);
            this.lbl_bonus.TabIndex = 17;
            this.lbl_bonus.Text = "Bonus:";
            this.lbl_bonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_4KindScore
            // 
            this.lbl_4KindScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_4KindScore.AutoSize = true;
            this.lbl_4KindScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_4KindScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_4KindScore.Location = new System.Drawing.Point(164, 409);
            this.lbl_4KindScore.Name = "lbl_4KindScore";
            this.lbl_4KindScore.Size = new System.Drawing.Size(72, 38);
            this.lbl_4KindScore.TabIndex = 18;
            this.lbl_4KindScore.Text = "0";
            this.lbl_4KindScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scoreFH
            // 
            this.lbl_scoreFH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_scoreFH.AutoSize = true;
            this.lbl_scoreFH.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreFH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_scoreFH.Location = new System.Drawing.Point(164, 450);
            this.lbl_scoreFH.Name = "lbl_scoreFH";
            this.lbl_scoreFH.Size = new System.Drawing.Size(72, 38);
            this.lbl_scoreFH.TabIndex = 19;
            this.lbl_scoreFH.Text = "0";
            this.lbl_scoreFH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scoreLStraight
            // 
            this.lbl_scoreLStraight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_scoreLStraight.AutoSize = true;
            this.lbl_scoreLStraight.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreLStraight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_scoreLStraight.Location = new System.Drawing.Point(164, 491);
            this.lbl_scoreLStraight.Name = "lbl_scoreLStraight";
            this.lbl_scoreLStraight.Size = new System.Drawing.Size(72, 38);
            this.lbl_scoreLStraight.TabIndex = 20;
            this.lbl_scoreLStraight.Text = "0";
            this.lbl_scoreLStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_FH
            // 
            this.lbl_FH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FH.AutoSize = true;
            this.lbl_FH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_FH.Location = new System.Drawing.Point(6, 450);
            this.lbl_FH.Name = "lbl_FH";
            this.lbl_FH.Size = new System.Drawing.Size(149, 38);
            this.lbl_FH.TabIndex = 21;
            this.lbl_FH.Text = "Full House";
            this.lbl_FH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_LScore
            // 
            this.lbl_LScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LScore.AutoSize = true;
            this.lbl_LScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_LScore.Location = new System.Drawing.Point(6, 491);
            this.lbl_LScore.Name = "lbl_LScore";
            this.lbl_LScore.Size = new System.Drawing.Size(149, 38);
            this.lbl_LScore.TabIndex = 22;
            this.lbl_LScore.Text = "Low Straight";
            this.lbl_LScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_HSCore
            // 
            this.lbl_HSCore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HSCore.AutoSize = true;
            this.lbl_HSCore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HSCore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_HSCore.Location = new System.Drawing.Point(6, 532);
            this.lbl_HSCore.Name = "lbl_HSCore";
            this.lbl_HSCore.Size = new System.Drawing.Size(149, 38);
            this.lbl_HSCore.TabIndex = 23;
            this.lbl_HSCore.Text = "High Straight";
            this.lbl_HSCore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scoreHStraight
            // 
            this.lbl_scoreHStraight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_scoreHStraight.AutoSize = true;
            this.lbl_scoreHStraight.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreHStraight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_scoreHStraight.Location = new System.Drawing.Point(164, 532);
            this.lbl_scoreHStraight.Name = "lbl_scoreHStraight";
            this.lbl_scoreHStraight.Size = new System.Drawing.Size(72, 38);
            this.lbl_scoreHStraight.TabIndex = 24;
            this.lbl_scoreHStraight.Text = "0";
            this.lbl_scoreHStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scoreChance
            // 
            this.lbl_scoreChance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_scoreChance.AutoSize = true;
            this.lbl_scoreChance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreChance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_scoreChance.Location = new System.Drawing.Point(164, 573);
            this.lbl_scoreChance.Name = "lbl_scoreChance";
            this.lbl_scoreChance.Size = new System.Drawing.Size(72, 38);
            this.lbl_scoreChance.TabIndex = 26;
            this.lbl_scoreChance.Text = "0";
            this.lbl_scoreChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_chance
            // 
            this.lbl_chance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_chance.AutoSize = true;
            this.lbl_chance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_chance.Location = new System.Drawing.Point(6, 573);
            this.lbl_chance.Name = "lbl_chance";
            this.lbl_chance.Size = new System.Drawing.Size(149, 38);
            this.lbl_chance.TabIndex = 25;
            this.lbl_chance.Text = "Chance";
            this.lbl_chance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scoreYat
            // 
            this.lbl_scoreYat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_scoreYat.AutoSize = true;
            this.lbl_scoreYat.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreYat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_scoreYat.Location = new System.Drawing.Point(164, 614);
            this.lbl_scoreYat.Name = "lbl_scoreYat";
            this.lbl_scoreYat.Size = new System.Drawing.Size(72, 38);
            this.lbl_scoreYat.TabIndex = 28;
            this.lbl_scoreYat.Text = "0";
            this.lbl_scoreYat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_yaht
            // 
            this.lbl_yaht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_yaht.AutoSize = true;
            this.lbl_yaht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yaht.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_yaht.Location = new System.Drawing.Point(6, 614);
            this.lbl_yaht.Name = "lbl_yaht";
            this.lbl_yaht.Size = new System.Drawing.Size(149, 38);
            this.lbl_yaht.TabIndex = 27;
            this.lbl_yaht.Text = "Yahtzee!";
            this.lbl_yaht.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scoreBox.Controls.Add(this.layoutPanel_dices);
            this.scoreBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.scoreBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreBox.Location = new System.Drawing.Point(578, 0);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scoreBox.Size = new System.Drawing.Size(343, 741);
            this.scoreBox.TabIndex = 2;
            this.scoreBox.TabStop = false;
            this.scoreBox.Text = "SCORES";
            this.scoreBox.Enter += new System.EventHandler(this.ScoreBox_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dicePlay_ctrl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(34, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 218);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dices play";
            // 
            // dicePlay_ctrl
            // 
            this.dicePlay_ctrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dicePlay_ctrl.ColumnCount = 3;
            this.dicePlay_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.dicePlay_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dicePlay_ctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.dicePlay_ctrl.Controls.Add(this.lbl_displayDice5, 1, 4);
            this.dicePlay_ctrl.Controls.Add(this.lbl_d5Txt, 0, 4);
            this.dicePlay_ctrl.Controls.Add(this.lbl_displayDice4, 1, 3);
            this.dicePlay_ctrl.Controls.Add(this.lbl_d2Txt, 0, 1);
            this.dicePlay_ctrl.Controls.Add(this.lbl_displayDice3, 1, 2);
            this.dicePlay_ctrl.Controls.Add(this.lbl_d4Txt, 0, 3);
            this.dicePlay_ctrl.Controls.Add(this.lbl_displayDice2, 1, 1);
            this.dicePlay_ctrl.Controls.Add(this.lbl_d3Txt, 0, 2);
            this.dicePlay_ctrl.Controls.Add(this.chk_holdD1, 2, 0);
            this.dicePlay_ctrl.Controls.Add(this.chk_holdD2, 2, 1);
            this.dicePlay_ctrl.Controls.Add(this.chk_holdD3, 2, 2);
            this.dicePlay_ctrl.Controls.Add(this.chk_holdD4, 2, 3);
            this.dicePlay_ctrl.Controls.Add(this.chk_holdD5, 2, 4);
            this.dicePlay_ctrl.Controls.Add(this.lbl_d1Txt, 0, 0);
            this.dicePlay_ctrl.Controls.Add(this.lbl_displayDice1, 1, 0);
            this.dicePlay_ctrl.Dock = System.Windows.Forms.DockStyle.Left;
            this.dicePlay_ctrl.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.dicePlay_ctrl.Location = new System.Drawing.Point(3, 26);
            this.dicePlay_ctrl.Name = "dicePlay_ctrl";
            this.dicePlay_ctrl.RowCount = 5;
            this.dicePlay_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dicePlay_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dicePlay_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dicePlay_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.dicePlay_ctrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dicePlay_ctrl.Size = new System.Drawing.Size(447, 189);
            this.dicePlay_ctrl.TabIndex = 11;
            // 
            // lbl_d1Txt
            // 
            this.lbl_d1Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_d1Txt.AutoSize = true;
            this.lbl_d1Txt.Location = new System.Drawing.Point(3, 0);
            this.lbl_d1Txt.Name = "lbl_d1Txt";
            this.lbl_d1Txt.Size = new System.Drawing.Size(158, 35);
            this.lbl_d1Txt.TabIndex = 0;
            this.lbl_d1Txt.Text = "dice 1: ";
            this.lbl_d1Txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_displayDice5
            // 
            this.lbl_displayDice5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_displayDice5.AutoSize = true;
            this.lbl_displayDice5.Location = new System.Drawing.Point(167, 140);
            this.lbl_displayDice5.Name = "lbl_displayDice5";
            this.lbl_displayDice5.Size = new System.Drawing.Size(158, 49);
            this.lbl_displayDice5.TabIndex = 10;
            this.lbl_displayDice5.Text = "x";
            this.lbl_displayDice5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_displayDice1
            // 
            this.lbl_displayDice1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_displayDice1.AutoSize = true;
            this.lbl_displayDice1.Location = new System.Drawing.Point(167, 0);
            this.lbl_displayDice1.Name = "lbl_displayDice1";
            this.lbl_displayDice1.Size = new System.Drawing.Size(158, 35);
            this.lbl_displayDice1.TabIndex = 5;
            this.lbl_displayDice1.Text = "x";
            this.lbl_displayDice1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_d5Txt
            // 
            this.lbl_d5Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_d5Txt.AutoSize = true;
            this.lbl_d5Txt.Location = new System.Drawing.Point(3, 140);
            this.lbl_d5Txt.Name = "lbl_d5Txt";
            this.lbl_d5Txt.Size = new System.Drawing.Size(158, 49);
            this.lbl_d5Txt.TabIndex = 4;
            this.lbl_d5Txt.Text = "dice 5: ";
            this.lbl_d5Txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_displayDice4
            // 
            this.lbl_displayDice4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_displayDice4.AutoSize = true;
            this.lbl_displayDice4.Location = new System.Drawing.Point(167, 105);
            this.lbl_displayDice4.Name = "lbl_displayDice4";
            this.lbl_displayDice4.Size = new System.Drawing.Size(158, 35);
            this.lbl_displayDice4.TabIndex = 8;
            this.lbl_displayDice4.Text = "x";
            this.lbl_displayDice4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_d2Txt
            // 
            this.lbl_d2Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_d2Txt.AutoSize = true;
            this.lbl_d2Txt.Location = new System.Drawing.Point(3, 35);
            this.lbl_d2Txt.Name = "lbl_d2Txt";
            this.lbl_d2Txt.Size = new System.Drawing.Size(158, 35);
            this.lbl_d2Txt.TabIndex = 1;
            this.lbl_d2Txt.Text = "dice 2: ";
            this.lbl_d2Txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_displayDice3
            // 
            this.lbl_displayDice3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_displayDice3.AutoSize = true;
            this.lbl_displayDice3.Location = new System.Drawing.Point(167, 70);
            this.lbl_displayDice3.Name = "lbl_displayDice3";
            this.lbl_displayDice3.Size = new System.Drawing.Size(158, 35);
            this.lbl_displayDice3.TabIndex = 7;
            this.lbl_displayDice3.Text = "x";
            this.lbl_displayDice3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_d4Txt
            // 
            this.lbl_d4Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_d4Txt.AutoSize = true;
            this.lbl_d4Txt.Location = new System.Drawing.Point(3, 105);
            this.lbl_d4Txt.Name = "lbl_d4Txt";
            this.lbl_d4Txt.Size = new System.Drawing.Size(158, 35);
            this.lbl_d4Txt.TabIndex = 3;
            this.lbl_d4Txt.Text = "dice 4: ";
            this.lbl_d4Txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_displayDice2
            // 
            this.lbl_displayDice2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_displayDice2.AutoSize = true;
            this.lbl_displayDice2.Location = new System.Drawing.Point(167, 35);
            this.lbl_displayDice2.Name = "lbl_displayDice2";
            this.lbl_displayDice2.Size = new System.Drawing.Size(158, 35);
            this.lbl_displayDice2.TabIndex = 6;
            this.lbl_displayDice2.Text = "x";
            this.lbl_displayDice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_d3Txt
            // 
            this.lbl_d3Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_d3Txt.AutoSize = true;
            this.lbl_d3Txt.Location = new System.Drawing.Point(3, 70);
            this.lbl_d3Txt.Name = "lbl_d3Txt";
            this.lbl_d3Txt.Size = new System.Drawing.Size(158, 35);
            this.lbl_d3Txt.TabIndex = 2;
            this.lbl_d3Txt.Text = "dice 3: ";
            this.lbl_d3Txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chk_holdD1
            // 
            this.chk_holdD1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_holdD1.AutoSize = true;
            this.chk_holdD1.Location = new System.Drawing.Point(331, 3);
            this.chk_holdD1.Name = "chk_holdD1";
            this.chk_holdD1.Size = new System.Drawing.Size(113, 29);
            this.chk_holdD1.TabIndex = 11;
            this.chk_holdD1.Text = "hold dice";
            this.chk_holdD1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_holdD1.UseVisualStyleBackColor = true;
            // 
            // chk_holdD2
            // 
            this.chk_holdD2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_holdD2.AutoSize = true;
            this.chk_holdD2.Location = new System.Drawing.Point(331, 38);
            this.chk_holdD2.Name = "chk_holdD2";
            this.chk_holdD2.Size = new System.Drawing.Size(113, 29);
            this.chk_holdD2.TabIndex = 12;
            this.chk_holdD2.Text = "hold dice";
            this.chk_holdD2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_holdD2.UseVisualStyleBackColor = true;
            // 
            // chk_holdD3
            // 
            this.chk_holdD3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_holdD3.AutoSize = true;
            this.chk_holdD3.Location = new System.Drawing.Point(331, 73);
            this.chk_holdD3.Name = "chk_holdD3";
            this.chk_holdD3.Size = new System.Drawing.Size(113, 29);
            this.chk_holdD3.TabIndex = 13;
            this.chk_holdD3.Text = "hold dice";
            this.chk_holdD3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_holdD3.UseVisualStyleBackColor = true;
            // 
            // chk_holdD4
            // 
            this.chk_holdD4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_holdD4.AutoSize = true;
            this.chk_holdD4.Location = new System.Drawing.Point(331, 108);
            this.chk_holdD4.Name = "chk_holdD4";
            this.chk_holdD4.Size = new System.Drawing.Size(113, 29);
            this.chk_holdD4.TabIndex = 14;
            this.chk_holdD4.Text = "hold dice";
            this.chk_holdD4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_holdD4.UseVisualStyleBackColor = true;
            // 
            // chk_holdD5
            // 
            this.chk_holdD5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_holdD5.AutoSize = true;
            this.chk_holdD5.Location = new System.Drawing.Point(331, 143);
            this.chk_holdD5.Name = "chk_holdD5";
            this.chk_holdD5.Size = new System.Drawing.Size(113, 43);
            this.chk_holdD5.TabIndex = 15;
            this.chk_holdD5.Text = "hold dice";
            this.chk_holdD5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_holdD5.UseVisualStyleBackColor = true;
            // 
            // lbl_rollsLeft
            // 
            this.lbl_rollsLeft.AutoSize = true;
            this.lbl_rollsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rollsLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_rollsLeft.Location = new System.Drawing.Point(37, 321);
            this.lbl_rollsLeft.Name = "lbl_rollsLeft";
            this.lbl_rollsLeft.Size = new System.Drawing.Size(189, 32);
            this.lbl_rollsLeft.TabIndex = 4;
            this.lbl_rollsLeft.Text = "Rolls Left : X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(921, 741);
            this.Controls.Add(this.lbl_rollsLeft);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.btn_rollDice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Yahtzee!!!";
            this.layoutPanel_dices.ResumeLayout(false);
            this.layoutPanel_dices.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_d6)).EndInit();
            this.scoreBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.dicePlay_ctrl.ResumeLayout(false);
            this.dicePlay_ctrl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rollDice;
        private System.Windows.Forms.TableLayoutPanel layoutPanel_dices;
        private System.Windows.Forms.PictureBox picBox_d1;
        private System.Windows.Forms.PictureBox picBox_d2;
        private System.Windows.Forms.PictureBox picBox_d3;
        private System.Windows.Forms.PictureBox picBox_d4;
        private System.Windows.Forms.PictureBox picBox_d5;
        private System.Windows.Forms.PictureBox picBox_d6;
        private System.Windows.Forms.Label lbl_sixes;
        private System.Windows.Forms.Label lbl_fives;
        private System.Windows.Forms.Label lbl_fours;
        private System.Windows.Forms.Label lbl_threes;
        private System.Windows.Forms.Label lbl_twos;
        private System.Windows.Forms.GroupBox scoreBox;
        private System.Windows.Forms.Label lbl_yaht;
        private System.Windows.Forms.Label lbl_score3Kind;
        private System.Windows.Forms.Label lbl_scoreBonus;
        private System.Windows.Forms.Label lbl_4ofAKind;
        private System.Windows.Forms.Label lbl_3ofAKind;
        private System.Windows.Forms.Label lbl_bonus;
        private System.Windows.Forms.Label lbl_4KindScore;
        private System.Windows.Forms.Label lbl_scoreFH;
        private System.Windows.Forms.Label lbl_scoreLStraight;
        private System.Windows.Forms.Label lbl_FH;
        private System.Windows.Forms.Label lbl_LScore;
        private System.Windows.Forms.Label lbl_HSCore;
        private System.Windows.Forms.Label lbl_scoreHStraight;
        private System.Windows.Forms.Label lbl_scoreChance;
        private System.Windows.Forms.Label lbl_chance;
        private System.Windows.Forms.Label lbl_scoreYat;
        private System.Windows.Forms.Label lbl_totalScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_displayDice5;
        private System.Windows.Forms.Label lbl_displayDice4;
        private System.Windows.Forms.Label lbl_displayDice3;
        private System.Windows.Forms.Label lbl_d5Txt;
        private System.Windows.Forms.Label lbl_d4Txt;
        private System.Windows.Forms.Label lbl_d3Txt;
        private System.Windows.Forms.Label lbl_d1Txt;
        private System.Windows.Forms.Label lbl_d2Txt;
        private System.Windows.Forms.Label lbl_aces;
        private System.Windows.Forms.Label lbl_displayDice2;
        private System.Windows.Forms.Label lbl_displayDice1;
        private System.Windows.Forms.TableLayoutPanel dicePlay_ctrl;
        private System.Windows.Forms.CheckBox chk_holdD1;
        private System.Windows.Forms.CheckBox chk_holdD2;
        private System.Windows.Forms.CheckBox chk_holdD3;
        private System.Windows.Forms.CheckBox chk_holdD4;
        private System.Windows.Forms.CheckBox chk_holdD5;
        private System.Windows.Forms.Label lbl_rollsLeft;
    }
}

