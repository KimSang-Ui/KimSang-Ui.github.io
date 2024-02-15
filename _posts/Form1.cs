using System.Runtime.InteropServices;

namespace WinFormsApp_코드리뷰_스탑워치_
{
    public partial class Form1 : Form
    {
        int mil = 0;
        int sec = 0;
        int min = 0;
        int hour = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mil++;
            if (mil == 100)
            {
                sec++;
                mil = 0;
            }
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            if (min == 60)
            {
                hour++;
                min = 0;
            }
            if(mil == 10)
            {
                Thread t1 = new Thread(new ThreadStart(Run));
                t1.Start();
            }
            label2.Text = hour.ToString() + " : " + min.ToString() + " : " + sec.ToString() + " : " + mil.ToString();

        }

        void Run()
        {
            Console.WriteLine("Thread#{0}: Begin", Thread.CurrentThread.ManagedThreadId);
            // Do Something
            Beep(512, 300); // 도 0.3초
            Beep(640, 300); // 미 0.3초
            Beep(768, 300); // 솔 0.3초
            Console.WriteLine("Thread#{0}: End", Thread.CurrentThread.ManagedThreadId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mil = 0;
            sec = 0;
            min = 0;
            hour = 0;

            label2.Text = hour.ToString() + " : " + min.ToString() + " : " + sec.ToString() + " : " + mil.ToString();
        }

        [DllImport("KERNEL32.DLL")]
        extern public static void Beep(int freq, int dur);

        private void button4_Click(object sender, EventArgs e)
        {
            
            Beep(512, 300); // 도 0.3초
            Beep(640, 300); // 미 0.3초
            Beep(768, 300); // 솔 0.3초
        }
    }
}
