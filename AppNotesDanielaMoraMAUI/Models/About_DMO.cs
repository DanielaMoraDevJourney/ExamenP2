using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotesDanielaMoraMAUI.Models
{
    internal class About_DMO
    {
        public string Title_DMO => AppInfo.Name;
        public string Version_DMO => AppInfo.VersionString;
        public string MoreInfoUrl_DMO => "https://aka.ms/maui";
        public string Message_DMO => "This app is written in XAML and C# with .NET MAUI.";
    }
}
