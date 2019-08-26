namespace Snapchat.ApiClient
{
    public interface IWrapper<T> where T : IEntity
    {
        string SubRequestStatus { get; set; }

        T Entity { get; set; }
    }
}
