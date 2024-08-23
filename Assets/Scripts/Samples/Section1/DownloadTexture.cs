using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace Samples.Section1
{
    public class DownloadTexture : MonoBehaviour
    {

        [SerializeField] RawImage _rawImage;
        [SerializeField] string _uri;

        void Start()
        {

            var uri = _uri;

            GetTextureAsync(uri)
                .OnErrorRetry(
                    onError: (Exception _) => {},
                    retryCount: 3
                ).Subscribe(
                    result => { _rawImage.texture = result;},
                    error => { Debug.LogError(error); }
                ).AddTo(this);
        }

        // コルーチンを起動、その結果をObservableで返す
        IObservable<Texture> GetTextureAsync(string uri)
        {
            return Observable
                .FromCoroutine<Texture>(observer =>
                {
                    return GetTextureCoroutine(observer, uri);
                });
        }

        IEnumerator GetTextureCoroutine(IObserver<Texture> observer, string uri)
        {
            using (var uwr = UnityWebRequestTexture.GetTexture(uri))
            {
                yield return uwr.SendWebRequest();

                if (uwr.result == UnityWebRequest.Result.ConnectionError || uwr.result == UnityWebRequest.Result.ProtocolError)
                {
                    // エラーが起きたら OnErrorメッセージを発行
                    observer.OnError(new Exception(uwr.error));
                    yield break;
                }

                var result = ((DownloadHandlerTexture) uwr.downloadHandler).texture;

                // 成功したら OnNext/OnCompletedメッセージを発行
                observer.OnNext(result);
                observer.OnCompleted();

            }
        }
    }
}
