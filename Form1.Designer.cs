namespace ZadDom
{
    partial class Kopalnia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kopalnia));
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBoxMoney = new System.Windows.Forms.PictureBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonBuyWorker = new System.Windows.Forms.Button();
            this.textBoxWorker = new System.Windows.Forms.TextBox();
            this.textBoxHowManyWorkers = new System.Windows.Forms.TextBox();
            this.pictureBoxWorker = new System.Windows.Forms.PictureBox();
            this.pictureBoxWagon = new System.Windows.Forms.PictureBox();
            this.pictureBoxDiamond = new System.Windows.Forms.PictureBox();
            this.textBoxDiamond = new System.Windows.Forms.TextBox();
            this.textBoxWagon = new System.Windows.Forms.TextBox();
            this.textBoxHowManyWagons = new System.Windows.Forms.TextBox();
            this.buttonBuyWagon = new System.Windows.Forms.Button();
            this.buttonWagonUpgrade = new System.Windows.Forms.Button();
            this.textBoxWagonUpgrade = new System.Windows.Forms.TextBox();
            this.textBoxWorkerUpgrade = new System.Windows.Forms.TextBox();
            this.buttonWorkerUpgrade = new System.Windows.Forms.Button();
            this.progressBarWorkerUpgrade = new System.Windows.Forms.ProgressBar();
            this.progressBarWagonUpgrade = new System.Windows.Forms.ProgressBar();
            this.pictureBoxTradeUnion = new System.Windows.Forms.PictureBox();
            this.progressBarTradeUnion = new System.Windows.Forms.ProgressBar();
            this.textBoxTradeUnion = new System.Windows.Forms.TextBox();
            this.buttonTradeUnion = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWagon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiamond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTradeUnion)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Green;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(12, 40);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(79, 29);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(12, 12);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(79, 22);
            this.textBoxTime.TabIndex = 1;
            this.textBoxTime.Text = "00 : 00";
            this.textBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Crimson;
            this.buttonExit.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(956, 462);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 32);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Wyjscie";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBoxMoney
            // 
            this.pictureBoxMoney.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMoney.Image")));
            this.pictureBoxMoney.Location = new System.Drawing.Point(880, 12);
            this.pictureBoxMoney.Name = "pictureBoxMoney";
            this.pictureBoxMoney.Size = new System.Drawing.Size(79, 60);
            this.pictureBoxMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMoney.TabIndex = 4;
            this.pictureBoxMoney.TabStop = false;
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.BackColor = System.Drawing.Color.Gold;
            this.textBoxMoney.Location = new System.Drawing.Point(880, 78);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(79, 22);
            this.textBoxMoney.TabIndex = 5;
            this.textBoxMoney.Text = "0";
            this.textBoxMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuyWorker
            // 
            this.buttonBuyWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuyWorker.Location = new System.Drawing.Point(211, 130);
            this.buttonBuyWorker.Name = "buttonBuyWorker";
            this.buttonBuyWorker.Size = new System.Drawing.Size(75, 42);
            this.buttonBuyWorker.TabIndex = 6;
            this.buttonBuyWorker.Text = "30 $";
            this.buttonBuyWorker.UseVisualStyleBackColor = true;
            this.buttonBuyWorker.Click += new System.EventHandler(this.buttonBuyWorker_Click);
            // 
            // textBoxWorker
            // 
            this.textBoxWorker.BackColor = System.Drawing.Color.Goldenrod;
            this.textBoxWorker.Location = new System.Drawing.Point(101, 188);
            this.textBoxWorker.Name = "textBoxWorker";
            this.textBoxWorker.Size = new System.Drawing.Size(104, 22);
            this.textBoxWorker.TabIndex = 7;
            this.textBoxWorker.Text = "Robotnik";
            this.textBoxWorker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHowManyWorkers
            // 
            this.textBoxHowManyWorkers.Location = new System.Drawing.Point(211, 188);
            this.textBoxHowManyWorkers.Name = "textBoxHowManyWorkers";
            this.textBoxHowManyWorkers.Size = new System.Drawing.Size(75, 22);
            this.textBoxHowManyWorkers.TabIndex = 8;
            this.textBoxHowManyWorkers.Text = "0";
            this.textBoxHowManyWorkers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxWorker
            // 
            this.pictureBoxWorker.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWorker.Image")));
            this.pictureBoxWorker.Location = new System.Drawing.Point(101, 121);
            this.pictureBoxWorker.Name = "pictureBoxWorker";
            this.pictureBoxWorker.Size = new System.Drawing.Size(104, 70);
            this.pictureBoxWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWorker.TabIndex = 9;
            this.pictureBoxWorker.TabStop = false;
            // 
            // pictureBoxWagon
            // 
            this.pictureBoxWagon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWagon.Image")));
            this.pictureBoxWagon.Location = new System.Drawing.Point(101, 270);
            this.pictureBoxWagon.Name = "pictureBoxWagon";
            this.pictureBoxWagon.Size = new System.Drawing.Size(104, 76);
            this.pictureBoxWagon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWagon.TabIndex = 10;
            this.pictureBoxWagon.TabStop = false;
            // 
            // pictureBoxDiamond
            // 
            this.pictureBoxDiamond.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDiamond.Image")));
            this.pictureBoxDiamond.InitialImage = null;
            this.pictureBoxDiamond.Location = new System.Drawing.Point(967, 12);
            this.pictureBoxDiamond.Name = "pictureBoxDiamond";
            this.pictureBoxDiamond.Size = new System.Drawing.Size(79, 60);
            this.pictureBoxDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDiamond.TabIndex = 11;
            this.pictureBoxDiamond.TabStop = false;
            // 
            // textBoxDiamond
            // 
            this.textBoxDiamond.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxDiamond.Location = new System.Drawing.Point(967, 78);
            this.textBoxDiamond.Name = "textBoxDiamond";
            this.textBoxDiamond.Size = new System.Drawing.Size(79, 22);
            this.textBoxDiamond.TabIndex = 12;
            this.textBoxDiamond.Text = "0";
            this.textBoxDiamond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWagon
            // 
            this.textBoxWagon.BackColor = System.Drawing.Color.Sienna;
            this.textBoxWagon.Location = new System.Drawing.Point(101, 341);
            this.textBoxWagon.Name = "textBoxWagon";
            this.textBoxWagon.Size = new System.Drawing.Size(104, 22);
            this.textBoxWagon.TabIndex = 13;
            this.textBoxWagon.Text = "Taczka";
            this.textBoxWagon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxHowManyWagons
            // 
            this.textBoxHowManyWagons.Location = new System.Drawing.Point(211, 341);
            this.textBoxHowManyWagons.Name = "textBoxHowManyWagons";
            this.textBoxHowManyWagons.Size = new System.Drawing.Size(73, 22);
            this.textBoxHowManyWagons.TabIndex = 14;
            this.textBoxHowManyWagons.Text = "0";
            this.textBoxHowManyWagons.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuyWagon
            // 
            this.buttonBuyWagon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBuyWagon.Location = new System.Drawing.Point(211, 284);
            this.buttonBuyWagon.Name = "buttonBuyWagon";
            this.buttonBuyWagon.Size = new System.Drawing.Size(75, 42);
            this.buttonBuyWagon.TabIndex = 15;
            this.buttonBuyWagon.Text = "50 $";
            this.buttonBuyWagon.UseVisualStyleBackColor = true;
            this.buttonBuyWagon.Click += new System.EventHandler(this.buttonBuyWagon_Click);
            // 
            // buttonWagonUpgrade
            // 
            this.buttonWagonUpgrade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonWagonUpgrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWagonUpgrade.Location = new System.Drawing.Point(15, 270);
            this.buttonWagonUpgrade.Name = "buttonWagonUpgrade";
            this.buttonWagonUpgrade.Size = new System.Drawing.Size(90, 76);
            this.buttonWagonUpgrade.TabIndex = 16;
            this.buttonWagonUpgrade.Text = "Ulepszenie";
            this.buttonWagonUpgrade.UseVisualStyleBackColor = false;
            this.buttonWagonUpgrade.Click += new System.EventHandler(this.buttonWagonUpgrade_Click);
            // 
            // textBoxWagonUpgrade
            // 
            this.textBoxWagonUpgrade.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxWagonUpgrade.Location = new System.Drawing.Point(15, 341);
            this.textBoxWagonUpgrade.Name = "textBoxWagonUpgrade";
            this.textBoxWagonUpgrade.Size = new System.Drawing.Size(90, 22);
            this.textBoxWagonUpgrade.TabIndex = 17;
            this.textBoxWagonUpgrade.Text = "10 diamentów";
            // 
            // textBoxWorkerUpgrade
            // 
            this.textBoxWorkerUpgrade.BackColor = System.Drawing.Color.DarkTurquoise;
            this.textBoxWorkerUpgrade.Location = new System.Drawing.Point(15, 188);
            this.textBoxWorkerUpgrade.Name = "textBoxWorkerUpgrade";
            this.textBoxWorkerUpgrade.Size = new System.Drawing.Size(90, 22);
            this.textBoxWorkerUpgrade.TabIndex = 19;
            this.textBoxWorkerUpgrade.Text = "5 diamentów";
            // 
            // buttonWorkerUpgrade
            // 
            this.buttonWorkerUpgrade.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonWorkerUpgrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonWorkerUpgrade.Location = new System.Drawing.Point(15, 121);
            this.buttonWorkerUpgrade.Name = "buttonWorkerUpgrade";
            this.buttonWorkerUpgrade.Size = new System.Drawing.Size(90, 70);
            this.buttonWorkerUpgrade.TabIndex = 20;
            this.buttonWorkerUpgrade.Text = "Ulepszenie";
            this.buttonWorkerUpgrade.UseVisualStyleBackColor = false;
            this.buttonWorkerUpgrade.Click += new System.EventHandler(this.buttonWorkerUpgrade_Click);
            // 
            // progressBarWorkerUpgrade
            // 
            this.progressBarWorkerUpgrade.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarWorkerUpgrade.Location = new System.Drawing.Point(15, 96);
            this.progressBarWorkerUpgrade.Name = "progressBarWorkerUpgrade";
            this.progressBarWorkerUpgrade.Size = new System.Drawing.Size(90, 23);
            this.progressBarWorkerUpgrade.TabIndex = 21;
            // 
            // progressBarWagonUpgrade
            // 
            this.progressBarWagonUpgrade.Location = new System.Drawing.Point(15, 250);
            this.progressBarWagonUpgrade.Name = "progressBarWagonUpgrade";
            this.progressBarWagonUpgrade.Size = new System.Drawing.Size(90, 23);
            this.progressBarWagonUpgrade.TabIndex = 22;
            // 
            // pictureBoxTradeUnion
            // 
            this.pictureBoxTradeUnion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTradeUnion.Image")));
            this.pictureBoxTradeUnion.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTradeUnion.InitialImage")));
            this.pictureBoxTradeUnion.Location = new System.Drawing.Point(890, 217);
            this.pictureBoxTradeUnion.Name = "pictureBoxTradeUnion";
            this.pictureBoxTradeUnion.Size = new System.Drawing.Size(100, 76);
            this.pictureBoxTradeUnion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTradeUnion.TabIndex = 23;
            this.pictureBoxTradeUnion.TabStop = false;
            // 
            // progressBarTradeUnion
            // 
            this.progressBarTradeUnion.Location = new System.Drawing.Point(890, 201);
            this.progressBarTradeUnion.Name = "progressBarTradeUnion";
            this.progressBarTradeUnion.Size = new System.Drawing.Size(100, 23);
            this.progressBarTradeUnion.TabIndex = 24;
            // 
            // textBoxTradeUnion
            // 
            this.textBoxTradeUnion.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTradeUnion.Location = new System.Drawing.Point(890, 294);
            this.textBoxTradeUnion.Name = "textBoxTradeUnion";
            this.textBoxTradeUnion.Size = new System.Drawing.Size(156, 22);
            this.textBoxTradeUnion.TabIndex = 25;
            this.textBoxTradeUnion.Text = "Związki zawodowe";
            // 
            // buttonTradeUnion
            // 
            this.buttonTradeUnion.Location = new System.Drawing.Point(984, 201);
            this.buttonTradeUnion.Name = "buttonTradeUnion";
            this.buttonTradeUnion.Size = new System.Drawing.Size(62, 92);
            this.buttonTradeUnion.TabIndex = 26;
            this.buttonTradeUnion.Text = "5 diamentów";
            this.buttonTradeUnion.UseVisualStyleBackColor = true;
            this.buttonTradeUnion.Click += new System.EventHandler(this.buttonTradeUnion_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(890, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(156, 52);
            this.richTextBox1.TabIndex = 27;
            this.richTextBox1.Text = "Ulepszanie związków zawodowych zmniejsza ich potrzeby zużywania diamentów, ale za" +
    " to zwiększa na złoto. Ulepszenie kosztuje 5 diamentów.\n";
            // 
            // Kopalnia
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 569);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonTradeUnion);
            this.Controls.Add(this.textBoxTradeUnion);
            this.Controls.Add(this.progressBarTradeUnion);
            this.Controls.Add(this.pictureBoxTradeUnion);
            this.Controls.Add(this.progressBarWagonUpgrade);
            this.Controls.Add(this.progressBarWorkerUpgrade);
            this.Controls.Add(this.buttonWorkerUpgrade);
            this.Controls.Add(this.textBoxWorkerUpgrade);
            this.Controls.Add(this.textBoxWagonUpgrade);
            this.Controls.Add(this.buttonWagonUpgrade);
            this.Controls.Add(this.buttonBuyWagon);
            this.Controls.Add(this.textBoxHowManyWagons);
            this.Controls.Add(this.textBoxWagon);
            this.Controls.Add(this.textBoxDiamond);
            this.Controls.Add(this.pictureBoxDiamond);
            this.Controls.Add(this.pictureBoxWagon);
            this.Controls.Add(this.pictureBoxWorker);
            this.Controls.Add(this.textBoxHowManyWorkers);
            this.Controls.Add(this.textBoxWorker);
            this.Controls.Add(this.buttonBuyWorker);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.pictureBoxMoney);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kopalnia";
            this.Text = "Kopalnia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWagon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiamond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTradeUnion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBoxMoney;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button buttonBuyWorker;
        private System.Windows.Forms.TextBox textBoxWorker;
        private System.Windows.Forms.TextBox textBoxHowManyWorkers;
        private System.Windows.Forms.PictureBox pictureBoxWorker;
        private System.Windows.Forms.PictureBox pictureBoxWagon;
        private System.Windows.Forms.PictureBox pictureBoxDiamond;
        private System.Windows.Forms.TextBox textBoxDiamond;
        private System.Windows.Forms.TextBox textBoxWagon;
        private System.Windows.Forms.TextBox textBoxHowManyWagons;
        private System.Windows.Forms.Button buttonBuyWagon;
        private System.Windows.Forms.Button buttonWagonUpgrade;
        private System.Windows.Forms.TextBox textBoxWagonUpgrade;
        private System.Windows.Forms.TextBox textBoxWorkerUpgrade;
        private System.Windows.Forms.Button buttonWorkerUpgrade;
        private System.Windows.Forms.ProgressBar progressBarWorkerUpgrade;
        private System.Windows.Forms.ProgressBar progressBarWagonUpgrade;
        private System.Windows.Forms.PictureBox pictureBoxTradeUnion;
        private System.Windows.Forms.ProgressBar progressBarTradeUnion;
        private System.Windows.Forms.TextBox textBoxTradeUnion;
        private System.Windows.Forms.Button buttonTradeUnion;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

