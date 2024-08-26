using UniRx;
using UnityEngine;

namespace Samples.Section3.ReactiveProperty
{
    public class ReadOnlyReactivePropertySample : MonoBehaviour
    {
        void Start()
        {
            var intReactiveProperty = new ReactiveProperty<int>(100);

            var readOnlyInt =
                intReactiveProperty.ToReadOnlyReactiveProperty();
            
            // readできる
            Debug.Log(readOnlyInt.Value); // 100

            // 購読できる
            readOnlyInt.Subscribe(x => Debug.Log("通知された値" + x));

            // readOnlyInt.Value = 10; // 代入できない

            intReactiveProperty.Dispose();

        }

    }

}