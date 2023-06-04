namespace CryptoBroker.Domain;

public class KucoinOptions
{
    public KucoinOptions(string key, string secret, string passPhrase)
    {
        ApiKey = key;
        ApiSecret = secret;
        ApiPassPhrase = passPhrase;
    }
    
    public string ApiKey { get; set; }
    public string ApiSecret { get; set; }
    public string ApiPassPhrase { get; set; }
}