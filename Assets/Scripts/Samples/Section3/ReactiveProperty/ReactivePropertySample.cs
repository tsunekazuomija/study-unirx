using UniRx;
using UnityEngine;

namespace Samples.Section3.ReactiveProperty
{
    public class ReactivePropertySample : MonoBehaviour
    {

        void Start()
        {
            var health = new ReactiveProperty<int>(100);

            Debug.Log("現在の値：" + health.Value);

            // ReactivePropertyを直接Subscribeできる
            // Subscribeのタイミングで現在の値が自動的に発行される
            health.Subscribe(
                x => Debug.Log("通知された値：" + x),
                () => Debug.Log("OnCompleted")
            );
            
            health.Value = 50;
            Debug.Log("現在の値：" + health.Value);

            health.Dispose();
        }
    }

}