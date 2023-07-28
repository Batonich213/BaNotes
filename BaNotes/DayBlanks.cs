using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaNotes
{
    public partial class DayBlanks : UserControl
    {
        private DateTime _currentDate;
        public DayBlanks()
        {
            InitializeComponent();
        }

        public void Refresh(Color backColor, int day, DateTime date, Color foreColor)
        {
            BackColor = backColor;
            this.dayNum.Text = day.ToString();
            _currentDate = date;
            if (_currentDate.ToShortDateString() == DateTime.Now.ToShortDateString())
            {

                BackColor = Color.FromArgb(222, 255, 159, 67);
            }
            dayNum.ForeColor = foreColor;
        }

    }
}
