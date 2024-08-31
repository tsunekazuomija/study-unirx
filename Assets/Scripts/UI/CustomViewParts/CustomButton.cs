using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace UI.CustomViewParts
{
    /// <summary>
    /// 汎用ボタン
    /// 参考：https://qiita.com/Putinu/items/932d24494d7de277b274
    /// </summary>
    [RequireComponent(typeof(ObservableEventTrigger))]  // ?
    public class CustomButton : MonoBehaviour
    {
        private ObservableEventTrigger _observableEventTrigger;

        /// <summary>ボタンクリック時</summary>
        public IObservable<Unit> OnButtonClicked => _observableEventTrigger
            .OnPointerClickAsObservable()
            .AsUnitObservable()
            .Where(_ => _isActiveRP.Value);
        
        /// <summary>ボタンを押した時</summary>
        public IObservable<Unit> OnButtonPressed => _observableEventTrigger
            .OnPointerDownAsObservable()
            .AsUnitObservable()
            .Where(_ => _isActiveRP.Value);
        
        /// <summary>ボタンを離した時</summary>
        public IObservable<Unit> OnButtonReleased => _observableEventTrigger
            .OnPointerUpAsObservable()
            .AsUnitObservable()
            .Where(_ => _isActiveRP.Value);
        
        /// <summary>ボタンの領域にカーソルが入った時</summary>
        public IObservable<Unit> OnButtonEntered => _observableEventTrigger
            .OnPointerEnterAsObservable()
            .AsUnitObservable()
            .Where(_ => _isActiveRP.Value);
        
        /// <summary>ボタンの領域からカーソルが出た時</summary>
        public IObservable<Unit> OnButtonExited => _observableEventTrigger
            .OnPointerExitAsObservable()
            .AsUnitObservable()
            .Where(_ => _isActiveRP.Value);
        
        /// <summary>
        /// ボタンの有効/無効を保持するReactiveProperty
        /// </summary>
        public IReadOnlyReactiveProperty<bool> IsActiveRP => _isActiveRP;

        private readonly ReactiveProperty<bool> _isActiveRP = new(true);

        protected virtual void OnDestroy()
        {
            _isActiveRP.Dispose();
        }

        protected virtual void Awake()
        {
            _observableEventTrigger = GetComponent<ObservableEventTrigger>();
        }

        /// <summary>
        /// ボタンのアクティブ状態を取得する
        /// </summary>
        public bool IsActive => _isActiveRP.Value;

        /// <summary>
        /// ボタンのアクティブ状態を設定する
        /// </summary>
        public void SetActive(bool isActive)
        {
            _isActiveRP.Value = isActive;
        }
    }
}