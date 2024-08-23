using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace Samples.Section1
{
    public class ThrottleButton : MonoBehaviour
    {
        void Start()
        {
            // updateのタイミングでattackbuttonが押されているか判定
            // attackbuttonがおされたらsubscribeの処理を実行
            // その後30フレームはボタン入力を無視
            this.UpdateAsObservable()
                .Where(_ => Input.GetKeyDown(KeyCode.Space))
                .ThrottleFirstFrame(120)
                .Subscribe(_ => Debug.Log("Attack!"));
        }
    }

}
