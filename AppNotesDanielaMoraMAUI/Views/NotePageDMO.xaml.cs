namespace AppNotesDanielaMoraMAUI.Views
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class NotePageDMO : ContentPage
    {
        string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

        public NotePageDMO()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
                TextEditor.Text = File.ReadAllText(_fileName);

            string appDataPath = FileSystem.AppDataDirectory;
            string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

            LoadNote(Path.Combine(appDataPath, randomFileName));
        }

        private async void SaveButton_Clicked_DMO(object sender, EventArgs e)
        {
            if (BindingContext is Models.Note_DMO note)
                File.WriteAllText(note.Filename_DMO, TextEditor.Text);

            await Shell.Current.GoToAsync("..");
        }

        private async void DeleteButton_Clicked_DMO(object sender, EventArgs e)
        {
            if (BindingContext is Models.Note_DMO note)
            {
                // Delete the file.
                if (File.Exists(note.Filename_DMO))
                    File.Delete(note.Filename_DMO);
            }

            await Shell.Current.GoToAsync("..");
        }

        private void LoadNote(string fileName)
        {
            Models.Note_DMO noteModel = new Models.Note_DMO();
            noteModel.Filename_DMO = fileName;

            if (File.Exists(fileName))
            {
                noteModel.Date_DMO = File.GetCreationTime(fileName);
                noteModel.Text_DMO = File.ReadAllText(fileName);
            }

            BindingContext = noteModel;
        }

        public string ItemId
        {
            set { LoadNote(value); }
        }
    }
}
