using System;
using System.Collections;
using UniRx;
using UnityEngine;

namespace Samples.Section3.Subjects.Aync
{
    public class GameResourceProvider : MonoBehaviour
    {
        private readonly AsyncSubject<Texture> _playerTextureAsyncSubject = new AsyncSubject<Texture>();

        public IObservable<Texture> PlayerTextureAsync => _playerTextureAsyncSubject;

        private void Start()
        {
            StartCoroutine(LoadTexture());
        }

        IEnumerator LoadTexture()
        {
            var resource = Resources.LoadAsync<Texture>("Textures/player");

            yield return resource;

            _playerTextureAsyncSubject.OnNext(resource.asset as Texture);
            _playerTextureAsyncSubject.OnCompleted();
            Debug.Log("LoadTexture completed");
        }
    }

}
