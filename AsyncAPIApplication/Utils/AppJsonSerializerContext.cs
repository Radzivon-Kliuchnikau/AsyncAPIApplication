using System.Text.Json.Serialization;
using AsyncAPIApplication.Models;

namespace AsyncAPIApplication.Utils;

[JsonSerializable(typeof(ListOfRequests))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}