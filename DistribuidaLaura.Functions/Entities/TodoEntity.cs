using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace DistribuidaLaura.Functions.Entities
{
    //Hacemos publica la clase 
    //Se realiza la herencia con el nuget anteriormente creado

    public class TodoEntity : TableEntity
    {

        public DateTime CreatedTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
