using System;
using PlayableAd.Infrastructure.State;
using PlayableAd.Services.CoroutineRunner;
using PlayableAd.Services.SceneLoading;
using UnityEngine;

namespace PlayableAd.Infrastructure
{
    public class Bootstrap : MonoBehaviour, ICoroutineRunner
    {
        private GameStateMachine _gameStateMachine;
        private SceneLoader _sceneLoader;
        
        private void Awake()
        {
            InitLocator();
            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            _gameStateMachine.Enter(new BootstrapState(_sceneLoader));
        }

        private void InitLocator()
        {
            Locator<ICoroutineRunner>.Instance = this;

            _sceneLoader = new SceneLoader(this);
            Locator<ISceneLoader>.Instance = _sceneLoader;

            _gameStateMachine = new GameStateMachine();
            Locator<GameStateMachine>.Instance = _gameStateMachine;
        }
    }
}