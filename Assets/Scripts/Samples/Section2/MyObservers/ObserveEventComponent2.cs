using System;
using UniRx;
using UnityEngine;

namespace Samples.Section2.MyObservers
{
    class ObserveEventComponent2 : MonoBehaviour
    {
        [SerializeField] private CountDownEventProvider _countDownEventProvider;

        // private PrintLogObserver<int> _printLogObserver;
        // 糖衣構文により、_printLogObserverが不要になる！

        private IDisposable _disposable;

        void Start()
        {
            _disposable = _countDownEventProvider
                .CountDownObservable
                .Subscribe(
                    x => Debug.Log(x),
                    ex => Debug.LogError(ex),
                    () => Debug.Log("OnCompleted")
                );
        }

        void OnDestroy()
        {
            _disposable?.Dispose();
        }
    }
}