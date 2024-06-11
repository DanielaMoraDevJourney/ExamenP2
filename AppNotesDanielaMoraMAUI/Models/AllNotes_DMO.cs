using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotesDanielaMoraMAUI.Models
{
    internal class AllNotes_DMO
    {
        public ObservableCollection<Note_DMO> Notes { get; set; } = new ObservableCollection<Note_DMO>();

        public AllNotes_DMO() =>
            LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            // Get the folder where the notes are stored.
            string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.notes.txt files.
            IEnumerable<Note_DMO> notes = Directory

                                        // Select the file names from the directory
                                        .EnumerateFiles(appDataPath, "*.notes.txt")

                                        // Each file name is used to create a new Note
                                        .Select(filename => new Note_DMO()
                                        {
                                            Filename_DMO = filename,
                                            Text_DMO = File.ReadAllText(filename),
                                            Date_DMO = File.GetLastWriteTime(filename)
                                        })

                                        // With the final collection of notes, order them by date
                                        .OrderBy(note => note.Date_DMO);

            // Add each note into the ObservableCollection
            foreach (Note_DMO note in notes)
                Notes.Add(note);
        }
    }
}
