using System;
using System.Collections;
using UnityEngine;

namespace PlayableAd.Util
{
    public static class MonoBehaviourExtensions
    {
        public static Coroutine Delay(this MonoBehaviour monoBehaviour, float time, Action delayedAction)
        {
            return monoBehaviour.StartCoroutine(DelayCoroutine());

            IEnumerator DelayCoroutine()
            {
                yield return new WaitForSeconds(time);
                delayedAction.Invoke();
            }
        }
    }
}