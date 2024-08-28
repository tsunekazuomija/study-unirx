using System;
using UnityEngine;

namespace SelfCSharp.Chapter10
{
    public class LambdaCapture : MonoBehaviour
    {
        // ラムダ式を返すメソッド
        Action CreateAction(int init)
        {
            int value = init;
            return () =>
            {
                value++;
                Debug.Log(value);
            };
        }

        private void Start()
        {
            var show = CreateAction(10);
            show();
            show();
        }
    }
}