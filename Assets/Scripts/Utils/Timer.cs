using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HappyFarm.Utils
{
    public class Timer : MonoBehaviour
    {
        public void SetDelay(float duration, System.Action cb) 
        {
            StartCoroutine(DelayFunction(duration,() => { cb();}));
        }
        IEnumerator DelayFunction(float duration, System.Action cb)
        {
            yield return new WaitForSeconds(duration);
            cb();
        }
    }
}

