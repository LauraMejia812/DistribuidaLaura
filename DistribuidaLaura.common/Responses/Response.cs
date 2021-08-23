using System;
using System.Collections.Generic;
using System.Text;

namespace DistribuidaLaura.common.Responses
{
    public class Response //Hacemos publica la clase 
    {
        //Añadimos las propiedades 

        public bool IsSuccess { get; set; } //resultado si es exitoso

        public String Message { get; set;} //Diciente en caso de que haya error

        public object Result { get; set; } //Representación del modelo 

    }
}
