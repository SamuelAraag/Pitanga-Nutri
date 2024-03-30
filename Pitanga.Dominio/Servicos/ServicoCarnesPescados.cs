using Npgsql;

namespace Pitanga.Dominio.Servicos
{
	public class ServicoCarnesPescados
	{
		public ServicoCarnesPescados()
		{
		}

        public async Task<List<CarnesEPescados>> ObterTodos()
        {
            var result = new List<CarnesEPescados>();

            using (var conexao = new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=BANCO-TACO"))
            {
                await conexao.OpenAsync();

                using (var cmd = new NpgsqlCommand("SELECT * FROM \"carnes-pescados\"", conexao))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(new CarnesEPescados
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                Nome = reader.GetString(reader.GetOrdinal("nome")),
                                Calorias = reader.GetDouble(reader.GetOrdinal("calorias"))
                            });
                        }
                    }
                }
            }

            return result;
        }

    }
}

