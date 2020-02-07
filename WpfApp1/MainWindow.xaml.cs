using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Ical.Net.CalendarComponents;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            var now = DateTime.Now;
            var later = now.AddHours(1);

            var rrule = new RecurrencePattern(Ical.Net.FrequencyType.Daily, 1) { Count = 5 };
            var e = new CalendarEvent
            {
                Start = new CalDateTime(now),
                End = new CalDateTime(later),
                RecurrenceRules = new List<RecurrencePattern> { rrule },
            };



            var calendar = new Ical.Net.Calendar();
            calendar.Events.Add(e);
           

        }

        private void btn1_click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Calendar cal = new Calendar();
            cal.DisplayDateStart = new DateTime(2020, 02, 07);
            cal.DisplayDateEnd = new DateTime(2030, 12, 31);
            cal.DisplayDate = new DateTime(2015, 01, 01);
        }

        
    }
}
