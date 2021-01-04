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
            bool Current();
            bool MoveNext();
            bool Reset();
        }

        // Unity Message Handlers
        public partial interface Awake
        {
            void Awake();
        }

        public partial interface Start
        {
            void Start();
        }

        public partial interface StartCoroutine
        {
            IEnumerator Start();
        }

        public partial interface FixedUpdate
        {
            void FixedUpdate();
        }

        public partial interface LateUpdate
        {
            void LateUpdate();
        }

        public partial interface Update
        {
            void Update();
        }

        public partial interface OnAnimatorIK
        {
            void OnAnimatorIK(nint layerIndex);
        }

        public partial interface OnAnimatorMove
        {
            void OnAnimatorMove();
        }

        public partial interface OnApplicationFocus
        {
            void OnApplicationFocus(bool hasFocus);
        }

        public partial interface OnApplicationPause
        {
            void OnApplicationPause(bool pauseStatus);
        }

        public partial interface OnApplicationQuit
        {
            void OnApplicationQuit();
        }

        public partial interface OnAudioFilterRead
        {
            void OnAudioFilterRead(slice<float> data, nint channels);
        }

        public partial interface OnBecameInvisible
        {
            void OnBecameInvisible();
        }

        public partial interface OnBecameVisible
        {
            void OnBecameVisible();
        }

        //type OnCollisionEnter interface { OnCollisionEnter(other Collision) } // <- needs type defintion
        // ... many more messages to define, work, work, work ...
    }
}
