using System;
using UnityEngine;

namespace SelfCSharp.Chapter10
{
    public class DelegateAnonymous : MonoBehaviour
    {

        void ArrayWalk(string[] data, Func<string, string> output)
        {
            foreach (var value in data)
            {
                Debug.Log(output(value));
            }
        }

        private void Start()
        {
            var data = new[] {"あかまきがみ", "あおまきがみ", "きまきがみ"};
            // ArrayWalk(data, delegate(string d) // 匿名メソッド
            // {
            //     return $"[{d}]";
            // });

            // ラムダ式を使う場合
            // ArrayWalk(data, (string d) =>
            // {
            //     return $"[{d}]";
            // }
            // );

            // 本体が1行の場合は{}を省略できる
            // ArrayWalk(data, (string d) => $"[{d}]");

            // 引数の型は暗黙に推論される
            // ArrayWalk(data, (d) => $"[{d}]");

            // 引数が1つの場合は()を省略できる
            ArrayWalk(data, d => $"[{d}]");
        }
    }
}