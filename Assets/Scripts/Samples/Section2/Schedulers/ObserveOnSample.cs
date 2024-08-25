using System.IO;
using System.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace Samples.Section2.Schedulers
{

    public class ObserveOnSample : MonoBehaviour
    {
        void Start()
        {
            // ファイルをスレッドプールで読み込む
            var task = Task.Run(() => File.ReadAllText(@"README.md"));

            // Task -> Observable変換
            // 実行コンテキストはスレッドプールのまま
            task.ToObservable()
                // メインスレッドに切り替え
                .ObserveOn(Scheduler.MainThread)
                .Subscribe(x =>
                {
                    Debug.Log(x);
                    Debug.Log("Thread ID:" + System.Threading.Thread.CurrentThread.ManagedThreadId);
                });


        }
    }

}