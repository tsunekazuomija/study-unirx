using UniRx;
using UnityEngine;

namespace Samples.Section3.Subjects.Aync
{

    public class PlayerTextureChanger : MonoBehaviour
    {
        [SerializeField]
        GameResourceProvider _gameResourceProvider;

        [SerializeField] Texture _texture;

        void Start()
        {
            // プレイヤのテクスチャの読み込みが完了次第テクスチャを変更
            _gameResourceProvider.PlayerTextureAsync
                .Subscribe(SetMyTexture)
                .AddTo(this);
        }

        void SetMyTexture(Texture newTexture)
        {
            _texture = newTexture;
            Debug.Log("SetMyTexture");
            var r = GetComponent<MeshRenderer>();
            r.materials = new Material[] { new Material(r.material) { mainTexture = newTexture } };
        }

        
    }
}

