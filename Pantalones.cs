namespace Evie
{
    class Pantalones
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Talla { get; set; }
        public string Color { get; set; }


        public Pantalones(int id, string modelo, string marca, int talla, string color)
        {
            this.Id = id;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Talla = talla;
            this.Color = color;
        }
    }
}
