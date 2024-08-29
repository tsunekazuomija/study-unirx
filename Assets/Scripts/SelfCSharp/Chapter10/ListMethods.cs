using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SelfCSharp.Chapter10
{
    public class ListMethods : MonoBehaviour
    {
        private void Start()
        {
            // ForEachメソッド
            // var list = new List<int> { 1, 3, 6, 9 };
            // list.ForEach(i => Debug.Log(i*i));

            // ConvertAllメソッド
            // var list = new List<string> {
            //     "カラスなぜ鳴くの",
            //     "カラスは山に",
            //     "かわいい七つの",
            //     "子があるからよ"
            // };
            // var result = list.ConvertAll(str => str[..5]);
            // foreach (var s in result)
            // {
            //     Debug.Log(s);
            // }

            // Findメソッド
            // var list = new List<string> {
            //     "カラスなぜ鳴くの",
            //     "カラスは山に",
            //     "かわいい七つの",
            //     "子があるからよ"
            // };
            // var result = list.Find(str => str.StartsWith("カラス"));
            // Debug.Log(result);


            // FindAllメソッド
            // var list = new List<string> {
            //     "カラスなぜ鳴くの",
            //     "カラスは山に",
            //     "かわいい七つの",
            //     "子があるからよ"
            // };

            // var result = list.FindAll(str => str.StartsWith("カラス"));

            // foreach (var s in result)
            // {
            //     Debug.Log(s);
            // }


            // FindIndex, FindLastIndexメソッド
            // var list = new List<int> { 1, -15, 30, 60, -50, 40 };
            // Debug.Log(list.FindIndex(v => v < 0));
            // Debug.Log(list.FindLastIndex(v => v < 0));
            // Debug.Log(list.FindIndex(2, 3, v => v < 0));

            // Existsメソッド
            // var list = new List<string> {
            //     "カラスなぜ鳴くの",
            //     "カラスは山に",
            //     "かわいい七つの",
            //     "子があるからよ"
            // };
            // Debug.Log(list.Exists(str => str.Length >= 7));

            // TrueForAllメソッド
            // var list = new List<string> {
            //     "カラスなぜ鳴くの",
            //     "カラスは山に",
            //     "かわいい七つの",
            //     "子があるからよ"
            // };
            // Debug.Log(list.TrueForAll(str => str.Length < 10));

            // RemoveAllメソッド
            // var list = new List<int> { 1, -15, 30, 60, -50, 40 };
            // list.RemoveAll(v => v < 0);
            // foreach (var i in list)
            // {
            //     Debug.Log(i);
            // }

            // 確認テスト
            var list = new List<string> {
                "カイリュー",
                "リザードン",
                "ボーマンダ",
                "サザンドラ",
                "ファイアロー",
            };
            Debug.Log(list.TrueForAll(str => str.Length <= 6));
        }
    }
}