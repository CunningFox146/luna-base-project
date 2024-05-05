using System.Collections;
using PlayableAd.Infrastructure;
using UnityEngine;

namespace PlayableAd.Services.CoroutineRunner
{
    public interface ICoroutineRunner : IService
    {
        Coroutine StartCoroutine(IEnumerator routine);
    }
}