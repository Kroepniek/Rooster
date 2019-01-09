using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Rooster_14_12_2018_Dmon
{
	public partial class frmMainDmon : Form
	{
		Rooster roosterDmon;
		static List<Les> lesDmon = new List<Les>();

		DateTime Today = DateTime.Now;

		string leerlingNummerDmon = "";
		string wachtwoordDmon = "";

		string preLesVakDmon = "vak";
		string preLesClassDmon = "1-52";
		string preLesTeacherDmon = "teacher";

		string curLesVakDmon = "vak";
		string curLesClassDmon = "1-52";
		string curLesTeacherDmon = "teacher";

		string curLesTimeOverDmon = "00:00:00";

		bool isLesDmon = false;
		bool isPauzeDmon = false;
		bool isEndDmon = false;

		int pauzeCount = 0;

		string loginError = "";

		////////////////////////////////////////////////////////////////

		public frmMainDmon()
		{
			InitializeComponent();

			roosterDmon = GetRoosterDmon();
			roosterDmon.GetToday(Today);

			tbcTabsDmon.SelectedIndex = 0;

			lblWelcomeDmon.ForeColor = Color.FromArgb(32, 32, 32);
			btnLoginDmon.BackColor = Color.FromArgb(32, 32, 32);
			btnLoginDmon.ForeColor = Color.FromArgb(32, 32, 32);
			btnLoginDmon.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
			pnlLoginDmon.Location = new Point(pnlLoginDmon.Location.X, 170);

			lblCurLesSubjecDmon.Text = "";
			lblCurLesClassDmon.Text = "";
			lblCurLesTeacherDmon.Text = "";
			lblCurLesTimeLeftDmon.Text = "";
			lblCurLesTimeLeftDmon.Tag = "00:00:00";

			if (tmrAction_1Dmon.Tag.ToString() == "Free")
			{
				tmrAction_1Dmon.Tag = "El_1";
				tmrAction_1Dmon.Interval = 300;
				tmrAction_1Dmon.Tick += new EventHandler(FadeIn);
				tmrAction_1Dmon.Start();
			}
		}

		#region Downloading Json Rooster File

		public Rooster GetRoosterDmon()
		{
			using (WebClient wc = new WebClient())
			{
				var get = wc.DownloadString("http://kroepniek.nl/rooster.json");
				var rooster = JsonConvert.DeserializeObject<Rooster>(get.ToString());

				return rooster;
			}
		}

		public class Dag
		{
			public string Vak { get; set; }
			public string Code { get; set; }
			public string Locatie { get; set; }
			public string Van { get; set; }
			public string Tot { get; set; }
			public string Leraar { get; set; }
		}

		public class Rooster
		{
			public List<Dag> Vandaag { get; set; }
			public List<Dag> Maandag { get; set; }
			public List<Dag> Dinsdag { get; set; }
			public List<Dag> Woesdag { get; set; }
			public List<Dag> Donderdag { get; set; }
			public List<Dag> Vrijdag { get; set; }

			public void GetToday(DateTime today)
			{
				switch (today.DayOfWeek)
				{
					case DayOfWeek.Monday:
						this.Vandaag = this.Maandag;
						break;
					case DayOfWeek.Tuesday:
						this.Vandaag = this.Dinsdag;
						break;
					case DayOfWeek.Wednesday:
						this.Vandaag = this.Woesdag;
						break;
					case DayOfWeek.Thursday:
						this.Vandaag = this.Donderdag;
						break;
					case DayOfWeek.Friday:
						this.Vandaag = this.Vrijdag;
						break;
					case DayOfWeek.Saturday:
						this.Vandaag = this.Vrijdag;
						break;
					case DayOfWeek.Sunday:
						this.Vandaag = this.Vrijdag;
						break;
				}
			}
		}

		public class Les
		{
			public string Vak { get; set; }
			public string Code { get; set; }
			public string Locatie { get; set; }
			public string Van { get; set; }
			public string Tot { get; set; }
			public string Leraar { get; set; }
			public bool Status { get; set; }

			public Panel pnlLesDmon = new Panel();
			public Label lblVakDmon = new Label();
			public Label lblLocatieDmon = new Label();
			public Label lblCodeDmon = new Label();
			public Label lblLeraarDmon = new Label();
			public Label lblVanTotDmon = new Label();
			public TabPage tbpRoosterDmon = new TabPage();
			public PictureBox pcbLineDmon = new PictureBox();

			public Les(TabPage roosterPage, PictureBox line, string vak, string code, string locatie, string van, string tot, string leraar)
			{
				Vak = vak;
				Code = code;
				Locatie = locatie;
				Van = van;
				Tot = tot;
				Leraar = leraar;

				tbpRoosterDmon = roosterPage;
				pcbLineDmon = line;

				Status = false;

				Show();
			}

			public void Show()
			{
				////////// Panel

				pnlLesDmon.Parent = tbpRoosterDmon;

				int panelYPos = int.Parse((TimeSpan.Parse(Van).TotalMinutes - TimeSpan.Parse("8:45").TotalMinutes).ToString()) + 43 - (int.Parse(TimeSpan.Parse(Van).TotalMinutes.ToString()) / 30);
				panelYPos = (panelYPos > 149 ? panelYPos + 2 : panelYPos);
				panelYPos = (panelYPos > 368 ? panelYPos + 1 : panelYPos);
				pnlLesDmon.Location = new Point(90, panelYPos);

				int panelHeight = int.Parse((TimeSpan.Parse(Tot).TotalMinutes - (TimeSpan.Parse(Van).TotalMinutes)).ToString()) - (int.Parse((TimeSpan.Parse(Tot).TotalMinutes - (TimeSpan.Parse(Van).TotalMinutes)).ToString()) / 30) - 1;
				pnlLesDmon.Size = new Size(260, panelHeight);

				pnlLesDmon.BackColor = Color.FromArgb(78, 90, 96);

				pnlLesDmon.Tag = "Hidden";

				pnlLesDmon.MouseUp += new MouseEventHandler(LesClickDmon);

				pnlLesDmon.Show();

				////////// Labels

				Font fntFontDmon = new Font("Trebuchet MS", 9.75f, FontStyle.Bold);

				lblVakDmon.Parent = pnlLesDmon;
				lblVakDmon.Font = fntFontDmon;
				lblVakDmon.ForeColor = Color.White;
				if (pnlLesDmon.Size.Height < 30)
				{
					lblVakDmon.Location = new Point(15, 5);
				}
				else if (pnlLesDmon.Size.Height > 60)
				{
					lblVakDmon.Location = new Point(15, (pnlLesDmon.Size.Height - 36) / 2 - 3);
				}
				else
				{
					lblVakDmon.Location = new Point(15, (pnlLesDmon.Size.Height - 36) / 2 - 2);
				}
				lblVakDmon.AutoSize = false;
				lblVakDmon.Size = new Size(200, 18);
				lblVakDmon.Text = Vak;
				lblVakDmon.MouseUp += new MouseEventHandler(LesLabelClick);
				lblVakDmon.Show();

				lblLocatieDmon.Parent = pnlLesDmon;
				lblLocatieDmon.Font = fntFontDmon;
				lblLocatieDmon.ForeColor = Color.White;
				lblLocatieDmon.Location = new Point(15, lblVakDmon.Location.Y + lblVakDmon.Height + 5);
				lblLocatieDmon.AutoSize = false;
				lblLocatieDmon.Size = new Size(200, 18);
				lblLocatieDmon.Text = Locatie;
				lblLocatieDmon.MouseUp += new MouseEventHandler(LesLabelClick);
				lblLocatieDmon.Show();

				lblCodeDmon.Parent = pnlLesDmon;
				lblCodeDmon.Font = fntFontDmon;
				lblCodeDmon.ForeColor = Color.White;
				lblCodeDmon.Location = new Point(15, lblLocatieDmon.Location.Y + lblLocatieDmon.Height + 5);
				lblCodeDmon.AutoSize = true;
				lblCodeDmon.Text = Code + "   - ";
				lblCodeDmon.MouseUp += new MouseEventHandler(LesLabelClick);
				lblCodeDmon.Show();
				lblCodeDmon.Visible = false;

				lblLeraarDmon.Parent = pnlLesDmon;
				lblLeraarDmon.Font = fntFontDmon;
				lblLeraarDmon.ForeColor = Color.White;
				lblLeraarDmon.Location = new Point(15 + lblCodeDmon.Size.Width, lblLocatieDmon.Location.Y + lblLocatieDmon.Height + 5);
				lblLeraarDmon.AutoSize = false;
				lblLeraarDmon.Size = new Size(200, 18);
				lblLeraarDmon.Text = Leraar;
				lblLeraarDmon.MouseUp += new MouseEventHandler(LesLabelClick);
				lblLeraarDmon.Show();
				lblLeraarDmon.Visible = false;

				lblVanTotDmon.Parent = pnlLesDmon;
				lblVanTotDmon.Font = fntFontDmon;
				lblVanTotDmon.ForeColor = Color.White;
				lblVanTotDmon.Location = new Point(15, lblLeraarDmon.Location.Y + lblLeraarDmon.Height + 5);
				lblVanTotDmon.AutoSize = false;
				lblVanTotDmon.Size = new Size(200, 18);
				lblVanTotDmon.Text = Van + " - " + Tot;
				lblVanTotDmon.MouseUp += new MouseEventHandler(LesLabelClick);
				lblVanTotDmon.Show();
				lblVanTotDmon.Visible = false;
			}

			private void ClickDmon(bool hide)
			{
				if (!hide)
				{
					pnlLesDmon.Tag = pnlLesDmon.Height.ToString();

					pnlLesDmon.Height = 112;
					pnlLesDmon.Location = new Point(pnlLesDmon.Location.X + 5, pnlLesDmon.Location.Y + 5);

					lblVakDmon.Location = new Point(15, (pnlLesDmon.Size.Height - 72) / 2 - 8);
					lblLocatieDmon.Location = new Point(15, lblVakDmon.Location.Y + lblVakDmon.Height + 5);
					lblCodeDmon.Location = new Point(15, lblLocatieDmon.Location.Y + lblLocatieDmon.Height + 5);
					lblLeraarDmon.Location = new Point(15 + lblCodeDmon.Size.Width, lblLocatieDmon.Location.Y + lblLocatieDmon.Height + 5);
					lblVanTotDmon.Location = new Point(15, lblLeraarDmon.Location.Y + lblLeraarDmon.Height + 5);

					pnlLesDmon.BackColor = Color.FromArgb(51, 99, 123);
					pnlLesDmon.BringToFront();

					lblCodeDmon.Visible = true;
					lblLeraarDmon.Visible = true;
					lblVanTotDmon.Visible = true;
				}
				else
				{
					pnlLesDmon.Height = int.Parse(pnlLesDmon.Tag.ToString());

					pnlLesDmon.Location = new Point(pnlLesDmon.Location.X - 5, pnlLesDmon.Location.Y - 5);

					if (pnlLesDmon.Size.Height < 30)
					{
						lblVakDmon.Location = new Point(15, 5);
					}
					else if (pnlLesDmon.Size.Height > 60)
					{
						lblVakDmon.Location = new Point(15, (pnlLesDmon.Size.Height - 36) / 2 - 3);
					}
					else
					{
						lblVakDmon.Location = new Point(15, (pnlLesDmon.Size.Height - 36) / 2 - 2);
					}
					lblLocatieDmon.Location = new Point(15, lblVakDmon.Location.Y + lblVakDmon.Height + 5);
					lblCodeDmon.Location = new Point(15, lblLocatieDmon.Location.Y + lblLocatieDmon.Height + 5);
					lblLeraarDmon.Location = new Point(15 + lblCodeDmon.Size.Width, lblLocatieDmon.Location.Y + lblLocatieDmon.Height + 5);
					lblVanTotDmon.Location = new Point(15, lblLeraarDmon.Location.Y + lblLeraarDmon.Height + 5);

					pnlLesDmon.Tag = "Hidden";

					if(Status)
					{
						pnlLesDmon.BackColor = Color.FromArgb(12, 154, 154);
					}
					else
					{
						pnlLesDmon.BackColor = Color.FromArgb(78, 90, 96);
					}

					lblCodeDmon.Visible = false;
					lblLeraarDmon.Visible = false;
					lblVanTotDmon.Visible = false;

					pcbLineDmon.BringToFront();
				}
			}

			public void LesClickDmon(object sender, EventArgs e)
			{
				if (pnlLesDmon.Tag.ToString() == "Hidden")
				{
					foreach (Les les in lesDmon)
					{
						if (les.pnlLesDmon.Tag.ToString() != "Hidden")
						{
							les.ClickDmon(true);
						}
					}

					ClickDmon(false);
				}
				else
				{
					ClickDmon(true);
				}
			}

			public void LesLabelClick(object sender, EventArgs e)
			{
				if (pnlLesDmon.Tag.ToString() == "Hidden")
				{
					foreach (Les les in lesDmon)
					{
						if (les.pnlLesDmon.Tag.ToString() != "Hidden")
						{
							les.ClickDmon(true);
						}
					}

					ClickDmon(false);
				}
				else
				{
					ClickDmon(true);
				}
			}
		}

		#endregion

		////////////////////////////////////////////////////////////////

		private void UpdateTimeDmon(object sender, EventArgs e)
		{
			tmrClockDmon.Interval = 1000;
			Today = Today.Add(TimeSpan.Parse("00:00:01"));
			string curretTimeDmon = Today.ToString("HH:mm:ss");
			lblTimeDmon.Text = curretTimeDmon;

			UpdateUIDmon();
		}

		private void btnLoginDmon_Click(object sender, EventArgs e)
		{
			tmrAction_1Dmon.Stop();
			tmrAction_1Dmon.Tag = "Free";

			tbcTabsDmon.SelectedIndex = 1;

			Today = DateTime.Now;
			//Today = new DateTime(2018, 12, 20, 10, 44, 55);

			pauzeCount = (TimeSpan.Parse(Today.ToString("HH:mm:ss")) < TimeSpan.Parse("10:45:00") ? 0 : (TimeSpan.Parse(Today.ToString("HH:mm:ss")) < TimeSpan.Parse("12:30:00") ? 1 : (TimeSpan.Parse(Today.ToString("HH:mm:ss")) < TimeSpan.Parse("14:30:00") ? 2 : 3)));

			tmrClockDmon.Start();

			for (int i = 0; i < roosterDmon.Vandaag.Count; i++)
			{
				lesDmon.Add(new Les(tbpRoosterDmon, pcbLineDmon, roosterDmon.Vandaag[i].Vak, roosterDmon.Vandaag[i].Code, roosterDmon.Vandaag[i].Locatie, roosterDmon.Vandaag[i].Van, roosterDmon.Vandaag[i].Tot, roosterDmon.Vandaag[i].Leraar));
				this.Controls.Add(lesDmon[i].pnlLesDmon);
				lesDmon[i].pnlLesDmon.BringToFront();
			}

			pcbRoosterDmon.SendToBack();
			pcbLineDmon.BringToFront();
		}

		private void txbLeerlingnummerDmon_Leave(object sender, EventArgs e)
		{
			loginError = "";

			if (txbLeerlingnummerDmon.TextLength < 5 || txbLeerlingnummerDmon.TextLength > 6)
			{
				if (txbLeerlingnummerDmon.TextLength < 5)
				{
					loginError = "Leerlingnummer is te kort.";
				}
				else
				{
					loginError = "Leerlingnummer is te lang.";
				}
			}

			try
			{
				int checkLeerlingNum = int.Parse(txbLeerlingnummerDmon.Text);
			}
			catch (Exception)
			{
				loginError = "Leerlingnummer moet een nummer zijn.";
			}

			lblLoginErrorDmon.Text = loginError;
			txbLeerlingnummerDmon.BackColor = Color.FromArgb(200, 255, 200);
			leerlingNummerDmon = txbLeerlingnummerDmon.Text;

			if (loginError.Length > 0)
			{
				txbLeerlingnummerDmon.BackColor = Color.FromArgb(255, 200, 200);
				leerlingNummerDmon = "";
			}
		}

		private void btnLogoutDmon_Click(object sender, EventArgs e)
		{
			tmrClockDmon.Stop();

			foreach (Les les in lesDmon)
			{
				les.pnlLesDmon.SendToBack();
			}

			lblWelcomeDmon.ForeColor = Color.FromArgb(32, 32, 32);
			btnLoginDmon.BackColor = Color.FromArgb(32, 32, 32);
			btnLoginDmon.ForeColor = Color.FromArgb(32, 32, 32);
			btnLoginDmon.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 32, 32);
			pnlLoginDmon.Location = new Point(pnlLoginDmon.Location.X, 170);

			tbcTabsDmon.SelectedIndex = 0;

			if (tmrAction_1Dmon.Tag.ToString() == "Free")
			{
				tmrAction_1Dmon.Tag = "El_1";
				tmrAction_1Dmon.Interval = 300;
				tmrAction_1Dmon.Tick += new EventHandler(FadeIn);
				tmrAction_1Dmon.Start();
			}
		}

		private void FadeIn(object sender, EventArgs e)
		{
			tmrAction_1Dmon.Interval = 1;

			byte r = lblWelcomeDmon.ForeColor.R;
			byte g = lblWelcomeDmon.ForeColor.G;
			byte b = lblWelcomeDmon.ForeColor.B;

			if (lblWelcomeDmon.ForeColor.R < 253)
			{
				lblWelcomeDmon.ForeColor = Color.FromArgb(r + 2, g + 2, b + 2);
			}

			if (lblWelcomeDmon.ForeColor.R > 160)
			{
				tmrAction_1Dmon.Tag = "El_2";
			}

			if (tmrAction_1Dmon.Tag.ToString() == "El_2")
			{
				byte br = btnLoginDmon.BackColor.R;
				byte bg = btnLoginDmon.BackColor.G;
				byte bb = btnLoginDmon.BackColor.B;

				byte fr = btnLoginDmon.ForeColor.R;
				byte fg = btnLoginDmon.ForeColor.G;
				byte fb = btnLoginDmon.ForeColor.B;

				if (btnLoginDmon.BackColor.G < 154)
				{
					btnLoginDmon.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, bg + 1, bb + 1);
					btnLoginDmon.BackColor = Color.FromArgb(12, bg + 1, bb + 1);
				}

				if (btnLoginDmon.ForeColor.R < 253)
				{
					btnLoginDmon.ForeColor = Color.FromArgb(fr + 2, fg + 2, fb + 2);
				}
				else
				{
					tmrAction_1Dmon.Tag = "El_3";
				}
			}

			if (tmrAction_1Dmon.Tag.ToString() == "El_3")
			{
				int xPos = pnlLoginDmon.Location.X;
				int yPos = pnlLoginDmon.Location.Y;

				if (pnlLoginDmon.Location.Y < 300)
				{
					pnlLoginDmon.Location = new Point(xPos, yPos + 6);
				}
				else
				{
					btnLoginDmon.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 178, 178);
					btnLoginDmon.BackColor = Color.FromArgb(12, 154, 154);
					btnLoginDmon.ForeColor = Color.FromArgb(255, 255, 255);
					tmrAction_1Dmon.Stop();
					tmrAction_1Dmon.Tag = "Free";
					tmrAction_1Dmon.Tick -= (FadeIn);
				}
			}
		}

		private void AvatarHoverDmon(object sender, EventArgs e)
		{

			btnChangeAvatarDmon.BringToFront();
			btnChangeAvatarDmon.Enabled = true;
			pcbAvatarDmon.Visible = false;
		}

		private void AvatarLeaveDmon(object sender, EventArgs e)
		{
			pcbAvatarDmon.BringToFront();
			btnChangeAvatarDmon.Enabled = false;
			pcbAvatarDmon.Visible = true;
		}

		private void ntiRoosterDmon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			//this.Activate();
			ntiRoosterDmon.BalloonTipTitle = "Tijd over:";
			ntiRoosterDmon.BalloonTipText = curLesTimeOverDmon;
			ntiRoosterDmon.ShowBalloonTip(4000);
		}

		private void frmMainDmon_FormClosing(object sender, FormClosingEventArgs e)
		{
			ntiRoosterDmon.Dispose();
		}

		////////////////////////////////////////////////////////////////

		private void CheckLogin()
		{
			//SqlConnection conn = new SqlConnection();
			//conn.ConnectionString = "Data Source=http://vserver307.axc.nl;Initial Catalog=gameworld;User ID=danieqn307_root;Password=qwerty123";
			//;
			//conn.Open();

			//// use the connection here

			//conn.Close();
			//conn.Dipose();
		}

		public void UpdateUIDmon()
		{
			UpdateLineDmon();

			preLesVakDmon = curLesVakDmon;
			preLesClassDmon = curLesClassDmon;
			preLesTeacherDmon = curLesTeacherDmon;

			int lesCountDmon = roosterDmon.Vandaag.Count;

			isLesDmon = false;

			TimeSpan startDmon = TimeSpan.Parse("8:30");
			TimeSpan startLesDmon = TimeSpan.Parse("8:30");
			TimeSpan endLesDmon = TimeSpan.Parse("9:00");
			TimeSpan endDmon = TimeSpan.Parse("17:15");

			string endMessageDmon = "End of the day";

			int curLesDmon = 0;

			for (int i = 0; i < lesCountDmon; i++)
			{
				startDmon = new TimeSpan(TimeSpan.Parse(roosterDmon.Vandaag[0].Van).Hours, TimeSpan.Parse(roosterDmon.Vandaag[0].Van).Minutes, 0);
				startLesDmon = new TimeSpan(TimeSpan.Parse(roosterDmon.Vandaag[i].Van).Hours, TimeSpan.Parse(roosterDmon.Vandaag[i].Van).Minutes, 0);
				endLesDmon = new TimeSpan(TimeSpan.Parse(roosterDmon.Vandaag[i].Tot).Hours, TimeSpan.Parse(roosterDmon.Vandaag[i].Tot).Minutes, 0);
				endDmon = new TimeSpan(TimeSpan.Parse(roosterDmon.Vandaag[lesCountDmon - 1].Tot).Hours, TimeSpan.Parse(roosterDmon.Vandaag[lesCountDmon - 1].Tot).Minutes, 0);

				if ((TimeSpan.Compare(TimeSpan.Parse(Today.Hour + ":" + Today.Minute + ":" + Today.Second), startLesDmon) == 1 && TimeSpan.Compare(endLesDmon, TimeSpan.Parse(Today.Hour + ":" + Today.Minute + ":" + Today.Second)) == 1) || (TimeSpan.Compare(TimeSpan.Parse(Today.Hour + ":" + Today.Minute + ":" + Today.Second), startLesDmon) == 0 || TimeSpan.Compare(TimeSpan.Parse(Today.Hour + ":" + Today.Minute + ":" + Today.Second), endLesDmon) == 0))
				{
					curLesDmon = i;
					isLesDmon = true;
					isEndDmon = false;
					i = lesCountDmon;
				}
				else
				{
					isLesDmon = false;
				}
				
				if (!isLesDmon)
				{
					curLesDmon = 0;

					if ((TimeSpan.Compare(TimeSpan.Parse(Today.Hour + ":" + Today.Minute + ":" + Today.Second), endDmon) == 1 || TimeSpan.Compare(startDmon, TimeSpan.Parse(Today.Hour + ":" + Today.Minute + ":" + Today.Second)) == 1) && !isLesDmon)
					{
						isEndDmon = true;

						if (TimeSpan.Compare(TimeSpan.Parse(Today.Hour + ":" + Today.Minute), startLesDmon) == -1)
						{
							lblCurLesClassDmon.Location = new Point(605, 388);
							lblCurLesClassDmon.Size = new Size(140, 48);
							endMessageDmon = "Wait for the new day";
						}
						else
						{
							lblCurLesClassDmon.Location = new Point(605, 400);
							lblCurLesClassDmon.Size = new Size(140, 24);
							endMessageDmon = "End of the day";
						}
					}
				}
			}

			string todayVakDmon = "";
			string todayClassDmon = "";
			string todayTeacherDmon = "";
			string todayTimeOverDmon = "";

			todayVakDmon = roosterDmon.Vandaag[curLesDmon].Vak;
			todayClassDmon = roosterDmon.Vandaag[curLesDmon].Locatie;
			todayTeacherDmon = roosterDmon.Vandaag[curLesDmon].Leraar;
			todayTimeOverDmon = (TimeSpan.Parse(roosterDmon.Vandaag[curLesDmon].Tot) - TimeSpan.Parse(Today.Hour + ":" + Today.Minute + ":" + Today.Second)).ToString();

			curLesVakDmon = todayVakDmon;
			curLesClassDmon = todayClassDmon;
			curLesTeacherDmon = todayTeacherDmon;
			curLesTimeOverDmon = todayTimeOverDmon;

			if (isPauzeDmon)
			{
				if (isLesDmon)
				{
					lblCurLesTimeLeftDmon.Tag = "00:00:00";
					isPauzeDmon = false;
				}
				else
				{
					isLesDmon = false;
					lblCurLesTimeLeftDmon.Tag = "PAUZE";
				}
			}

			if (curLesTimeOverDmon == "00:00:00")
			{
				lblCurLesTimeLeftDmon.Tag = curLesTimeOverDmon;
				lblCurLesTimeLeftDmon.Text = curLesTimeOverDmon;
				isLesDmon = false;
			}

			if (lblCurLesTimeLeftDmon.Tag.ToString() == "00:00:00")
			{
				preLesVakDmon = curLesVakDmon;
				preLesClassDmon = curLesClassDmon;
				preLesTeacherDmon = curLesTeacherDmon;

				if (isLesDmon)
				{
					ntiRoosterDmon.BalloonTipTitle = "Nu les:";
					ntiRoosterDmon.BalloonTipText = curLesVakDmon + " in het lokaal " + curLesClassDmon + " met " + curLesTeacherDmon + ".";
					ntiRoosterDmon.ShowBalloonTip(4000);

					lblCurLesTimeLeftDmon.Tag = "";
					pcbPlattegrondDmon.Image = (Image)Properties.Resources.ResourceManager.GetObject("rst_" + curLesClassDmon.Substring(1, 1) + "-" + curLesClassDmon.Substring(3));

					lblCurLesClassDmon.ForeColor = Color.FromArgb(255, 255, 255);

					lblCurLesSubjecDmon.Text = curLesVakDmon;
					lblCurLesClassDmon.Text = curLesClassDmon;
					lblCurLesTeacherDmon.Text = curLesTeacherDmon;

					foreach (Les les in lesDmon)
					{
						les.pnlLesDmon.BackColor = Color.FromArgb(78, 90, 96);
						les.Status = false;
					}

					lesDmon[curLesDmon].pnlLesDmon.BackColor = Color.FromArgb(12, 154, 154);
					lesDmon[curLesDmon].Status = true;
				}
				else if (!isLesDmon)
				{
					if (isEndDmon)
					{
						lblCurLesTimeLeftDmon.Tag = "";
						pcbPlattegrondDmon.Image = (Image)Properties.Resources.ResourceManager.GetObject("rst_bg");

						lblCurLesClassDmon.ForeColor = Color.FromArgb(64, 64, 64);

						lblCurLesSubjecDmon.Text = "";
						lblCurLesClassDmon.Text = endMessageDmon;
						lblCurLesTeacherDmon.Text = "";
						lblCurLesTeacherDmon.Text = "";
						lblCurLesTimeLeftDmon.Text = "";
					}
					else
					{
						if (isPauzeDmon)
						{
							pauzeCount = (pauzeCount == 3 ? 0 : pauzeCount);
							pauzeCount++;

							ntiRoosterDmon.BalloonTipTitle = "De les is voorbij.";
							ntiRoosterDmon.BalloonTipText = "Het is pauze tot " + (pauzeCount == 1 ? "11:00." : (pauzeCount == 2 ? "13:00." : "14:45."));
							ntiRoosterDmon.ShowBalloonTip(4000);

							pcbPlattegrondDmon.Image = (Image)Properties.Resources.ResourceManager.GetObject("rst_bg");

							lblCurLesClassDmon.ForeColor = Color.FromArgb(255, 32, 32);

							lblCurLesSubjecDmon.Text = "";
							lblCurLesClassDmon.Text = "Pauze";
							lblCurLesTeacherDmon.Text = "";
							lblCurLesTimeLeftDmon.Text = "";
						}
						else
						{
							ntiRoosterDmon.BalloonTipTitle = "De les is voorbij.";

							lblCurLesSubjecDmon.Text = "";
							lblCurLesClassDmon.Text = "";
							lblCurLesTeacherDmon.Text = "";
							lblCurLesTimeLeftDmon.Text = "";
						}
					}
				}
			}

			if (isLesDmon)
			{
				isEndDmon = false;
				lblCurLesTimeLeftDmon.Text = curLesTimeOverDmon;
				ntiRoosterDmon.Text = "Rooster " + curLesTimeOverDmon;
			}
		}

		public void UpdateLineDmon()
		{
			try
			{
				int linePos = 496 - int.Parse(new TimeSpan(17, 0, 0).Subtract(new TimeSpan(Today.Hour, Today.Minute, 0)).TotalMinutes.ToString());

				linePos = linePos - (linePos / 30);
				
				linePos = (linePos / 30 > 3 ? linePos + 1 : linePos);
				linePos = (linePos / 30 > 10 ? linePos + 2 : linePos);

				if (linePos <= 26) throw new Exception("Start");
				if (linePos >= 493) throw new Exception("End");

				pcbLineDmon.Location = new Point(26, linePos + 25);
				pcbLineDmon.BringToFront();
			}
			catch (Exception e)
			{
				if (e.Message == "End")
				{
					pcbLineDmon.Location = new Point(26, 518);
				}
				else
				{
					pcbLineDmon.Location = new Point(26, 26);
				}
			}
		}
	}
}
