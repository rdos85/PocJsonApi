namespace PocJsonApi.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public IEnumerable<Endereco> Enderecos { get; set; }

        public static Pessoa CriarExemplo(int totalEnderecos)
        {
            return new Pessoa
            {
                Id = Guid.NewGuid(),
                Nome = Faker.NameFaker.Name(),
                Nascimento = Faker.DateTimeFaker.BirthDay(18),
                Enderecos = Endereco.CriarExemplos(totalEnderecos)
            };
        }
    }
}