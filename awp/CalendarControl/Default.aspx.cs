using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalendarControl
{
    public partial class _Default : Page
    {
        protected void Calendar1_DayRender(object sender,
        DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 24 && e.Day.Date.Month == 12)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
                Label lbl = new Label();
                lbl.Text = "<br>Winter vacation Start: 24 - 12 - 2020";
                e.Cell.Controls.Add(lbl);
                Image g1 = new Image();
                g1.ImageUrl = "https://cdn.travelpulse.com/images/99999999-9999-9999-9999-999999999999/5712ea02-89d7-e611-9aa9-0050568e420d/630x355.jpg";
                g1.Height = 20;
                g1.Width = 20;
                e.Cell.Controls.Add(g1);

            }
            if (e.Day.Date.Day == 1 && e.Day.Date.Month == 1)
            {
                Calendar1.SelectedDate = new DateTime(2020, 1, 1);
                Calendar1.SelectedDates.SelectRange(Calendar1.SelectedDate,
                Calendar1.SelectedDate.AddDays(10));
                Label lbl1 = new Label();
                lbl1.Text = "<br>New Year";
                e.Cell.Controls.Add(lbl1);
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label0.Text = "Your Selected Date:" + Calendar1.SelectedDate.Date.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Caption = "SAMBARE";
            Calendar1.FirstDayOfWeek = FirstDayOfWeek.Sunday;
            Calendar1.NextPrevFormat = NextPrevFormat.ShortMonth;
            Calendar1.TitleFormat = TitleFormat.Month;

            Label1.Text = "Todays Date" + Calendar1.TodaysDate.ToShortDateString();
            Label2.Text = "Winter vacation Start: 24-12-2020";
            TimeSpan d = new DateTime(2020, 12, 24) - DateTime.Now;
            Label3.Text = "Days Remaining for Teacher's day Vacation:" + d.Days.ToString();
            TimeSpan d1 = new DateTime(2021, 1, 1) - DateTime.Now;
            Label4.Text = "Days Remaining for New Year:" + d1.Days.ToString();
            if (Calendar1.SelectedDate.ToShortDateString() == "24-12-2020")
                Label5.Text = "<b>Winter vacation's Start</b>";
            if (Calendar1.SelectedDate.ToShortDateString() == "1-1-2020")
                Label6.Text = "<b>It's New Year</b>";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label0.Text = "";
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Calendar1.SelectedDates.Clear();
        }
    }
}