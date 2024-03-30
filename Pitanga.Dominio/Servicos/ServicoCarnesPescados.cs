using Npgsql;

namespace Pitanga.Dominio.Servicos
{
	public class ServicoCarnesPescados
	{
		public ServicoCarnesPescados()
		{
		}

        public async Task<List<Alimentos>> ObterTodos()
        {
            var result = new List<Alimentos>();

            using var conexao = new NpgsqlConnection(@"Server=localhost;Port=5432;User Id=samuelaraag;Database=base_taco");
            await conexao.OpenAsync();

            using var cmd = new NpgsqlCommand("SELECT * FROM nutri.alimentos", conexao);
            using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                result.Add(new Alimentos
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Nome = reader.GetString(reader.GetOrdinal("nome"))
                });
            }

            return result;
        }
    }
}

