using System.Threading;
using System.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace Samples.Section2.Schedulers
{
    public class CurrentThreadSample : MonoBehaviour
    {
        void Start()
        {
            Debug.Log("Unity Main Thread ID:" + Thread.CurrentThread.ManagedThreadId);

            var subject = new Subject<Unit>();
            subject.AddTo(this);

            subject
                .ObserveOn(Scheduler.Immediate)
                .Subscribe(_ =>
                {
                    Debug.Log("Thread ID:" + Thread.CurrentThread.ManagedThreadId);
                });
            
            // メインスレッドでOnNextを実行
            subject.OnNext(Unit.Default);

            // 別スレッドからOnNextを発行
            Task.Run(() => subject.OnNext(Unit.Default)); // debugされないが？

            subject.OnCompleted();
        }
    }
}
