namespace PocJsonApi.Models
{
    public class Endereco
    {
        public Guid Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }


        public static IEnumerable<Endereco> CriarExemplos(int total)
        {
            var enderecos = new List<Endereco>(total);

            for (int i = 0; i < total; i++)
                enderecos.Add(CriarExemplo());

            return enderecos;
        }

        public static Endereco CriarExemplo()
        {
            return new Endereco
            {
                Id = Guid.NewGuid(),
                Rua = Faker.LocationFaker.StreetName(),
                Numero = Faker.LocationFaker.StreetNumber()
            };
        }
    }
}