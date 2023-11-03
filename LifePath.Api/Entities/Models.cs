using System.Text.Json.Serialization;

namespace LifePath.Api.Entities;

[JsonSerializable(typeof(TestData))]
public record TestData(string Data);


