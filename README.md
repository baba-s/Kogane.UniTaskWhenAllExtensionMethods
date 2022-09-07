# Kogane UniTask When All Extension Methods

UniTask.WhenAll・WhenAny を拡張メソッドで呼び出せるようにするパッケージ

## 使用例

### Before

```csharp
using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class Example : MonoBehaviour
{
    private async UniTaskVoid Start()
    {
        var list = new List<UniTask>();

        for ( var i = 0; i < 10; i++ )
        {
            list.Add( UniTask.Delay( TimeSpan.FromSeconds( 1 ) ) );
        }

        await UniTask.WhenAll( list );
    }
}
```

### After

```csharp
using System;
using System.Linq;
using Cysharp.Threading.Tasks;
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private async UniTaskVoid Start()
    {
        await Enumerable
                .Range( 0, 10 )
                .Select( x => UniTask.Delay( TimeSpan.FromSeconds( 1 ) ) )
                .WhenAll()
            ;
    }
}
```