using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calcular_Valor_Resistencia.Api.Domain;

/*Nombre de la escuela: Universidad Tecnologica Metropolitana
Asignatura: Aplicaciones Web Orientadas a Servicios
Nombre del Maestro: Chuc Uc Joel Ivan
Nombre de la actividad: Actividad 2
Nombre del alumno: Avila Ramayo Brandon Jefte
Cuatrimestre: 4
Grupo: B
Parcial: 2
*/

namespace Calcular_Valor_Resistencia.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Resistencia : ControllerBase
    {
        [HttpGet("CalcularResitencia")]
        public ActionResult<Bandas> Resistencias (string colorBanda1, string colorBanda2, string colorBanda3, string colorBanda4)
        {
            Bandas CLS = new Bandas();

                CLS.Color = colorBanda1;

                var Respuesta = "";

                switch (CLS.Color)
            {
                case "negro":
                CLS.ValorUno = 0;
                break;
                case "cafe":
                CLS.ValorUno = 1;
                break;
                case "rojo":
                CLS.ValorUno = 2;
                break;
                case "naranja":
                CLS.ValorUno = 3;
                break;
                case "amarillo":
                CLS.ValorUno = 4;
                break;
                case "verde":
                CLS.ValorUno = 5;
                break;
                case "azul":
                CLS.ValorUno = 6;
                break;
                case "violeta":
                CLS.ValorUno = 7;
                break;
                case "gris":
                CLS.ValorUno = 8;
                break;
                case "blanco":
                CLS.ValorUno = 9;
                break;
                default:
                Respuesta = $"El color ingresado '{colorBanda1}' es inválido, Favor de usar colores existentes para una resistencia";
                return Ok(Respuesta);
            }

            var color1 = CLS.ValorUno;

            CLS.Color = colorBanda2;

            switch (CLS.Color)
            {
                case "negro":
                CLS.ValorUno = 0;
                break;
                case "cafe":
                CLS.ValorUno = 1;
                break;
                case "rojo":
                CLS.ValorUno = 2;
                break;
                case "naranja":
                CLS.ValorUno = 3;
                break;
                case "amarillo":
                CLS.ValorUno = 4;
                break;
                case "verde":
                CLS.ValorUno = 5;
                break;
                case "azul":
                CLS.ValorUno = 6;
                break;
                case "violeta":
                CLS.ValorUno = 7;
                break;
                case "gris":
                CLS.ValorUno = 8;
                break;
                case "blanco":
                CLS.ValorUno = 9;
                break;
                default:
                return Ok(Respuesta);
            }

            var color2 = CLS.ValorUno;

            CLS.Color = colorBanda3;

                switch (CLS.Color)
            {
                case "negro":
                CLS.ValorDos = 1;
                break;
                case "cafe":
                CLS.ValorDos = 10;
                break;
                case "rojo":
                CLS.ValorDos = 100;
                break;
                case "naranja":
                CLS.ValorDos = 1000;
                break;
                case "amarillo":
                CLS.ValorDos = 10000;
                break;
                case "verde":
                CLS.ValorDos = 100000;
                break;
                case "azul":
                CLS.ValorDos = 1000000;
                break;
                case "dorado":
                CLS.ValorDos = 10;
                break;
                case "plateado":
                CLS.ValorDos = 100;
                break;
                default:
                return Ok(Respuesta);
            }

            var color3 = CLS.ValorDos;

                CLS.Color = colorBanda4;

                switch (CLS.Color)
            {

                case "dorado":
                CLS.ValorUno = 5;
                break;
                case "plateado":
                CLS.ValorUno = 10;
                break;
                default:
                return Ok(Respuesta);
            
            }

            var color4 = CLS.ValorUno;
            
            float Finally;

            var NumeroUno  = Int32.Parse($"{color1}{color2}");

            if (colorBanda3 == "dorado" || colorBanda3 == "plateado")
            {
                Finally = (NumeroUno / color3);
            }
            else
            {
                Finally = (NumeroUno * color3);
            }

            Respuesta = "El resultado final es de: "+ Finally +" Ω y Resiste una tolerancia de; " + color4 + "%";

            return Ok(Respuesta);
        }
    }
}