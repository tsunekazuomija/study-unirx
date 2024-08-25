using UniRx;
using UnityEngine;

namespace Samples.Section3.Subjects
{

    public class BehaviorSubjectSample : MonoBehaviour
    {
        void Start()
        {
            // BehaviorSubjectの定義には必ず初期値が必要
            var behaviorSubject = new BehaviorSubject<int>(0);

            behaviorSubject.OnNext(1);

            Debug.Log("before subscribe");

            behaviorSubject.Subscribe(
                x => Debug.Log("OnNext:" + x),
                ex => Debug.LogError("OnError:" + ex),
                () => Debug.Log("OnCompleted"));

            Debug.Log("subscribe done");

            behaviorSubject.OnNext(2);
            Debug.Log("Last Value:" + behaviorSubject.Value);

            behaviorSubject.OnNext(3);
            behaviorSubject.OnCompleted();

            behaviorSubject.Dispose();
        }
    }
}