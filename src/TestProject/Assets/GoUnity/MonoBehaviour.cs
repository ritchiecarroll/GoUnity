// package GoUnity -- go2cs converted at 2021 January 04 00:17:04 UTC
// import "GoUnity" ==> using GoUnity = go.GoUnity_package
// Original source: C:\Projects\GoUnity\src\GoUnity\MonoBehaviour.go

using static go.builtin;

namespace go
{
    public static partial class GoUnity_package
    {
        // Technically the following items do not need to be defined since these items will be resolved
        // at compile time by Unity compiler. However, they may be useful for intellisense type operations
        // in Go source in the future...

        /*
        type MonoBehaviour struct {
            enabled bool            // Enabled Behaviours are Updated, disabled Behaviours are not.
            isActiveAndEnabled bool // Has the Behaviour had active and enabled called?
            gameObject GameObject   // The game object this component is attached to. A component is always attached to a game object.
            tag string              // The tag of this game object.
            transform Transform     // The Transform attached to this GameObject.
            hideFlags int           // Should the object be hidden, saved with the Scene or modifiable by the user?
            name string             // The name of the object.
        }

        // Public Methods
        func (behaviour *MonoBehaviour) CancelInvoke() {}
        func (behaviour *MonoBehaviour) Invoke(methodName string, time float32) {}
        // ... add remaining methods ...

        // Static Methods
        func print(message interface{}) {}
        func Destroy(obj interface{}, t float32) {}
        // ... add remaining static methods ...
        */

        // Iterator Interface for Coroutines
        public partial interface IEnumerator
        {
            object Current();
            bool MoveNext();
            void Reset();
        }

        // Unity Message Handlers
        public partial interface IAwake
        {
            void Awake();
        }

        public partial interface IStartCoroutine
        {
            IEnumerator Start();
        }
    }
}
