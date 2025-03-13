namespace Wahadlo_projekt
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSimulate = new System.Windows.Forms.Button();
            this.tbTimeDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLength1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAngle1 = new System.Windows.Forms.TextBox();
            this.gbPendulum1 = new System.Windows.Forms.GroupBox();
            this.trbAngle1 = new System.Windows.Forms.TrackBar();
            this.trbLength1 = new System.Windows.Forms.TrackBar();
            this.trbMass1 = new System.Windows.Forms.TrackBar();
            this.tbMass1 = new System.Windows.Forms.TextBox();
            this.btStopSimulation = new System.Windows.Forms.Button();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.tbG = new System.Windows.Forms.TrackBar();
            this.tbB = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbPendulum2 = new System.Windows.Forms.GroupBox();
            this.trbAngle2 = new System.Windows.Forms.TrackBar();
            this.trbLength2 = new System.Windows.Forms.TrackBar();
            this.trbMass2 = new System.Windows.Forms.TrackBar();
            this.tbLength2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMass2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAngle2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btSaveGraphic = new System.Windows.Forms.Button();
            this.tbCatologPath = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDarkBg = new System.Windows.Forms.RadioButton();
            this.rbBrightBg = new System.Windows.Forms.RadioButton();
            this.gbPendulum1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbAngle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLength1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).BeginInit();
            this.gbPendulum2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbAngle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLength2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMass2)).BeginInit();
            this.gbColor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSimulate
            // 
            this.btSimulate.Location = new System.Drawing.Point(995, 436);
            this.btSimulate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSimulate.Name = "btSimulate";
            this.btSimulate.Size = new System.Drawing.Size(173, 28);
            this.btSimulate.TabIndex = 4;
            this.btSimulate.Text = "Symuluj";
            this.btSimulate.UseVisualStyleBackColor = true;
            this.btSimulate.Click += new System.EventHandler(this.btSimualte_Click);
            // 
            // tbTimeDuration
            // 
            this.tbTimeDuration.Location = new System.Drawing.Point(880, 28);
            this.tbTimeDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTimeDuration.Name = "tbTimeDuration";
            this.tbTimeDuration.Size = new System.Drawing.Size(132, 22);
            this.tbTimeDuration.TabIndex = 5;
            this.tbTimeDuration.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(876, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Czas (ms)";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(880, 60);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(400, 369);
            this.panel.TabIndex = 8;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Długość";
            // 
            // tbLength1
            // 
            this.tbLength1.Location = new System.Drawing.Point(21, 47);
            this.tbLength1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLength1.Name = "tbLength1";
            this.tbLength1.ReadOnly = true;
            this.tbLength1.Size = new System.Drawing.Size(64, 22);
            this.tbLength1.TabIndex = 9;
            this.tbLength1.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Masa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Kąt";
            // 
            // tbAngle1
            // 
            this.tbAngle1.Location = new System.Drawing.Point(21, 167);
            this.tbAngle1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAngle1.Name = "tbAngle1";
            this.tbAngle1.ReadOnly = true;
            this.tbAngle1.Size = new System.Drawing.Size(64, 22);
            this.tbAngle1.TabIndex = 21;
            this.tbAngle1.Text = "90";
            // 
            // gbPendulum1
            // 
            this.gbPendulum1.Controls.Add(this.trbAngle1);
            this.gbPendulum1.Controls.Add(this.trbLength1);
            this.gbPendulum1.Controls.Add(this.trbMass1);
            this.gbPendulum1.Controls.Add(this.tbLength1);
            this.gbPendulum1.Controls.Add(this.label1);
            this.gbPendulum1.Controls.Add(this.tbMass1);
            this.gbPendulum1.Controls.Add(this.label3);
            this.gbPendulum1.Controls.Add(this.tbAngle1);
            this.gbPendulum1.Controls.Add(this.label10);
            this.gbPendulum1.Location = new System.Drawing.Point(63, 33);
            this.gbPendulum1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPendulum1.Name = "gbPendulum1";
            this.gbPendulum1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPendulum1.Size = new System.Drawing.Size(300, 218);
            this.gbPendulum1.TabIndex = 27;
            this.gbPendulum1.TabStop = false;
            this.gbPendulum1.Text = "Wahadło 1";
            // 
            // trbAngle1
            // 
            this.trbAngle1.Location = new System.Drawing.Point(93, 148);
            this.trbAngle1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbAngle1.Maximum = 180;
            this.trbAngle1.Minimum = -180;
            this.trbAngle1.Name = "trbAngle1";
            this.trbAngle1.Size = new System.Drawing.Size(200, 56);
            this.trbAngle1.TabIndex = 90;
            this.trbAngle1.Value = 20;
            this.trbAngle1.Scroll += new System.EventHandler(this.trbAngle1_Scroll);
            // 
            // trbLength1
            // 
            this.trbLength1.Location = new System.Drawing.Point(93, 27);
            this.trbLength1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbLength1.Maximum = 80;
            this.trbLength1.Minimum = 10;
            this.trbLength1.Name = "trbLength1";
            this.trbLength1.Size = new System.Drawing.Size(200, 56);
            this.trbLength1.TabIndex = 43;
            this.trbLength1.Value = 50;
            this.trbLength1.Scroll += new System.EventHandler(this.trbLength1_Scroll);
            // 
            // trbMass1
            // 
            this.trbMass1.Location = new System.Drawing.Point(93, 87);
            this.trbMass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbMass1.Maximum = 50;
            this.trbMass1.Minimum = 1;
            this.trbMass1.Name = "trbMass1";
            this.trbMass1.Size = new System.Drawing.Size(200, 56);
            this.trbMass1.TabIndex = 42;
            this.trbMass1.Value = 20;
            this.trbMass1.Scroll += new System.EventHandler(this.trbMass1_Scroll);
            // 
            // tbMass1
            // 
            this.tbMass1.Location = new System.Drawing.Point(21, 107);
            this.tbMass1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMass1.Name = "tbMass1";
            this.tbMass1.ReadOnly = true;
            this.tbMass1.Size = new System.Drawing.Size(64, 22);
            this.tbMass1.TabIndex = 11;
            this.tbMass1.Text = "20";
            // 
            // btStopSimulation
            // 
            this.btStopSimulation.Enabled = false;
            this.btStopSimulation.Location = new System.Drawing.Point(995, 472);
            this.btStopSimulation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btStopSimulation.Name = "btStopSimulation";
            this.btStopSimulation.Size = new System.Drawing.Size(173, 28);
            this.btStopSimulation.TabIndex = 35;
            this.btStopSimulation.Text = "Stop";
            this.btStopSimulation.UseVisualStyleBackColor = true;
            this.btStopSimulation.Click += new System.EventHandler(this.btStopSimulation_Click);
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(113, 22);
            this.tbR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbR.Maximum = 255;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(217, 56);
            this.tbR.TabIndex = 36;
            this.tbR.Value = 255;
            this.tbR.Scroll += new System.EventHandler(this.tbR_Scroll);
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(113, 82);
            this.tbG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbG.Maximum = 255;
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(217, 56);
            this.tbG.TabIndex = 37;
            this.tbG.Scroll += new System.EventHandler(this.tbG_Scroll);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(113, 143);
            this.tbB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbB.Maximum = 255;
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(217, 56);
            this.tbB.TabIndex = 38;
            this.tbB.Scroll += new System.EventHandler(this.tbB_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Czerwony:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Zielony:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 143);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "Niebieski:";
            // 
            // gbPendulum2
            // 
            this.gbPendulum2.Controls.Add(this.trbAngle2);
            this.gbPendulum2.Controls.Add(this.trbLength2);
            this.gbPendulum2.Controls.Add(this.trbMass2);
            this.gbPendulum2.Controls.Add(this.tbLength2);
            this.gbPendulum2.Controls.Add(this.label5);
            this.gbPendulum2.Controls.Add(this.tbMass2);
            this.gbPendulum2.Controls.Add(this.label9);
            this.gbPendulum2.Controls.Add(this.tbAngle2);
            this.gbPendulum2.Controls.Add(this.label11);
            this.gbPendulum2.Location = new System.Drawing.Point(371, 33);
            this.gbPendulum2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPendulum2.Name = "gbPendulum2";
            this.gbPendulum2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPendulum2.Size = new System.Drawing.Size(300, 218);
            this.gbPendulum2.TabIndex = 91;
            this.gbPendulum2.TabStop = false;
            this.gbPendulum2.Text = "Wahadło 2";
            // 
            // trbAngle2
            // 
            this.trbAngle2.Location = new System.Drawing.Point(93, 148);
            this.trbAngle2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbAngle2.Maximum = 180;
            this.trbAngle2.Minimum = -180;
            this.trbAngle2.Name = "trbAngle2";
            this.trbAngle2.Size = new System.Drawing.Size(200, 56);
            this.trbAngle2.TabIndex = 110;
            this.trbAngle2.Value = 20;
            this.trbAngle2.Scroll += new System.EventHandler(this.trbAngle2_Scroll);
            // 
            // trbLength2
            // 
            this.trbLength2.Location = new System.Drawing.Point(93, 27);
            this.trbLength2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbLength2.Maximum = 80;
            this.trbLength2.Minimum = 10;
            this.trbLength2.Name = "trbLength2";
            this.trbLength2.Size = new System.Drawing.Size(200, 56);
            this.trbLength2.TabIndex = 43;
            this.trbLength2.Value = 50;
            this.trbLength2.Scroll += new System.EventHandler(this.trbLength2_Scroll);
            // 
            // trbMass2
            // 
            this.trbMass2.Location = new System.Drawing.Point(93, 87);
            this.trbMass2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trbMass2.Maximum = 50;
            this.trbMass2.Minimum = 1;
            this.trbMass2.Name = "trbMass2";
            this.trbMass2.Size = new System.Drawing.Size(200, 56);
            this.trbMass2.TabIndex = 42;
            this.trbMass2.Value = 10;
            this.trbMass2.Scroll += new System.EventHandler(this.trbMass2_Scroll);
            // 
            // tbLength2
            // 
            this.tbLength2.Location = new System.Drawing.Point(21, 47);
            this.tbLength2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLength2.Name = "tbLength2";
            this.tbLength2.ReadOnly = true;
            this.tbLength2.Size = new System.Drawing.Size(64, 22);
            this.tbLength2.TabIndex = 9;
            this.tbLength2.Text = "50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Długość";
            // 
            // tbMass2
            // 
            this.tbMass2.Location = new System.Drawing.Point(21, 107);
            this.tbMass2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMass2.Name = "tbMass2";
            this.tbMass2.ReadOnly = true;
            this.tbMass2.Size = new System.Drawing.Size(64, 22);
            this.tbMass2.TabIndex = 11;
            this.tbMass2.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Masa";
            // 
            // tbAngle2
            // 
            this.tbAngle2.Location = new System.Drawing.Point(21, 167);
            this.tbAngle2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAngle2.Name = "tbAngle2";
            this.tbAngle2.ReadOnly = true;
            this.tbAngle2.Size = new System.Drawing.Size(64, 22);
            this.tbAngle2.TabIndex = 21;
            this.tbAngle2.Text = "110";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kąt";
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.panelColor);
            this.gbColor.Controls.Add(this.label6);
            this.gbColor.Controls.Add(this.tbR);
            this.gbColor.Controls.Add(this.label8);
            this.gbColor.Controls.Add(this.tbG);
            this.gbColor.Controls.Add(this.label7);
            this.gbColor.Controls.Add(this.tbB);
            this.gbColor.Location = new System.Drawing.Point(63, 258);
            this.gbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbColor.Name = "gbColor";
            this.gbColor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbColor.Size = new System.Drawing.Size(445, 213);
            this.gbColor.TabIndex = 92;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Kolor lini";
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Red;
            this.panelColor.Location = new System.Drawing.Point(367, 23);
            this.panelColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(49, 175);
            this.panelColor.TabIndex = 42;
            // 
            // btSaveGraphic
            // 
            this.btSaveGraphic.Enabled = false;
            this.btSaveGraphic.Location = new System.Drawing.Point(995, 508);
            this.btSaveGraphic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSaveGraphic.Name = "btSaveGraphic";
            this.btSaveGraphic.Size = new System.Drawing.Size(173, 28);
            this.btSaveGraphic.TabIndex = 94;
            this.btSaveGraphic.Text = "Zapisz Obraz";
            this.btSaveGraphic.UseVisualStyleBackColor = true;
            this.btSaveGraphic.Click += new System.EventHandler(this.btSaveGraphic_Click);
            // 
            // tbCatologPath
            // 
            this.tbCatologPath.Location = new System.Drawing.Point(930, 586);
            this.tbCatologPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCatologPath.Name = "tbCatologPath";
            this.tbCatologPath.Size = new System.Drawing.Size(237, 22);
            this.tbCatologPath.TabIndex = 95;
            this.tbCatologPath.Text = "X:\\c#\\obrazy";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(926, 567);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 16);
            this.label12.TabIndex = 96;
            this.label12.Text = "Adres katologu do zapisu zdjęć";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1172, 567);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 16);
            this.label13.TabIndex = 98;
            this.label13.Text = "Nazwa obrazu";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(1176, 586);
            this.tbFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(111, 22);
            this.tbFileName.TabIndex = 97;
            this.tbFileName.Text = "obraz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDarkBg);
            this.groupBox1.Controls.Add(this.rbBrightBg);
            this.groupBox1.Location = new System.Drawing.Point(516, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(155, 213);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kolor tła";
            // 
            // rbDarkBg
            // 
            this.rbDarkBg.AutoSize = true;
            this.rbDarkBg.Location = new System.Drawing.Point(9, 53);
            this.rbDarkBg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDarkBg.Name = "rbDarkBg";
            this.rbDarkBg.Size = new System.Drawing.Size(98, 20);
            this.rbDarkBg.TabIndex = 1;
            this.rbDarkBg.Text = "Tło ciemne";
            this.rbDarkBg.UseVisualStyleBackColor = true;
            this.rbDarkBg.CheckedChanged += new System.EventHandler(this.rbDarkBg_CheckedChanged);
            // 
            // rbBrightBg
            // 
            this.rbBrightBg.AutoSize = true;
            this.rbBrightBg.Checked = true;
            this.rbBrightBg.Location = new System.Drawing.Point(9, 25);
            this.rbBrightBg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBrightBg.Name = "rbBrightBg";
            this.rbBrightBg.Size = new System.Drawing.Size(87, 20);
            this.rbBrightBg.TabIndex = 0;
            this.rbBrightBg.TabStop = true;
            this.rbBrightBg.Text = "Tło jasne";
            this.rbBrightBg.UseVisualStyleBackColor = true;
            this.rbBrightBg.CheckedChanged += new System.EventHandler(this.rbBrightBg_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 691);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbCatologPath);
            this.Controls.Add(this.btSaveGraphic);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbPendulum2);
            this.Controls.Add(this.btStopSimulation);
            this.Controls.Add(this.gbPendulum1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTimeDuration);
            this.Controls.Add(this.btSimulate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPendulum1.ResumeLayout(false);
            this.gbPendulum1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbAngle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLength1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbB)).EndInit();
            this.gbPendulum2.ResumeLayout(false);
            this.gbPendulum2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbAngle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbLength2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMass2)).EndInit();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSimulate;
        private System.Windows.Forms.TextBox tbTimeDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLength1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAngle1;
        private System.Windows.Forms.GroupBox gbPendulum1;
        private System.Windows.Forms.Button btStopSimulation;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.TrackBar tbG;
        private System.Windows.Forms.TrackBar tbB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trbMass1;
        private System.Windows.Forms.TextBox tbMass1;
        private System.Windows.Forms.TrackBar trbAngle1;
        private System.Windows.Forms.TrackBar trbLength1;
        private System.Windows.Forms.GroupBox gbPendulum2;
        private System.Windows.Forms.TrackBar trbAngle2;
        private System.Windows.Forms.TrackBar trbLength2;
        private System.Windows.Forms.TrackBar trbMass2;
        private System.Windows.Forms.TextBox tbLength2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMass2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAngle2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btSaveGraphic;
        private System.Windows.Forms.TextBox tbCatologPath;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDarkBg;
        private System.Windows.Forms.RadioButton rbBrightBg;
    }
}

