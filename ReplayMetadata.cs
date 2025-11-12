using System.Text.Json.Serialization;

namespace ARealmRecorded;

/// <summary>
/// 回放Json结构
/// </summary>
public class ReplayMetadata
{
    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("replay_file")]
    public string ReplayFile { get; set; } = string.Empty;

    [JsonPropertyName("player_count")]
    public int PlayerCount { get; set; }

    [JsonPropertyName("recorder_index")]
    public int RecorderIndex { get; set; }

    [JsonPropertyName("players")]
    public PlayerMetadata[] Players { get; set; } = [];
}

/// <summary>
/// 玩家Metadata
/// </summary>
public class PlayerMetadata
{
    [JsonPropertyName("index")]
    public int Index { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("world_id")]
    public int WorldId { get; set; }

    [JsonPropertyName("content_id")]
    public string? ContentId { get; set; }

    [JsonPropertyName("is_recorder")]
    public bool IsRecorder { get; set; }
}