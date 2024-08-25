using System.Threading;
using System.Threading.Tasks;
using System.Collections;
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
            subject.OnNext(Unit.Default); // 1

            // 別スレッドからOnNextを発行
            Task.Run(() => subject.OnNext(Unit.Default));

            // Task.Runが行われる前にOnCompletedを実行してしまうので、コメントアウト
            // subject.OnCompleted();

            StartCoroutine(OnCompletedCoroutine(subject));  // 129800 <- 連番ではないぽい
        }

        private IEnumerator OnCompletedCoroutine(Subject<Unit> subject)
        {
            yield return new WaitForSeconds(1.0f);
            subject.OnCompleted();
        }
    }
}
