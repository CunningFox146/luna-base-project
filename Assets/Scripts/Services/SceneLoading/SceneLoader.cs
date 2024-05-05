using System;
using System.Collections;
using PlayableAd.Services.CoroutineRunner;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PlayableAd.Services.SceneLoading
{
    public class SceneLoader : ISceneLoader
    {
        private readonly ICoroutineRunner _coroutineRunner;

        public SceneLoader(ICoroutineRunner coroutineRunner)
        {
            _coroutineRunner = coroutineRunner;
        }
        
        public void LoadScene(Scenes scene, Action onDone = null)
        {
            _coroutineRunner.StartCoroutine(LoadSceneCoroutine((int)scene, onDone));
            
        }

        private IEnumerator LoadSceneCoroutine(int sceneIndex, Action onDone)
        {
            var handle = SceneManager.LoadSceneAsync(sceneIndex);
            yield return new WaitUntil(() => handle != null && handle.isDone);
            onDone?.Invoke();
        }
    }
}