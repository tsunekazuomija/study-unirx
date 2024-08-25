using System;
using System.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace MyTest.Threading
{
    public class ThreadTest1 : MonoBehaviour
    {
        void Start()
        {
            int N = 3;

            Parallel.For(0, N, id =>
            {
                System.Random rand = new System.Random();

                for (int i=0; i< 4; ++i)
                {
                    Thread.Sleep(rand.Next(50, 100));
                    Debug.Log($"Thread {id} : {i}");
                }
            });
        }
    }

}
