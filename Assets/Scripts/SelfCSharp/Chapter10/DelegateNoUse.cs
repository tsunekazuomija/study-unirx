using UnityEngine;

namespace SelfCSharp.Chapter10
{
    public class DelegateNoUse : MonoBehaviour
    {
        /// <summary>文字列配列の内容をブラケット付きで出力する</summary>
        void ArrayWalk(string[] data)
        {
            foreach (var value in data)
            {
                Debug.Log($"[{value}]");
            }
        }

        void Start()
        {
            var data = new[] {"あかまきがみ", "あおまきがみ", "きまきがみ"};
            ArrayWalk(data);
        }
    }
}