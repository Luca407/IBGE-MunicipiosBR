using Newtonsoft.Json;

public class Regiao
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("sigla")]
    public string? Sigla { get; set; }

    [JsonProperty("nome")]
    public string? Nome { get; set; }
}

public class UF
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("sigla")]
    public string? Sigla { get; set; }

    [JsonProperty("nome")]
    public string? Nome { get; set; }

    [JsonProperty("regiao")]
    public Regiao? Regiao { get; set; }
}

public class Mesoregiao
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("nome")]
    public string? Nome { get; set; }

    [JsonProperty("UF")]
    public UF? Uf { get; set; }
}

public class Microregiao
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("nome")]
    public string? Nome { get; set; }

    [JsonProperty("mesorregiao")]
    public Mesoregiao? Mesoregiao { get; set; }
}

public class Municipios
{
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("nome")]
    public string? Nome { get; set; }

    [JsonProperty("microrregiao")]
    public Microregiao? Microregiao { get; set; }

    public static async Task<List<Municipios>> BuscarMunicipios()
    {
        string url = "https://servicodados.ibge.gov.br/api/v1/localidades/municipios";

        using HttpClient client = new HttpClient();
        var json = await client.GetStringAsync(url);
        var lista = JsonConvert.DeserializeObject<List<Municipios>>(json);
        return lista ?? new List<Municipios>();
    }
}
