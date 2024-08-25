using UniRx;
using UnityEngine;

namespace Samples.Section3.Subjects
{

    public class SubjectSample : MonoBehaviour
    {
        void Start()
        {
            var subject = new Subject<int>();

            subject.OnNext(1);

            subject.Subscribe(
                x => Debug.Log("OnNext:" + x),
                ex => Debug.LogError("OnError:" + ex),
                () => Debug.Log("OnCompleted"));
            
            // Subject<T>は、メッセージが発行された時にすでに自身を購読しているObserverにしかメッセージを発行できない。
            // => subscribe()より前に発行されたメッセージをうけとることはできない。
            subject.OnNext(2);
            subject.OnNext(3);

            subject.OnCompleted();

            subject.Dispose();
        }
    }

}