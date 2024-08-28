using UnityEngine;

namespace SelfCSharp.Chapter10
{
    delegate void OutputProcess(string str);

    public class DelegateUse : MonoBehaviour
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

        void Start()
        {
            var data = new[] {"あかまきがみ", "あおまきがみ", "きまきがみ"};
            ArrayWalk(data, AddQuote);
        }
    }
}