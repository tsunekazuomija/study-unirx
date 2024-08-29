using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqSkip : MonoBehaviour
    {
        private void Start()
        {
            var bs = AppTables.Books
                .OrderBy(b => b.Published)
                .Skip(2)
                .Take(3)
                .Select(b => b);
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}