using UniRx;
using UnityEngine;

namespace Samples.Section3.FactoryMethods
{
    public class WithCurrentThreadSchedulerSample : MonoBehaviour
    {
        private void Start()
        {
            Observable.Range(
                start: 0,
                count: 5,
                scheduler: Scheduler.CurrentThread
            ).Subscribe(x =>
            {
                Debug.Log($"frame:{Time.frameCount} OnNext:{x}");
            });
        }
    }
}