
namespace M1CP.Foundation.Services.Repository
{
    public interface ISerializer
    {
        string Serialize<T>(T data);
        T Deserialize<T>(string serializedData);
    }
}
