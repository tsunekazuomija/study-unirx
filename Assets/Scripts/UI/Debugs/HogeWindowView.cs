using UI.CustomViewParts;
using UniRx;
using UnityEngine;


namespace UI.Debugs
{
    public class HogeWindowView : MonoBehaviour
    {
        [SerializeField] private CustomButton _startButton;
        [SerializeField] private CustomButton _optionButton;

        private void Start()
        {
            _startButton.OnButtonClicked
                .Subscribe(_ => Debug.Log("Start!"))
                .AddTo(this.gameObject);
            
            _optionButton.OnButtonClicked
                .Subscribe(_ => Debug.Log("Option!"))
                .AddTo(this.gameObject);
            
            Debug.Log("subscribed");
        }
    }
}