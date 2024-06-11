namespace AppNotesDanielaMoraMAUI.Views
{
    public partial class AllNotesPage_DMO : ContentPage
    {
        public AllNotesPage_DMO()
        {
            InitializeComponent();
            BindingContext = new Models.AllNotes_DMO();
        }

        protected override void OnAppearing()
        {
            ((Models.AllNotes_DMO)BindingContext).LoadNotes();
        }

        private async void Add_Clicked_DMO(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(NotePageDMO));
        }

        private async void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count != 0)
            {
                // Get the note model
                var note = (Models.Note_DMO)e.CurrentSelection[0];

                // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
                await Shell.Current.GoToAsync($"{nameof(NotePageDMO)}?{nameof(NotePageDMO.ItemId)}={note.Filename_DMO}");

                // Unselect the UI
                notesCollection.SelectedItem = null;
            }
        }
    }
}
