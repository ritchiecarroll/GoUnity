// This is currently a manual conversion - a tool needs to be developed, i.e.,
// "unity-target.exe" to automate this class wrapper generation step.

// ** Example Post Build Operation Header **
// post-build[unity-target: type=MonoBehaviour; filename=SplineExampleUnity.cs; namespace=SplineExample]
// build target: "type SplineFollow3D struct" from SplineExample.go, line 15
// unity-target operation executed at 2021 January 03 23:13:04 UTC

// TODO: Determine if other imports could be needed (maybe just use those from: "go2cs: inject-code[using")
using UnityEngine;
using go;
using GoUnity = go.GoUnity_package;
using static go.builtin;

namespace SplineExample
{
    // Simple MonoBehaviour-based class wrapper for Go SplineFollow3D structure
    public class SplineFollow3D : MonoBehaviour
    {
        // Heap allocated instance of converted Go structure
        private ptr<GoUnity.SplineFollow3D> m_SplineFollow3D;
        
        // Go interface implementations representing optional UnityEngine message handlers
        // TODO: will need scan for all possible, could use an attribute marker
        private GoUnity.Awake m_Awake;
        private GoUnity.StartCoroutine m_StartCoroutine;

        SplineFollow3D()
        {
            // Create an instance of Go-based MonoBehaviour
            m_SplineFollow3D = builtin.addr(new GoUnity.SplineFollow3D());
            
            // Get an instance of each implemented interface
            m_Awake = GoUnity.Awake.As(m_SplineFollow3D);
            m_StartCoroutine = GoUnity.StartCoroutine.As(m_SplineFollow3D);
        }

        /* Public Script Fields -- exposed to, and serialized by, Unity editor */
        
        public int Segments
        {
            get => m_SplineFollow3D.val.Segments;
            set => m_SplineFollow3D.val.Segments = value;
        }

        public bool DoLoop
        {
            get => m_SplineFollow3D.val.DoLoop;
            set => m_SplineFollow3D.val.DoLoop = value;
        }

        public Transform Cube
        {
            get => m_SplineFollow3D.val.Cube;
            set => m_SplineFollow3D.val.Cube = value;
        }

        public float Speed
        {
            get => m_SplineFollow3D.val.Speed;
            set => m_SplineFollow3D.val.Speed = value;
        }

        /* Implemented Unity Message Handlers */

        public void Awake() => m_Awake.Awake();

        public IEnumerator Start()
        {
            // Handle coroutine iterator-based message handler
            GoUnity.IEnumerator iterator = m_StartCoroutine.Start();
            
            while (iterator.MoveNext())
                yield return iterator.Current();
        }
    }
}
