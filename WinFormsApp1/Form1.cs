namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
       
        private void TimerExample()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();           
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString(" HH:mm:ss");

            var BritishZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
            DateTime dt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
            DateTime db = TimeZoneInfo.ConvertTime(dt, TimeZoneInfo.Utc, BritishZone);

            label3.Text = db.TimeOfDay.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resource1.baku;
            TimerExample();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resource1.london;
            TimerExample();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                int btnWidth = 187;
                int btnHeight = 46;

                int x = Random.Shared.Next(0, Width - btnWidth);
                int y = Random.Shared.Next(0, Height - btnHeight);

                btn.AutoSize = true;
                btn.Text = "Click me)";
                btn.Size = new Size(94, 23);
                btn.Name = "btn_Dispose";
                btn.Location = new Point(x, y);
                btn.Font = new Font("Georgia", 10.2F);
               
                btn.MouseHover += button3_MouseHover;
                Controls.Add(btn);
            }
        }

    }
}