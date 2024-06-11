namespace AppNotesDanielaMoraMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.NotePageDMO), typeof(Views.NotePageDMO));
        }
    }
}
