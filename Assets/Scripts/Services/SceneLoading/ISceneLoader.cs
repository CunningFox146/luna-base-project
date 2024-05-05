using System;
using PlayableAd.Infrastructure;

namespace PlayableAd.Services.SceneLoading
{
    public interface ISceneLoader : IService
    {
        void LoadScene(Scenes scene, Action onDone = null);
    }
}