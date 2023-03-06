using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using EasyExploits;
using EzSploit_REBORN.UserControls;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using KrnlAPI;

namespace EzSploit_REBORN;

public class Form1 : Form
{
	public DiscordRpcClient client;

	private WebClient webClient = new WebClient();

	private KrnlApi ezsploitkrnl = new KrnlApi();

	private Module ezsploitex = new Module();

	private IContainer components;

	private Panel panel1;

	private System.Windows.Forms.Button button2;

	private System.Windows.Forms.Button button1;

	private Label label3;

	private Label label2;

	private Label label1;

	private System.Windows.Forms.Button button11;

	private Guna2Button guna2Button1;

	private Guna2Button guna2Button3;

	private Guna2Button guna2Button2;

	private Panel panel2;

	private Guna2Button guna2Button6;

	private Guna2Button guna2Button5;

	private Guna2Button guna2Button4;

	private Guna2DragControl guna2DragControl1;

	private Label label4;

	private Label label5;

	private Guna2Button guna2Button8;

	private Guna2Button guna2Button7;

	private Label label7;

	private Label label6;

	private Guna2AnimateWindow guna2AnimateWindow1;

	public Form1()
	{
		InitializeComponent();
		if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\Configs"))
		{
			Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Configs");
			Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Scripts");
			using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt"))
			{
			}
			using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt"))
			{
			}
			using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt"))
			{
			}
			File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt", "classic");
			File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "WeAreDevs");
			webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/WeAreDevs_API.dll", "c:\\mikusdevPrograms\\ezsploit\\WeAreDevs_API.dll");
			webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EasyExploits.dll", "c:\\mikusdevPrograms\\ezsploit\\EasyExploits.dll");
			webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/KrnlAPI.dll", "c:\\mikusdevPrograms\\ezsploit\\KrnlAPI.dll");
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/krnl.dll", "c:\\mikusdevPrograms\\ezsploit\\krnl.dll");
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/injector.dll", "c:\\mikusdevPrograms\\ezsploit\\injector.dll");
        }
	}

	private void addUserControl(UserControl userControl)
	{
		userControl.Dock = DockStyle.Fill;
		panel2.Controls.Clear();
		panel2.Controls.Add(userControl);
		userControl.BringToFront();
	}

	private void guna2Button4_Click(object sender, EventArgs e)
	{
		uc_home userControl = new uc_home();
		addUserControl(userControl);
	}

	private void guna2Button6_Click(object sender, EventArgs e)
	{
		uc_options userControl = new uc_options();
		addUserControl(userControl);
	}

	private void guna2Button5_Click(object sender, EventArgs e)
	{
		uc_info userControl = new uc_info();
		addUserControl(userControl);
	}

	private void guna2ImageButton1_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button7_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void guna2Button8_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	private void guna2PictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void panel2_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EzSploit_REBORN.Form1));
		this.panel1 = new System.Windows.Forms.Panel();
		this.label5 = new System.Windows.Forms.Label();
		this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
		this.label4 = new System.Windows.Forms.Label();
		this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
		this.button11 = new System.Windows.Forms.Button();
		this.label3 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label1 = new System.Windows.Forms.Label();
		this.button2 = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
		this.panel2 = new System.Windows.Forms.Panel();
		this.label7 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
		this.panel1.SuspendLayout();
		this.panel2.SuspendLayout();
		base.SuspendLayout();
		this.panel1.Controls.Add(this.label5);
		this.panel1.Controls.Add(this.guna2Button8);
		this.panel1.Controls.Add(this.guna2Button7);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.guna2Button6);
		this.panel1.Controls.Add(this.guna2Button5);
		this.panel1.Controls.Add(this.guna2Button4);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(773, 45);
		this.panel1.TabIndex = 2;
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.Red;
		this.label5.Location = new System.Drawing.Point(413, 9);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(22, 13);
		this.label5.TabIndex = 6;
		this.label5.Text = "V4";
		this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.guna2Button8.ForeColor = System.Drawing.Color.Yellow;
		this.guna2Button8.Location = new System.Drawing.Point(685, 3);
		this.guna2Button8.Name = "guna2Button8";
		this.guna2Button8.Size = new System.Drawing.Size(35, 35);
		this.guna2Button8.TabIndex = 5;
		this.guna2Button8.Text = "-";
		this.guna2Button8.Click += new System.EventHandler(guna2Button8_Click);
		this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.guna2Button7.ForeColor = System.Drawing.Color.Red;
		this.guna2Button7.Location = new System.Drawing.Point(726, 3);
		this.guna2Button7.Name = "guna2Button7";
		this.guna2Button7.Size = new System.Drawing.Size(35, 35);
		this.guna2Button7.TabIndex = 4;
		this.guna2Button7.Text = "X";
		this.guna2Button7.Click += new System.EventHandler(guna2Button7_Click);
		this.label4.AutoSize = true;
		this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.Color.White;
		this.label4.Location = new System.Drawing.Point(342, 9);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(74, 20);
		this.label4.TabIndex = 3;
		this.label4.Text = "ezSploit";
		this.label4.Click += new System.EventHandler(label4_Click);
		this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
		this.guna2Button6.CheckedState.CustomBorderColor = System.Drawing.Color.Magenta;
		this.guna2Button6.CheckedState.FillColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.guna2Button6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
		this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button6.ForeColor = System.Drawing.Color.White;
		this.guna2Button6.Location = new System.Drawing.Point(83, 0);
		this.guna2Button6.Name = "guna2Button6";
		this.guna2Button6.Size = new System.Drawing.Size(82, 45);
		this.guna2Button6.TabIndex = 2;
		this.guna2Button6.Text = "Options";
		this.guna2Button6.Click += new System.EventHandler(guna2Button6_Click);
		this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
		this.guna2Button5.CheckedState.CustomBorderColor = System.Drawing.Color.Magenta;
		this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.guna2Button5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
		this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button5.ForeColor = System.Drawing.Color.White;
		this.guna2Button5.Location = new System.Drawing.Point(166, 0);
		this.guna2Button5.Name = "guna2Button5";
		this.guna2Button5.Size = new System.Drawing.Size(82, 45);
		this.guna2Button5.TabIndex = 1;
		this.guna2Button5.Text = "Info";
		this.guna2Button5.Click += new System.EventHandler(guna2Button5_Click);
		this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
		this.guna2Button4.CheckedState.CustomBorderColor = System.Drawing.Color.Magenta;
		this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
		this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button4.ForeColor = System.Drawing.Color.White;
		this.guna2Button4.Location = new System.Drawing.Point(0, 0);
		this.guna2Button4.Name = "guna2Button4";
		this.guna2Button4.Size = new System.Drawing.Size(82, 45);
		this.guna2Button4.TabIndex = 0;
		this.guna2Button4.Text = "Main";
		this.guna2Button4.Click += new System.EventHandler(guna2Button4_Click);
		this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button1.ForeColor = System.Drawing.Color.White;
		this.guna2Button1.Location = new System.Drawing.Point(0, 0);
		this.guna2Button1.Name = "guna2Button1";
		this.guna2Button1.Size = new System.Drawing.Size(180, 45);
		this.guna2Button1.TabIndex = 0;
		this.button11.Location = new System.Drawing.Point(0, 0);
		this.button11.Name = "button11";
		this.button11.Size = new System.Drawing.Size(75, 23);
		this.button11.TabIndex = 0;
		this.label3.Location = new System.Drawing.Point(0, 0);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(100, 23);
		this.label3.TabIndex = 0;
		this.label2.Location = new System.Drawing.Point(0, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(100, 23);
		this.label2.TabIndex = 0;
		this.label1.Location = new System.Drawing.Point(0, 0);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(100, 23);
		this.label1.TabIndex = 0;
		this.button2.Location = new System.Drawing.Point(0, 0);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(75, 23);
		this.button2.TabIndex = 0;
		this.button1.Location = new System.Drawing.Point(0, 0);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(75, 23);
		this.button1.TabIndex = 0;
		this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button2.ForeColor = System.Drawing.Color.White;
		this.guna2Button2.Location = new System.Drawing.Point(0, 0);
		this.guna2Button2.Name = "guna2Button2";
		this.guna2Button2.Size = new System.Drawing.Size(180, 45);
		this.guna2Button2.TabIndex = 0;
		this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button3.ForeColor = System.Drawing.Color.White;
		this.guna2Button3.Location = new System.Drawing.Point(0, 0);
		this.guna2Button3.Name = "guna2Button3";
		this.guna2Button3.Size = new System.Drawing.Size(180, 45);
		this.guna2Button3.TabIndex = 0;
		this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
		this.guna2DragControl1.TargetControl = this.panel1;
		this.guna2DragControl1.UseTransparentDrag = true;
		this.panel2.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.panel2.Controls.Add(this.label7);
		this.panel2.Controls.Add(this.label6);
		this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel2.Location = new System.Drawing.Point(0, 45);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(773, 405);
		this.panel2.TabIndex = 1;
		this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(panel2_Paint);
		this.label7.AutoSize = true;
		this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
		this.label7.Location = new System.Drawing.Point(18, 380);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(70, 13);
		this.label7.TabIndex = 1;
		this.label7.Text = "by mikusDEV";
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
		this.label6.Location = new System.Drawing.Point(13, 7);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(637, 125);
		this.label6.TabIndex = 0;
		this.label6.Text = "Select tab and start exploiting :)\r\n\r\nif you are using EzSploit first time, \r\nI reccomend you to go to options tab and hit Update button.\r\nThis will fix injecting errors";
		this.label6.Click += new System.EventHandler(label6_Click);
		this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
		this.guna2AnimateWindow1.Interval = 800;
		this.guna2AnimateWindow1.TargetForm = this;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
		base.ClientSize = new System.Drawing.Size(773, 450);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Form1";
		this.Text = "EzSploit V4";
		base.Load += new System.EventHandler(Form1_Load);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		base.ResumeLayout(false);
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button9_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click(object sender, EventArgs e)
	{
	}

	private void label6_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		client = new DiscordRpcClient("1078735530654707772");
		client.Logger = new ConsoleLogger
		{
			Level = LogLevel.Warning
		};
		client.OnReady += delegate(object sender, ReadyMessage e)
		{
			Console.WriteLine("Received Ready from user {0}", e.User.Username);
		};
		client.OnPresenceUpdate += delegate(object sender, PresenceMessage e)
		{
			Console.WriteLine("Received Update! {0}", e.Presence);
		};
		client.Initialize();
		client.SetPresence(new RichPresence
		{
			Details = "Roblox Script Executor",
			State = " ",
			Timestamps = Timestamps.Now,
			Assets = new Assets
			{
				LargeImageKey = "https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/ezico.png"
			},
			Buttons = new DiscordRPC.Button[1]
			{
				new DiscordRPC.Button
				{
					Label = "Download",
					Url = "https://sites.google.com/view/mksdv/gry-i-pliki/ezsploit"
				}
			}
		});
	}
}
