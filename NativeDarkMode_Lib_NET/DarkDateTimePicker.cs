using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace NativeDarkMode_Lib_NET
{
    public partial class DarkDateTimePicker : UserControl
    {
        // Private fields
        private DateTime _value;
        private Form _popupForm;
        private MonthCalendar _monthCalendar;

        // Public Properties to mimic the standard control
        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    txtDate.Text = _value.ToShortDateString();
                    _monthCalendar.SetDate(value);
                    OnValueChanged(EventArgs.Empty);
                }
            }
        }

        // Public Event to mimic the standard control
        [Category("Action")]
        public event EventHandler ValueChanged;

        public DarkDateTimePicker()
        {
            InitializeComponent();
            InitializePopupCalendar();

            // Set default value and appearance
            Value = DateTime.Now;
            txtDate.BackColor = Color.FromArgb(50, 50, 50);
            txtDate.ForeColor = Color.Silver;
            btnDropDown.BackColor = Color.FromArgb(50, 50, 50);
            btnDropDown.ForeColor = Color.Silver;
        }

        private void InitializePopupCalendar()
        {
            // Create the calendar control
            _monthCalendar = new MonthCalendar
            {
                BackColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.Silver,
                TitleBackColor = Color.FromArgb(80, 80, 80),
                TitleForeColor = Color.Silver,
                TrailingForeColor = Color.Gray,
                MaxSelectionCount = 1
            };
            _monthCalendar.DateSelected += MonthCalendar_DateSelected;

            // Create a borderless form to host the calendar
            _popupForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                StartPosition = FormStartPosition.Manual,
                TopMost = true,
                Size = _monthCalendar.Size
            };
            _popupForm.Controls.Add(_monthCalendar);
            _popupForm.Deactivate += (s, e) => _popupForm.Visible = false; // Close when it loses focus
        }

        private void btnDropDown_Click(object sender, EventArgs e)
        {
            // Position and show the popup form
            Point location = this.Parent.PointToScreen(this.Location);
            _popupForm.Location = new Point(location.X, location.Y + this.Height);
            _popupForm.Show();
            _popupForm.Activate();
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // When a date is picked, update the value and close the popup
            this.Value = e.Start;
            //_popupForm.Close();
            _popupForm.Visible = false;
        }

        // Helper method to raise the ValueChanged event
        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }
    }
}
