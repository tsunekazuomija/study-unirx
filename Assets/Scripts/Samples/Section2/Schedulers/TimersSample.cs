using System;
using System.Threading;
using UniRx;
using UnityEngine;

namespace Samples.Section2.Schedulers
{
    public class TimersSample : MonoBehaviour
    {
        void Start()
        {
            // MainThreadを指定
            // １秒経過直後のupdateと同じタイミングで実行
            Observable.Timer(TimeSpan.FromSeconds(1), Scheduler.MainThread)
                .Subscribe(_ => Debug.Log($"１秒経過しました。0, {Thread.CurrentThread.ManagedThreadId}"))
                .AddTo(this);

            // 未指定の場合はMainThreadSchedulerと同じ
            Observable.Timer(TimeSpan.FromSeconds(1))
                .Subscribe(_ => Debug.Log($"１秒経過しました。1, {Thread.CurrentThread.ManagedThreadId}"))
                .AddTo(this);

            // CurrentThreadを指定するとそのまま同じスレッドで処理
            // この場合は新しいスレッド上でタイマーのカウントを実行する。
            new Thread(() =>
            {
                Observable.Timer(TimeSpan.FromSeconds(1), Scheduler.CurrentThread)
                    .Subscribe(_ => Debug.Log($"１秒経過しました。2, {Thread.CurrentThread.ManagedThreadId}"))
                    .AddTo(this);
                    // UnityException: get_gameObject can only be called from the main thread.と表示される。
            }).Start();
        }
    }
}