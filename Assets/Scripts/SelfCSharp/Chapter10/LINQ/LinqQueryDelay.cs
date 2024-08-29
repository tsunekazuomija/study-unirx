using UnityEngine;
using System.Linq;

namespace SelfCSharp.Chapter10.LINQ
{
    public class LinqQueryDelay : MonoBehaviour
    {
        private void Start()
        {
            // 遅延実行
            var bs = from b in AppTables.Books select b.Title;

            AppTables.Books.ElementAt(0).Title = "独学できるPHP";
            foreach (var b in bs)
            {
                Debug.Log(b);
            }

            // 遅延実行をその場で確定（即時実行）
            // var bs = (from b in AppTables.Books select b.Title).ToArray();
            // AppTables.Books.ElementAt(0).Title = "独学できるPHP";
            // foreach (var b in bs)
            // {
            //     Debug.Log(b);
            // }
        }
    }
}