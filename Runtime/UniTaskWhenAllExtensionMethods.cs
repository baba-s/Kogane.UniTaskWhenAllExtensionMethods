using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace Kogane
{
    public static class UniTaskWhenAllExtensionMethods
    {
        public static UniTask WhenAll( this IEnumerable<UniTask> self )
        {
            return UniTask.WhenAll( self );
        }

        public static UniTask WhenAny( this IEnumerable<UniTask> self )
        {
            return UniTask.WhenAny( self );
        }
    }
}