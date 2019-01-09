namespace Rooster_14_12_2018_Dmon
{
	partial class frmMainDmon
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainDmon));
			this.lblNameDmon = new System.Windows.Forms.Label();
			this.lblLeerlingNmrDmon = new System.Windows.Forms.Label();
			this.tmrAction_1Dmon = new System.Windows.Forms.Timer(this.components);
			this.tmrClockDmon = new System.Windows.Forms.Timer(this.components);
			this.lblTimeDmon = new System.Windows.Forms.Label();
			this.pcbLineDmon = new System.Windows.Forms.PictureBox();
			this.pcbPlattegrondDmon = new System.Windows.Forms.PictureBox();
			this.pcbAvatarDmon = new System.Windows.Forms.PictureBox();
			this.pcbRoosterDmon = new System.Windows.Forms.PictureBox();
			this.lblCurLesSubjectLblDmon = new System.Windows.Forms.Label();
			this.lblCurLesTeacherLblDmon = new System.Windows.Forms.Label();
			this.lblCurLesClassLblDmon = new System.Windows.Forms.Label();
			this.lblCurLesSubjecDmon = new System.Windows.Forms.Label();
			this.lblCurLesClassDmon = new System.Windows.Forms.Label();
			this.lblCurLesTeacherDmon = new System.Windows.Forms.Label();
			this.lblCurLesTimeLeftLblDmon = new System.Windows.Forms.Label();
			this.lblCurLesTimeLeftDmon = new System.Windows.Forms.Label();
			this.lblKlasDmon = new System.Windows.Forms.Label();
			this.tbcTabsDmon = new System.Windows.Forms.TabControl();
			this.tbpLoginDmon = new System.Windows.Forms.TabPage();
			this.pnlLoginDmon = new System.Windows.Forms.Panel();
			this.btnLoginDmon = new System.Windows.Forms.Button();
			this.txbPasswordDmon = new System.Windows.Forms.TextBox();
			this.lblPasswordDmon = new System.Windows.Forms.Label();
			this.lblNickNameDmon = new System.Windows.Forms.Label();
			this.lblWelcomeDmon = new System.Windows.Forms.Label();
			this.txbLeerlingnummerDmon = new System.Windows.Forms.TextBox();
			this.tbpRoosterDmon = new System.Windows.Forms.TabPage();
			this.btnLogoutDmon = new System.Windows.Forms.Button();
			this.btnChangeAvatarDmon = new System.Windows.Forms.Button();
			this.ntiRoosterDmon = new System.Windows.Forms.NotifyIcon(this.components);
			this.lblLoginErrorDmon = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pcbLineDmon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbPlattegrondDmon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbAvatarDmon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbRoosterDmon)).BeginInit();
			this.tbcTabsDmon.SuspendLayout();
			this.tbpLoginDmon.SuspendLayout();
			this.pnlLoginDmon.SuspendLayout();
			this.tbpRoosterDmon.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNameDmon
			// 
			this.lblNameDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblNameDmon.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNameDmon.ForeColor = System.Drawing.Color.White;
			this.lblNameDmon.Location = new System.Drawing.Point(400, 40);
			this.lblNameDmon.Name = "lblNameDmon";
			this.lblNameDmon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblNameDmon.Size = new System.Drawing.Size(245, 18);
			this.lblNameDmon.TabIndex = 1;
			this.lblNameDmon.Text = "Daniel Mondzielewski";
			// 
			// lblLeerlingNmrDmon
			// 
			this.lblLeerlingNmrDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblLeerlingNmrDmon.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLeerlingNmrDmon.ForeColor = System.Drawing.Color.White;
			this.lblLeerlingNmrDmon.Location = new System.Drawing.Point(400, 60);
			this.lblLeerlingNmrDmon.Name = "lblLeerlingNmrDmon";
			this.lblLeerlingNmrDmon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblLeerlingNmrDmon.Size = new System.Drawing.Size(242, 18);
			this.lblLeerlingNmrDmon.TabIndex = 1;
			this.lblLeerlingNmrDmon.Text = "81630";
			// 
			// tmrAction_1Dmon
			// 
			this.tmrAction_1Dmon.Tag = "Free";
			// 
			// tmrClockDmon
			// 
			this.tmrClockDmon.Interval = 1;
			this.tmrClockDmon.Tick += new System.EventHandler(this.UpdateTimeDmon);
			// 
			// lblTimeDmon
			// 
			this.lblTimeDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblTimeDmon.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimeDmon.ForeColor = System.Drawing.Color.White;
			this.lblTimeDmon.Location = new System.Drawing.Point(435, 190);
			this.lblTimeDmon.Name = "lblTimeDmon";
			this.lblTimeDmon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblTimeDmon.Size = new System.Drawing.Size(125, 29);
			this.lblTimeDmon.TabIndex = 1;
			this.lblTimeDmon.Text = "24:59:59";
			this.lblTimeDmon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pcbLineDmon
			// 
			this.pcbLineDmon.Image = global::Rooster_14_12_2018_Dmon.Properties.Resources.line;
			this.pcbLineDmon.Location = new System.Drawing.Point(26, 26);
			this.pcbLineDmon.Name = "pcbLineDmon";
			this.pcbLineDmon.Size = new System.Drawing.Size(348, 1);
			this.pcbLineDmon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbLineDmon.TabIndex = 4;
			this.pcbLineDmon.TabStop = false;
			// 
			// pcbPlattegrondDmon
			// 
			this.pcbPlattegrondDmon.Image = global::Rooster_14_12_2018_Dmon.Properties.Resources.rst_bg;
			this.pcbPlattegrondDmon.Location = new System.Drawing.Point(400, 177);
			this.pcbPlattegrondDmon.Name = "pcbPlattegrondDmon";
			this.pcbPlattegrondDmon.Size = new System.Drawing.Size(360, 343);
			this.pcbPlattegrondDmon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbPlattegrondDmon.TabIndex = 3;
			this.pcbPlattegrondDmon.TabStop = false;
			// 
			// pcbAvatarDmon
			// 
			this.pcbAvatarDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.pcbAvatarDmon.Image = global::Rooster_14_12_2018_Dmon.Properties.Resources.avatar;
			this.pcbAvatarDmon.Location = new System.Drawing.Point(660, 25);
			this.pcbAvatarDmon.Name = "pcbAvatarDmon";
			this.pcbAvatarDmon.Size = new System.Drawing.Size(100, 100);
			this.pcbAvatarDmon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbAvatarDmon.TabIndex = 2;
			this.pcbAvatarDmon.TabStop = false;
			this.pcbAvatarDmon.MouseHover += new System.EventHandler(this.AvatarHoverDmon);
			// 
			// pcbRoosterDmon
			// 
			this.pcbRoosterDmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbRoosterDmon.Image = global::Rooster_14_12_2018_Dmon.Properties.Resources.rooster_bg;
			this.pcbRoosterDmon.Location = new System.Drawing.Point(25, 25);
			this.pcbRoosterDmon.Name = "pcbRoosterDmon";
			this.pcbRoosterDmon.Size = new System.Drawing.Size(350, 495);
			this.pcbRoosterDmon.TabIndex = 0;
			this.pcbRoosterDmon.TabStop = false;
			// 
			// lblCurLesSubjectLblDmon
			// 
			this.lblCurLesSubjectLblDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurLesSubjectLblDmon.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurLesSubjectLblDmon.ForeColor = System.Drawing.Color.White;
			this.lblCurLesSubjectLblDmon.Location = new System.Drawing.Point(510, 360);
			this.lblCurLesSubjectLblDmon.Name = "lblCurLesSubjectLblDmon";
			this.lblCurLesSubjectLblDmon.Size = new System.Drawing.Size(57, 24);
			this.lblCurLesSubjectLblDmon.TabIndex = 1;
			this.lblCurLesSubjectLblDmon.Text = "Vak:";
			// 
			// lblCurLesTeacherLblDmon
			// 
			this.lblCurLesTeacherLblDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurLesTeacherLblDmon.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurLesTeacherLblDmon.ForeColor = System.Drawing.Color.White;
			this.lblCurLesTeacherLblDmon.Location = new System.Drawing.Point(510, 440);
			this.lblCurLesTeacherLblDmon.Name = "lblCurLesTeacherLblDmon";
			this.lblCurLesTeacherLblDmon.Size = new System.Drawing.Size(74, 24);
			this.lblCurLesTeacherLblDmon.TabIndex = 1;
			this.lblCurLesTeacherLblDmon.Text = "Leraar:";
			// 
			// lblCurLesClassLblDmon
			// 
			this.lblCurLesClassLblDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurLesClassLblDmon.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurLesClassLblDmon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
			this.lblCurLesClassLblDmon.Location = new System.Drawing.Point(510, 400);
			this.lblCurLesClassLblDmon.Name = "lblCurLesClassLblDmon";
			this.lblCurLesClassLblDmon.Size = new System.Drawing.Size(74, 24);
			this.lblCurLesClassLblDmon.TabIndex = 1;
			this.lblCurLesClassLblDmon.Text = "Lokaal:";
			// 
			// lblCurLesSubjecDmon
			// 
			this.lblCurLesSubjecDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurLesSubjecDmon.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurLesSubjecDmon.ForeColor = System.Drawing.Color.White;
			this.lblCurLesSubjecDmon.Location = new System.Drawing.Point(573, 364);
			this.lblCurLesSubjecDmon.Name = "lblCurLesSubjecDmon";
			this.lblCurLesSubjecDmon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurLesSubjecDmon.Size = new System.Drawing.Size(175, 16);
			this.lblCurLesSubjecDmon.TabIndex = 1;
			this.lblCurLesSubjecDmon.Text = "Web Development -Front end";
			// 
			// lblCurLesClassDmon
			// 
			this.lblCurLesClassDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurLesClassDmon.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurLesClassDmon.ForeColor = System.Drawing.Color.White;
			this.lblCurLesClassDmon.Location = new System.Drawing.Point(605, 400);
			this.lblCurLesClassDmon.Name = "lblCurLesClassDmon";
			this.lblCurLesClassDmon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurLesClassDmon.Size = new System.Drawing.Size(140, 24);
			this.lblCurLesClassDmon.TabIndex = 1;
			this.lblCurLesClassDmon.Text = "1.46b";
			// 
			// lblCurLesTeacherDmon
			// 
			this.lblCurLesTeacherDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurLesTeacherDmon.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurLesTeacherDmon.ForeColor = System.Drawing.Color.White;
			this.lblCurLesTeacherDmon.Location = new System.Drawing.Point(605, 444);
			this.lblCurLesTeacherDmon.Name = "lblCurLesTeacherDmon";
			this.lblCurLesTeacherDmon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurLesTeacherDmon.Size = new System.Drawing.Size(140, 18);
			this.lblCurLesTeacherDmon.TabIndex = 1;
			this.lblCurLesTeacherDmon.Text = "B. Porobic";
			// 
			// lblCurLesTimeLeftLblDmon
			// 
			this.lblCurLesTimeLeftLblDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurLesTimeLeftLblDmon.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurLesTimeLeftLblDmon.ForeColor = System.Drawing.Color.White;
			this.lblCurLesTimeLeftLblDmon.Location = new System.Drawing.Point(510, 480);
			this.lblCurLesTimeLeftLblDmon.Name = "lblCurLesTimeLeftLblDmon";
			this.lblCurLesTimeLeftLblDmon.Size = new System.Drawing.Size(110, 24);
			this.lblCurLesTimeLeftLblDmon.TabIndex = 1;
			this.lblCurLesTimeLeftLblDmon.Text = "Tijd over:";
			// 
			// lblCurLesTimeLeftDmon
			// 
			this.lblCurLesTimeLeftDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblCurLesTimeLeftDmon.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurLesTimeLeftDmon.ForeColor = System.Drawing.Color.White;
			this.lblCurLesTimeLeftDmon.Location = new System.Drawing.Point(635, 480);
			this.lblCurLesTimeLeftDmon.Name = "lblCurLesTimeLeftDmon";
			this.lblCurLesTimeLeftDmon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurLesTimeLeftDmon.Size = new System.Drawing.Size(110, 24);
			this.lblCurLesTimeLeftDmon.TabIndex = 1;
			this.lblCurLesTimeLeftDmon.Text = "00:00:00";
			// 
			// lblKlasDmon
			// 
			this.lblKlasDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblKlasDmon.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKlasDmon.ForeColor = System.Drawing.Color.White;
			this.lblKlasDmon.Location = new System.Drawing.Point(400, 80);
			this.lblKlasDmon.Name = "lblKlasDmon";
			this.lblKlasDmon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblKlasDmon.Size = new System.Drawing.Size(242, 18);
			this.lblKlasDmon.TabIndex = 1;
			this.lblKlasDmon.Text = "IC.18AO.b";
			// 
			// tbcTabsDmon
			// 
			this.tbcTabsDmon.Controls.Add(this.tbpLoginDmon);
			this.tbcTabsDmon.Controls.Add(this.tbpRoosterDmon);
			this.tbcTabsDmon.Location = new System.Drawing.Point(-4, -22);
			this.tbcTabsDmon.Name = "tbcTabsDmon";
			this.tbcTabsDmon.SelectedIndex = 0;
			this.tbcTabsDmon.Size = new System.Drawing.Size(792, 572);
			this.tbcTabsDmon.TabIndex = 5;
			this.tbcTabsDmon.TabStop = false;
			// 
			// tbpLoginDmon
			// 
			this.tbpLoginDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tbpLoginDmon.Controls.Add(this.pnlLoginDmon);
			this.tbpLoginDmon.Controls.Add(this.txbPasswordDmon);
			this.tbpLoginDmon.Controls.Add(this.lblPasswordDmon);
			this.tbpLoginDmon.Controls.Add(this.lblNickNameDmon);
			this.tbpLoginDmon.Controls.Add(this.lblWelcomeDmon);
			this.tbpLoginDmon.Controls.Add(this.txbLeerlingnummerDmon);
			this.tbpLoginDmon.Location = new System.Drawing.Point(4, 22);
			this.tbpLoginDmon.Name = "tbpLoginDmon";
			this.tbpLoginDmon.Padding = new System.Windows.Forms.Padding(3);
			this.tbpLoginDmon.Size = new System.Drawing.Size(784, 546);
			this.tbpLoginDmon.TabIndex = 0;
			this.tbpLoginDmon.Text = "Login";
			// 
			// pnlLoginDmon
			// 
			this.pnlLoginDmon.Controls.Add(this.btnLoginDmon);
			this.pnlLoginDmon.Controls.Add(this.lblLoginErrorDmon);
			this.pnlLoginDmon.Location = new System.Drawing.Point(142, 370);
			this.pnlLoginDmon.Name = "pnlLoginDmon";
			this.pnlLoginDmon.Size = new System.Drawing.Size(500, 150);
			this.pnlLoginDmon.TabIndex = 3;
			// 
			// btnLoginDmon
			// 
			this.btnLoginDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
			this.btnLoginDmon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
			this.btnLoginDmon.FlatAppearance.BorderSize = 0;
			this.btnLoginDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoginDmon.Font = new System.Drawing.Font("Trebuchet MS", 17F, System.Drawing.FontStyle.Bold);
			this.btnLoginDmon.ForeColor = System.Drawing.Color.White;
			this.btnLoginDmon.Location = new System.Drawing.Point(180, 0);
			this.btnLoginDmon.Name = "btnLoginDmon";
			this.btnLoginDmon.Size = new System.Drawing.Size(140, 40);
			this.btnLoginDmon.TabIndex = 1;
			this.btnLoginDmon.TabStop = false;
			this.btnLoginDmon.Text = "Login";
			this.btnLoginDmon.UseVisualStyleBackColor = false;
			this.btnLoginDmon.Click += new System.EventHandler(this.btnLoginDmon_Click);
			// 
			// txbPasswordDmon
			// 
			this.txbPasswordDmon.BackColor = System.Drawing.Color.White;
			this.txbPasswordDmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbPasswordDmon.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
			this.txbPasswordDmon.Location = new System.Drawing.Point(399, 230);
			this.txbPasswordDmon.MaximumSize = new System.Drawing.Size(140, 34);
			this.txbPasswordDmon.MinimumSize = new System.Drawing.Size(2, 34);
			this.txbPasswordDmon.Name = "txbPasswordDmon";
			this.txbPasswordDmon.PasswordChar = '●';
			this.txbPasswordDmon.Size = new System.Drawing.Size(140, 35);
			this.txbPasswordDmon.TabIndex = 2;
			this.txbPasswordDmon.TabStop = false;
			this.txbPasswordDmon.Text = "81630";
			// 
			// lblPasswordDmon
			// 
			this.lblPasswordDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.lblPasswordDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblPasswordDmon.ForeColor = System.Drawing.Color.White;
			this.lblPasswordDmon.Location = new System.Drawing.Point(245, 230);
			this.lblPasswordDmon.Name = "lblPasswordDmon";
			this.lblPasswordDmon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblPasswordDmon.Size = new System.Drawing.Size(154, 34);
			this.lblPasswordDmon.TabIndex = 0;
			this.lblPasswordDmon.Text = "Wachtwoord: ";
			this.lblPasswordDmon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblNickNameDmon
			// 
			this.lblNickNameDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
			this.lblNickNameDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblNickNameDmon.ForeColor = System.Drawing.Color.White;
			this.lblNickNameDmon.Location = new System.Drawing.Point(245, 180);
			this.lblNickNameDmon.Name = "lblNickNameDmon";
			this.lblNickNameDmon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblNickNameDmon.Size = new System.Drawing.Size(154, 34);
			this.lblNickNameDmon.TabIndex = 0;
			this.lblNickNameDmon.Text = "Leerlingnummer: ";
			this.lblNickNameDmon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblWelcomeDmon
			// 
			this.lblWelcomeDmon.Font = new System.Drawing.Font("Trebuchet MS", 34F, System.Drawing.FontStyle.Bold);
			this.lblWelcomeDmon.ForeColor = System.Drawing.Color.White;
			this.lblWelcomeDmon.Location = new System.Drawing.Point(282, 90);
			this.lblWelcomeDmon.Name = "lblWelcomeDmon";
			this.lblWelcomeDmon.Size = new System.Drawing.Size(220, 80);
			this.lblWelcomeDmon.TabIndex = 0;
			this.lblWelcomeDmon.Text = "Welkom";
			this.lblWelcomeDmon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txbLeerlingnummerDmon
			// 
			this.txbLeerlingnummerDmon.BackColor = System.Drawing.Color.White;
			this.txbLeerlingnummerDmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txbLeerlingnummerDmon.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold);
			this.txbLeerlingnummerDmon.Location = new System.Drawing.Point(399, 180);
			this.txbLeerlingnummerDmon.MaximumSize = new System.Drawing.Size(140, 34);
			this.txbLeerlingnummerDmon.MinimumSize = new System.Drawing.Size(2, 34);
			this.txbLeerlingnummerDmon.Name = "txbLeerlingnummerDmon";
			this.txbLeerlingnummerDmon.Size = new System.Drawing.Size(140, 35);
			this.txbLeerlingnummerDmon.TabIndex = 2;
			this.txbLeerlingnummerDmon.TabStop = false;
			this.txbLeerlingnummerDmon.Text = "81630";
			this.txbLeerlingnummerDmon.Leave += new System.EventHandler(this.txbLeerlingnummerDmon_Leave);
			// 
			// tbpRoosterDmon
			// 
			this.tbpRoosterDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.tbpRoosterDmon.Controls.Add(this.btnLogoutDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblCurLesSubjectLblDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblTimeDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblCurLesTimeLeftDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblCurLesTeacherDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblCurLesTimeLeftLblDmon);
			this.tbpRoosterDmon.Controls.Add(this.pcbLineDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblCurLesClassDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblCurLesTeacherLblDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblCurLesSubjecDmon);
			this.tbpRoosterDmon.Controls.Add(this.pcbRoosterDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblCurLesClassLblDmon);
			this.tbpRoosterDmon.Controls.Add(this.pcbAvatarDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblNameDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblLeerlingNmrDmon);
			this.tbpRoosterDmon.Controls.Add(this.lblKlasDmon);
			this.tbpRoosterDmon.Controls.Add(this.pcbPlattegrondDmon);
			this.tbpRoosterDmon.Controls.Add(this.btnChangeAvatarDmon);
			this.tbpRoosterDmon.Location = new System.Drawing.Point(4, 22);
			this.tbpRoosterDmon.Name = "tbpRoosterDmon";
			this.tbpRoosterDmon.Padding = new System.Windows.Forms.Padding(3);
			this.tbpRoosterDmon.Size = new System.Drawing.Size(784, 546);
			this.tbpRoosterDmon.TabIndex = 1;
			this.tbpRoosterDmon.Text = "Rooster";
			// 
			// btnLogoutDmon
			// 
			this.btnLogoutDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
			this.btnLogoutDmon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
			this.btnLogoutDmon.FlatAppearance.BorderSize = 0;
			this.btnLogoutDmon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
			this.btnLogoutDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogoutDmon.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
			this.btnLogoutDmon.ForeColor = System.Drawing.Color.White;
			this.btnLogoutDmon.Location = new System.Drawing.Point(660, 125);
			this.btnLogoutDmon.Name = "btnLogoutDmon";
			this.btnLogoutDmon.Size = new System.Drawing.Size(100, 28);
			this.btnLogoutDmon.TabIndex = 5;
			this.btnLogoutDmon.Text = "Uitloggen";
			this.btnLogoutDmon.UseVisualStyleBackColor = false;
			this.btnLogoutDmon.Click += new System.EventHandler(this.btnLogoutDmon_Click);
			// 
			// btnChangeAvatarDmon
			// 
			this.btnChangeAvatarDmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.btnChangeAvatarDmon.Enabled = false;
			this.btnChangeAvatarDmon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.btnChangeAvatarDmon.FlatAppearance.BorderSize = 0;
			this.btnChangeAvatarDmon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(104)))), ((int)(((byte)(104)))));
			this.btnChangeAvatarDmon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
			this.btnChangeAvatarDmon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangeAvatarDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.btnChangeAvatarDmon.ForeColor = System.Drawing.Color.White;
			this.btnChangeAvatarDmon.Location = new System.Drawing.Point(660, 25);
			this.btnChangeAvatarDmon.Name = "btnChangeAvatarDmon";
			this.btnChangeAvatarDmon.Size = new System.Drawing.Size(100, 100);
			this.btnChangeAvatarDmon.TabIndex = 6;
			this.btnChangeAvatarDmon.TabStop = false;
			this.btnChangeAvatarDmon.Text = "Avatar wijzigen";
			this.btnChangeAvatarDmon.UseVisualStyleBackColor = false;
			this.btnChangeAvatarDmon.MouseLeave += new System.EventHandler(this.AvatarLeaveDmon);
			// 
			// ntiRoosterDmon
			// 
			this.ntiRoosterDmon.BalloonTipText = "Text testowy";
			this.ntiRoosterDmon.BalloonTipTitle = "Title testowy";
			this.ntiRoosterDmon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntiRoosterDmon.Icon")));
			this.ntiRoosterDmon.Text = "Rooster";
			this.ntiRoosterDmon.Visible = true;
			this.ntiRoosterDmon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntiRoosterDmon_MouseDoubleClick);
			// 
			// lblLoginErrorDmon
			// 
			this.lblLoginErrorDmon.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
			this.lblLoginErrorDmon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lblLoginErrorDmon.Location = new System.Drawing.Point(103, 56);
			this.lblLoginErrorDmon.Name = "lblLoginErrorDmon";
			this.lblLoginErrorDmon.Size = new System.Drawing.Size(294, 90);
			this.lblLoginErrorDmon.TabIndex = 4;
			// 
			// frmMainDmon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(784, 546);
			this.Controls.Add(this.tbcTabsDmon);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmMainDmon";
			this.Text = "Rooster";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainDmon_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pcbLineDmon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbPlattegrondDmon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbAvatarDmon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbRoosterDmon)).EndInit();
			this.tbcTabsDmon.ResumeLayout(false);
			this.tbpLoginDmon.ResumeLayout(false);
			this.tbpLoginDmon.PerformLayout();
			this.pnlLoginDmon.ResumeLayout(false);
			this.tbpRoosterDmon.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbRoosterDmon;
		private System.Windows.Forms.Label lblNameDmon;
		private System.Windows.Forms.PictureBox pcbAvatarDmon;
		private System.Windows.Forms.Label lblLeerlingNmrDmon;
		private System.Windows.Forms.PictureBox pcbPlattegrondDmon;
		private System.Windows.Forms.Timer tmrAction_1Dmon;
		private System.Windows.Forms.Timer tmrClockDmon;
		private System.Windows.Forms.Label lblTimeDmon;
		private System.Windows.Forms.PictureBox pcbLineDmon;
		private System.Windows.Forms.Label lblCurLesSubjectLblDmon;
		private System.Windows.Forms.Label lblCurLesTeacherLblDmon;
		private System.Windows.Forms.Label lblCurLesClassLblDmon;
		private System.Windows.Forms.Label lblCurLesSubjecDmon;
		private System.Windows.Forms.Label lblCurLesClassDmon;
		private System.Windows.Forms.Label lblCurLesTeacherDmon;
		private System.Windows.Forms.Label lblCurLesTimeLeftLblDmon;
		private System.Windows.Forms.Label lblCurLesTimeLeftDmon;
		private System.Windows.Forms.Label lblKlasDmon;
		private System.Windows.Forms.TabControl tbcTabsDmon;
		private System.Windows.Forms.TabPage tbpLoginDmon;
		private System.Windows.Forms.TabPage tbpRoosterDmon;
		private System.Windows.Forms.Label lblWelcomeDmon;
		private System.Windows.Forms.Button btnLoginDmon;
		private System.Windows.Forms.NotifyIcon ntiRoosterDmon;
		private System.Windows.Forms.Button btnLogoutDmon;
		private System.Windows.Forms.Button btnChangeAvatarDmon;
		private System.Windows.Forms.TextBox txbLeerlingnummerDmon;
		private System.Windows.Forms.Label lblNickNameDmon;
		private System.Windows.Forms.TextBox txbPasswordDmon;
		private System.Windows.Forms.Label lblPasswordDmon;
		private System.Windows.Forms.Panel pnlLoginDmon;
		private System.Windows.Forms.Label lblLoginErrorDmon;
	}
}

