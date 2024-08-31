using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace UI.CustomViewParts
{
    /// <summary>
    /// 選択すると拡大・縮小するボタン
    /// </summary>
    /// <remarks>
    /// 参考：https://qiita.com/Putinu/items/932d24494d7de277b274
    /// </remarks>
    [RequireComponent(typeof(CustomButton))]
    public class ScaledCommonButtonView : MonoBehaviour
    {
        private readonly float DefaultScale = 1f;
        private readonly float PressedScale = 0.9f;

        private readonly float ActiveImageAlpha = 1f;
        private readonly float InactiveImageAlpha = 0.5f;

        private CustomButton _button;
        [SerializeField] private Image _image;

        private void Start()
        {
            _button = GetComponent<CustomButton>();

            _button.OnButtonPressed
                .Subscribe(_ => SetScale(PressedScale))
                .AddTo(this.gameObject);
            
            _button.OnButtonReleased
                .Subscribe(_ => SetScale(DefaultScale))
                .AddTo(this.gameObject);

            _button.IsActiveRP
                .Subscribe(SetButtonActive)
                .AddTo(this.gameObject);

        }

        private void SetScale(float scale)
        {
            _image.rectTransform.localScale = Vector3.one * scale;
        }

        private void SetButtonActive(bool isActive)
        {
            float alpha = isActive ? ActiveImageAlpha : InactiveImageAlpha;
            _image.color = new Color(1, 1, 1, alpha);
        }
    }
}