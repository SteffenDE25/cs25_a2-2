using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppA2
{
    public class Task
    {
        public string Title { get; set; } = "neue Aufgabe";
        public string Description { get; set; } = string.Empty;
        public decimal Priority { get; set; } = 0;
        public DateTime DueTo { get; set; } = DateTime.Now;
        public bool Done { get; set; } = false;

        // Überschreiben der ToString-Methode mit einer geeigneter Ausgabe
        // Beispiel: "Altpapier in Papi... - fällig am: 12.10.2026, 10:00 Uhr"
        public override string ToString() =>
                Title.Length > 20
                ? Title.Substring(0, 17) + "..." + $"- fällig am: {DueTo.ToString("dd.MM.yyyy, HH:mm")} Uhr"
                : Title + $"- fällig am: {DueTo.ToString("dd.MM.yyyy, HH:mm")} Uhr";
    }
}
