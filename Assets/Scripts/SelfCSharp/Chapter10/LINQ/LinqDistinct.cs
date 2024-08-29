using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqDistinct : MonoBehaviour
    {
        private void Start()
        {
            var bs = AppTables.Books
                .Select(b => b.Publisher)
                .Distinct();
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}