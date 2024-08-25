using System;
using UniRx;
using UnityEngine;

namespace Samples.Section2.Schedulers
{
    public class CompareSchedulers : MonoBehaviour
    {
        void Start()
        {
            // 内部でコルーチンのWaitForSecondsを使っているため、メインスレッドをブロックしない
            Observable
                .Timer(TimeSpan.FromSeconds(3), Scheduler.MainThread)
                .Subscribe(_ => Debug.Log("MainThread"))
                .AddTo(this);
            
            // Thread.Sleepを使うため、スレッドをフリーズさせる
            Observable
                .Timer(TimeSpan.FromSeconds(3), Scheduler.CurrentThread)
                .Subscribe(_ => Debug.Log("CurrentThread"))
                .AddTo(this);
        }
    }
}