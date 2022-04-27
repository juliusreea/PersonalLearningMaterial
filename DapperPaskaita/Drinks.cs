using System;

namespace DapperPaskaita
{
    internal class Drinks
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Liters { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public float Weight { get; set; }
        public int Index { get; set; }

    }
}
