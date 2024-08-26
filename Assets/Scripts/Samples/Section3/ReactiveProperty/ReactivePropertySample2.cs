using UniRx;
using UnityEngine;

namespace Samples.Section3.ReactiveProperty
{
    public class ReactivePropertySample2 : MonoBehaviour
    {
        void Start()
        {
            var health = new ReactiveProperty<int>(100);

            health
                .Subscribe(
                    x => Debug.Log("通知された値：" + x),
                    () => Debug.Log("OnCompleted"));

            // 現在の値と同じなら通知しない    
            Debug.Log("<Valueに100を設定>");
            health.Value = 100;

            // SetValueAndForceNotifyで強制的に通知する
            Debug.Log("<Valueに100を設定して強制通知>");
            health.SetValueAndForceNotify(100);

            health.Dispose();
        }
    }
}