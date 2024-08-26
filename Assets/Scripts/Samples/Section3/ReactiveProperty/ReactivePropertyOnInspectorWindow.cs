using UniRx;
using UnityEngine;

namespace Samples.Section3.ReactiveProperty
{
    public class ReactivePropertyOnInspectorWindow : MonoBehaviour
    {
        // 本には、ジェネリック版はインスペクタに表示されないと書かれているが、
        // 2022.3.12f1では表示される.
        [SerializeField] ReactiveProperty<int> A;

        [SerializeField] IntReactiveProperty B;
    }
}
