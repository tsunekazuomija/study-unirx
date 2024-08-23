using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Samples.Section2.MyObservers
{
    public class ObserveEventComponent : MonoBehaviour
    {
        [SerializeField] private CountDownEventProvider _countDownEventProvider;

        private PrintLogObserver<int> _printLogObserver;

        private IDisposable _disposable;

        void Start()
        {
            _printLogObserver = new PrintLogObserver<int>();

            // イベントの購読
            _disposable = _countDownEventProvider.CountDownObservable.Subscribe(_printLogObserver);
        }

        void OnDestroy()
        {
            _disposable?.Dispose();
        }

    }
}

