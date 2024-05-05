using PlayableAd.Services.SceneLoading;
using PlayableAd.Services.State;
using UnityEngine;

namespace PlayableAd.Infrastructure.State
{
    public class BootstrapState : IState
    {
        public readonly ISceneLoader _sceneLoader;

        public BootstrapState(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            _sceneLoader.LoadScene(Scenes.Game, () => Debug.Log("COOL!"));
        }
    }
}