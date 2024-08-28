using UnityEngine;

namespace SelfCSharp.Chapter10
{
    public class DelegateMulti : MonoBehaviour
    {
        void ArrayWalk(string[] data, OutputProcess output)
        {
            foreach (var value in data)
            {
                output(value);
            }
        }

        void AddQuote(string data)
        {
            Debug.Log($"[{data}]");
        }

        void Front4(string data)
        {
            Debug.Log(data[..4]);
        }

        private void Start()
        {
            var data = new[] {"あかまきがみ", "あおまきがみ", "きまきがみ"};
            OutputProcess proc = AddQuote;
            proc += Front4;
            proc -= AddQuote;
            ArrayWalk(data, proc);
        }
    }
}