using UniRx;
using UnityEngine;

namespace Samples.Section3.FactoryMethods
{
    public class DeferSample : MonoBehaviour
    {
        private void Start()
        {
            // 「乱数を返すObservable」をSubscribeされるたびに生成する
            var rand = Observable.Defer(() =>
            {
                var randomValue = UnityEngine.Random.Range(0, 100);
                return Observable.Return(randomValue);
            });

            rand.Subscribe(x => Debug.Log("OnNext:" + x));
            rand.Subscribe(x => Debug.Log("OnNext:" + x));
            rand.Subscribe(x => Debug.Log("OnNext:" + x));
        }
    }
}