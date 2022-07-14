using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_Wforms
{
    public partial class Form_MainCalendar : Form
    {
        public Form_MainCalendar()
        {
            InitializeComponent();
        }



        private void MainCalendar_Load(object sender, EventArgs e)
        {
            //
            DisplayDays();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    


        #region Functions

        private void DisplayDays()
        {
            DateTime currentTime = DateTime.Now;
            
            //get fist day of the month
            DateTime thisMonthFirstDay = new DateTime(currentTime.Year, currentTime.Month, 1);

            //get number of day of the current month
            int currentMonthLenght = DateTime.DaysInMonth(thisMonthFirstDay.Year, thisMonthFirstDay.Month);

            
            int pastDayOfTheWeek = Convert.ToInt32(thisMonthFirstDay.DayOfWeek.ToString("d"));


            //display blank(for now) slots for past days of this month
            for (int i = 0; i < pastDayOfTheWeek; i++)
            {
                BlankUserControl blankSlot = new BlankUserControl();

                FLPnl_DaySlotsContainer.Controls.Add(blankSlot);
            }

        }

        #endregion


    }
}
