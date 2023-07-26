using System;
using System.Collections.Generic;

namespace PartsService.Models
{
    public class Part
    {
        // ID de la parte
        public string PartID { get; set; }

        // Nombre de la parte
        public string PartName { get; set; }

        // Lista de proveedores
        public List<string> Suppliers { get; set; }

        // Fecha en que la parte estará disponible
        public DateTime PartAvailableDate { get; set; }

        // Tipo de parte
        public string PartType { get; set; }

        // Href es una propiedad que devuelve la ruta de la API para esta parte específica
        public string Href => $"api/parts/{PartID}";
    }
}
