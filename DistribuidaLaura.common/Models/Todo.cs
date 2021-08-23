using System;

namespace DistribuidaLaura.common.Models
{
    public class Todo
    {
        // Añadimos las propiedades

        public DateTime CreatedTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }

    }
}
