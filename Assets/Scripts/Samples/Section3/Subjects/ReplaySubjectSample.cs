using UniRx;
using UnityEngine;

namespace Samples.Section3.Subjects
{
    public class ReplaySubjectSample : MonoBehaviour
    {
        void Start()
        {
            var subject = new ReplaySubject<int>(bufferSize: 3);

            for (int i = 0; i < 10; ++i)
            {
                subject.OnNext(i);
            }

            subject.OnCompleted();

            // OnCompletedメッセージ発行後にSubscribeしても、それまでに発行されたメッセージを取得できる
            subject.Subscribe(
                x => Debug.Log("OnNext:" + x),
                ex => Debug.LogError("OnError:" + ex),
                () => Debug.Log("OnCompleted"));
            
            subject.Dispose();
        }
    }
}