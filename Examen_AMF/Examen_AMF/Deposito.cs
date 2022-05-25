
using System;
//namespace EDexamenT6a8

namespace Deposito
{
    /// <summary>
    ///  Clase que representa la gestión de los depósitos de una granja.
    ///  Tiene dos depósitos: pienso y agua. 
    ///  La propiedad devuelve el nivel de agua y pienso. 
    ///  Los métodos permiten reponer o consumir tanto pienso como agua.
    /// </summary>
    class Deposito
    {
        /// <summary>
        /// Se ha cambiado de decimal a double las variables porque son mas faciles de utilizar
        /// La cantidad máxima a reponer no puede superar el tamaño del DEPÓSITO DE AGUA ni el DEPÓSITO DE PIENSO, 
        /// Ambas se comprueban antes de actualizar los niveles.
        /// Se ha cambiado las variables para que sean mas claras y especificas
        /// </summary>
        private double niveldeagua;
        private double niveldepienso;
        private double cantidadmaximaAgua;       
        private double cantidadmaximaPienso;

        /// <summary>
        /// Se han encapsulado las variables de recogida de datos
        /// </summary>
        /// <param name="value">Recoge los valores de las variables de recogida de datos</param>
        public double Niveldeagua { get => niveldeagua; set => niveldeagua = value; }
        public double Niveldepienso { get => niveldepienso; set => niveldepienso = value; }
        public double CantidadmaximaAgua { get => cantidadmaximaAgua; set => cantidadmaximaAgua = value; }
        public double CantidadmaximaPienso { get => cantidadmaximaPienso; set => cantidadmaximaPienso = value; }

        /// <summary>
        /// Se ha corregido una errata en una declaración de una variable, 
        /// Se han optimizado la tabulaciones y espaciados,
        /// Se ha cambiado el nombre de la funcion por uno mas especifico, 
        /// Se han introducido llaves en las declaraciones if,
        /// En las declaraciones de estilo (variable = variable + variable2), se ha cambiado por (variable += variable2)
        /// </summary>
        /// <param name="cantidadareponerdeagua">Indica la cantidad de agua que hay que reponer</param>
        public void reponeragua(double cantidadareponerdeagua)
        {
            CantidadmaximaAgua = cantidadareponerdeagua + Niveldeagua;
            if (cantidadareponerdeagua > 0 && CantidadmaximaAgua < 10000) ///<remarks>Tamaño del depósito de agua es de 1000l.</remarks>
            {
                Niveldeagua += cantidadareponerdeagua;
            }  
        }

        /// <summary>
        /// Se ha corregido una errata en una declaración de una variable, 
        /// Se han optimizado la tabulaciones y espaciados,
        /// Se ha cambiado el nombre de la funcion por uno mas especifico, 
        /// Se han introducido llaves en las declaraciones if,
        /// En las declaraciones de estilo (variable = variable - variable2), se ha cambiado por (variable -= variable2)
        /// </summary>
        /// <param name="cantidadareponerdepienso">Cantidad de pienso que hay que reponer</param>
        public void reponerpienso(double cantidadareponerdepienso)
        {
            CantidadmaximaPienso = cantidadareponerdepienso + Niveldepienso;
            if (cantidadareponerdepienso > 0 && CantidadmaximaPienso < 5000) ///<remarks>Tamaño del depósito de pienso es de 5000kg.</remarks>
            {
                Niveldepienso += cantidadareponerdepienso;
            }          
        }

        /// <summary>
        /// Se han optimizado la tabulaciones y espaciados,
        /// Se ha cambiado el nombre de la funcion consumoagua para que sea mas especifica,
        /// Se ha cambiado el nombre de la variable retAgua para que sea mas especifica,
        /// En las declaraciones de estilo (variable = variable - variable2), se ha cambiado por (variable -= variable2)
        /// </summary>
        /// <param name="cantidadaretirardeagua">Indica la cantidad deseada de agua a retirar</param>
        /// <returns>Cantidad de agua que se retira</returns>
        public double consumoagua(double cantidadaretirardeagua)
        {
            double retAgua = 0; 
            if (cantidadaretirardeagua > 0 && cantidadaretirardeagua <= Niveldeagua)
            {
                retAgua = cantidadaretirardeagua;
                Niveldeagua -= cantidadaretirardeagua;
            }
            return retAgua;
        }

        /// <summary>
        /// Se han optimizado la tabulaciones y espaciados,
        /// Se ha cambiado el nombre de la funcion consumopienso para que sea mas especifica,
        /// Se ha cambiado el nombre de la variable retPienso para que sea mas especifica,
        /// En las declaraciones de estilo (variable = variable - variable2), se ha cambiado por (variable -= variable2)
        /// </summary>
        /// <param name="cantidadaretirardepienso">Indica la cantidad deseada de pienso a retirar</param>
        /// <returns>Cantidad de pienso que se retira</returns>
        public double consumopienso(double cantidadaretirardepienso)
        {
            double retPienso = 0; 
            if (cantidadaretirardepienso > 0 && cantidadaretirardepienso <= Niveldepienso)
            {
                retPienso = cantidadaretirardepienso;
                Niveldepienso -= cantidadaretirardepienso;
            }
            return retPienso;
        }
    }
}