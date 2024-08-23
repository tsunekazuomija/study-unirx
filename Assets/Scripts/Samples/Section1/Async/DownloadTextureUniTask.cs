using System;
using System.Threading;
using UniRx;
// using Cysharp.Threading.Tasks; 見つからない。どうして？

using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Samples.Section1.Async
{
    public class DownloadTextureUniTask : MonoBehaviour
    {
        // [SerializeField] RawImage _rawImage;
        // [SerializeField] string _uri;

        // void Start()
        // {
        //     // このgameobjectに紐づいたcancellationTokenをしゅとく
        //     var token = this.GetCancellationTokenOnDestroy();

        //     SetupTextureAsync(token).Forget();
        // }

        // async UniTaskVoid SetupTextureAsync(CancellationToken token)

    }

    //UniTaskVoid が認識されない。

}