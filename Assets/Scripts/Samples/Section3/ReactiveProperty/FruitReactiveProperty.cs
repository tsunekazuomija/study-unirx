using System;
using UniRx;

namespace Samples.Section3.ReactiveProperty
{
    public enum Fruit
    {
        Apple,
        Banana,
        Peach,
        Melon,
        Orange,
    }

    [Serializable]
    public class FruitReactiveProperty : ReactiveProperty<Fruit>
    {
        public FruitReactiveProperty()
        {
        }

        public FruitReactiveProperty(Fruit init) : base(init)
        {
        }
    }
}
