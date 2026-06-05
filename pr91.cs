using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

public class AppConfig
{
    public string? ServerName { get; set; }
    public int Port { get; set; }
    public List<string>? Endpoints { get; set; }
    public AppConfig(string? serverName, int port, List<string>? endpoints)
    {
        ServerName = serverName;
        Port = port;
        Endpoints = endpoints;
    }
    public override string ToString()
    {
        return $"{ServerName} {Port} {string.Join(", ", Endpoints) }";
    }
}

public static class ConfigManager
{
    public static void Save(string path, AppConfig config)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        File.WriteAllText(path, JsonSerializer.Serialize(config, options));
    }

    public static AppConfig Load(string path)
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        using FileStream file = new FileStream(path, FileMode.Open);
        AppConfig deserializedAppConfigs = JsonSerializer.Deserialize<AppConfig>(file, options);
        if(!File.Exists(path))
        {
            Console.WriteLine("DefaultConfig");
        }
        return deserializedAppConfigs;
    }
    static void Main(string[] args)
    {
        string path = "AppConfig.json";
        List<string> endpoints = new List<string>
            {
                "chto-to",
                "chto-to.2"
            };
        AppConfig config = new AppConfig("ServerName", 1234, endpoints);
        ConfigManager.Save(path, config);
        AppConfig a = ConfigManager.Load(path);
        Console.WriteLine(a);
    }
}
