using System;
using UnityEngine;

namespace Samples.Section2.MyObservers
{
    // 受信したメッセージをログに出力するObserver
    public class PrintLogObserver<T> : IObserver<T>
    {
        public void OnCompleted()
        {
            Debug.Log("OnCompleted");
        }

        public void OnError(Exception error)
        {
            Debug.LogError(error);
        }

        public void OnNext(T value)
        {
            Debug.Log(value);
        }
    }
}
