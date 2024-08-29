using System.Linq;
using UnityEngine;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqStartsWith : MonoBehaviour
    {
        private void Start()
        {
            var bs = AppTables.Books
                .Where(b => b.Title.StartsWith("Android"))
                .Select(b => b);
            
            foreach (var b in bs)
            {
                Debug.Log(b);
            }
        }
    }
}