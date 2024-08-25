using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Samples.Section2.Observables
{
    // subscribeをgameobjectのondestroy時にdisposeする
    public class AddToSample : MonoBehaviour
    {
        void Start()
        {
            Observable.IntervalFrame(5)
                .Subscribe(_ => Debug.Log("Do!"))
                .AddTo(this);
        }
    }

}