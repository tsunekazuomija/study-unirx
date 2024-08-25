using System;
using UniRx;
using UnityEngine;

namespace Samples.Section2.Observables
{
    public class MessageSample : MonoBehaviour
    {
        [SerializeField] private float _countTimeSeconds = 30f;

        // 時間切れを通知する Observable
        public IObservable<Unit> OnTimeUpAsyncSubject => _onTimeUpAsyncSubject;

        private readonly AsyncSubject<Unit> _onTimeUpAsyncSubject = new AsyncSubject<Unit>();

        private IDisposable _disposable;

        void Start()
        {
            _disposable = Observable
                .Timer(TimeSpan.FromSeconds(_countTimeSeconds))
                .Subscribe( _ =>
                {
                    // timerが発火したらunit型のメッセージを発行
                    _onTimeUpAsyncSubject.OnNext(Unit.Default);
                    _onTimeUpAsyncSubject.OnCompleted();
                });
        }

        private void OnDestroy()
        {
            _disposable?.Dispose();

            _onTimeUpAsyncSubject.Dispose();
        }
    }
}
