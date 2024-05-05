namespace PlayableAd.Infrastructure
{
    public static class Locator<TSingleton> where TSingleton : IService
    {
        public static TSingleton Instance { get; set; }
    }
    
    public interface IService { }
}