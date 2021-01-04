package GoUnity

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
type IEnumerator interface {
    Current() object
    MoveNext() bool
    Reset()
}

// Unity Message Handlers
type IAwake interface { Awake() }

type IStart interface { Start() }

type IStartCoroutine interface { Start() IEnumerator }

type IFixedUpdate interface { FixedUpdate() }

type ILateUpdate interface { LateUpdate() }

type IUpdate interface { Update() }

type IOnAnimatorIK interface { OnAnimatorIK(layerIndex int) }

type IOnAnimatorMove interface { OnAnimatorMove() }

type IOnApplicationFocus interface { OnApplicationFocus(hasFocus bool) }

type IOnApplicationPause interface { OnApplicationPause(pauseStatus bool)}

type IOnApplicationQuit interface { OnApplicationQuit() }

type IOnAudioFilterRead interface { OnAudioFilterRead(data []float32, channels int) }

type IOnBecameInvisible interface { OnBecameInvisible() }

type IOnBecameVisible interface { OnBecameVisible() }

type IOnCollisionEnter interface { OnCollisionEnter(other Collision) }

// ... many more messages to define, work, work, work ...
