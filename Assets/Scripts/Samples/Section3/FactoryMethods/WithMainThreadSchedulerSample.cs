using UniRx;
using Unity.VisualScripting;
using UnityEngine;

namespace Samples.Section3.FactoryMethods
{
    public class WithMainThreadSchedulerSample : MonoBehaviour
    {
        private void Start()
        {
            Observable.Range(
                start: 0,
                count: 5,
                scheduler: Scheduler.MainThread
            ).Subscribe(x =>
            {
                Debug.Log($"frame:{Time.frameCount} OnNext:{x}");
            });
        }
    }
}