using System;
using UnityEngine;

namespace SelfCSharp.Chapter10
{
    public class LambdaAccess : MonoBehaviour
    {
        private void Start()
        {
            var msg = "Hello, World!";

            // ラムダ式は上位スコープの変数にアクセスできる。
            // ただし、ローカル関数でもふつうにアクセスできる。
            Action show = () => Debug.Log(msg);
            show();
        }

    }
}