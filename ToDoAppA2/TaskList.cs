using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppA2
{
    public class TaskList
    {
        public string Name { get; set; } = "Neue Aufgabenliste";
        public List<Task> Tasks { get; set; } = new List<Task>();

        // Überschreiben der ToString-Methode mit einer geeigneter Ausgabe
        // hier: Listenname (Anzahl Aufgaben), z.B. Haushalt (3)
        public override string ToString() =>
            $"{Name} ({(Tasks.Count).ToString()})";
    }
}
