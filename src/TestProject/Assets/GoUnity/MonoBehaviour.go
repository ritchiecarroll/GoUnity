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
    Current() interface{}
    MoveNext() bool
    Reset()
}

// Unity Message Handlers
type Awake interface { Awake() }

type Start interface { Start() }

type StartCoroutine interface { Start() IEnumerator }

type FixedUpdate interface { FixedUpdate() }

type LateUpdate interface { LateUpdate() }

type Update interface { Update() }

type OnAnimatorIK interface { OnAnimatorIK(layerIndex int) }

type OnAnimatorMove interface { OnAnimatorMove() }

type OnApplicationFocus interface { OnApplicationFocus(hasFocus bool) }

type OnApplicationPause interface { OnApplicationPause(pauseStatus bool)}

type OnApplicationQuit interface { OnApplicationQuit() }

type OnAudioFilterRead interface { OnAudioFilterRead(data []float32, channels int) }

type OnBecameInvisible interface { OnBecameInvisible() }

type OnBecameVisible interface { OnBecameVisible() }

//type OnCollisionEnter interface { OnCollisionEnter(other Collision) } // <- needs type defintion
// ... many more messages to define, work, work, work ...
