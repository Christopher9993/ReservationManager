using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace ReservationManager
{

    public partial class MainWindow : Window
    {
        private ObservableCollection<Reservation> reservations;

        public MainWindow()
        {
            InitializeComponent();
            reservations = new ObservableCollection<Reservation>();
            ReservationListView.ItemsSource = reservations;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var reservation = new Reservation
            {
                Id = reservations.Count + 1,
                Name = NameTextBox.Text,
                Contact = ContactTextBox.Text,
                Date = DatePicker.SelectedDate.GetValueOrDefault(),
                Notes = NotesTextBox.Text
            };
            reservations.Add(reservation);
            ClearForm();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReservationListView.SelectedItem is Reservation selectedReservation)
            {
                selectedReservation.Name = NameTextBox.Text;
                selectedReservation.Contact = ContactTextBox.Text;
                selectedReservation.Date = DatePicker.SelectedDate.GetValueOrDefault();
                selectedReservation.Notes = NotesTextBox.Text;
                ReservationListView.Items.Refresh();
                ClearForm();
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (ReservationListView.SelectedItem is Reservation selectedReservation)
            {
                reservations.Remove(selectedReservation);
                ClearForm();
            }
        }

        private void ClearForm()
        {
            NameTextBox.Clear();
            ContactTextBox.Clear();
            DatePicker.SelectedDate = null;
            NotesTextBox.Clear();
        }
    }
}