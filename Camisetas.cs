namespace Evie
{
    class Camisetas
    {
        private string v1;
        private string v2;
        private int v3;
        private string v4;

        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Talla { get; set; }
        public string Color { get; set; }


        public Camisetas(int id, string modelo, string marca, int talla, string color)
        {
            this.Id = id;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Talla = talla;
            this.Color = color;
        }

        public Camisetas(string v1, string v2, int v3, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
        }
    }
}
