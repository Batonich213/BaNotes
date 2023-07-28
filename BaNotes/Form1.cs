using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace BaNotes
{
    public partial class Form1 : Form
    {
        private readonly  Color HOLIDAY_COLOR = Color.FromArgb(85, 238, 82, 83);
        private readonly  Color DAY_COLOR = Color.FromArgb(85, 246, 242, 242);
        private readonly  Color PREVIOUS_MONTH_DAY_COLOR = Color.FromArgb(35, 34, 47, 62);

        public Form1()
        {
            InitializeComponent();
            DisplayDays(DateTime.Now);
            new List<Control> { codeeloGradientPanel1 }.ForEach(x => x.MouseDown += (s, a) =>
            {
                x.Capture = false; Capture = false;
                Message m = Message.Create(Handle,0xA1, new IntPtr(2), IntPtr.Zero);
                base.WndProc(ref m);


            });



        }
        private void DisplayDays(DateTime date)
        {
            var now = date;
            var previousMonth = date.AddMonths(-1);
            var startOfTheMonth = new DateTime(now.Year, now.Month, 1);
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int previousMonthDays = DateTime.DaysInMonth(previousMonth.Year, previousMonth.Month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) == 0 ? 7 : Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            dayOfTheWeek = dayOfTheWeek == 1 ? 8 : dayOfTheWeek;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                (tableLayoutPanel1.Controls[42 - i] as DayBlanks).Refresh(PREVIOUS_MONTH_DAY_COLOR, (previousMonthDays - dayOfTheWeek + i + 1), new DateTime(previousMonth.Year, previousMonth.Month, (previousMonthDays - dayOfTheWeek + i + 1)), Color.LightGray);
            }


        }

    }
}
