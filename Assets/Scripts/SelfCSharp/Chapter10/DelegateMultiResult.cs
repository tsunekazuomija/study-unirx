using UnityEngine;

namespace SelfCSharp.Chapter10
{
    delegate string OutputProcessResult(string str);
    public class DelegateMultiResult : MonoBehaviour
    {
        void ArrayWalk(string[] data, OutputProcessResult output)
        {
            foreach (var value in data)
            {
                Debug.Log(output(value));
            }
        }

        string AddQuote(string data)
        {
            return $"[{data}]";
        }

        string Front4(string data)
        {
            return data[..4];
        }

        private void Start()
        {
            var data = new[] {"あかまきがみ", "あおまきがみ", "きまきがみ"};
            OutputProcessResult proc = AddQuote;
            proc += Front4;
            
            // delegateが返り値を持つ場合、最後のメソッドの返り値が出力される
            ArrayWalk(data, proc);

        }
    }
}