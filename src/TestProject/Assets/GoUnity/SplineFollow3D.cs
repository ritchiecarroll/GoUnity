// This is currently a manual conversion - a tool needs to be developed, i.e.,
// "unity-target.exe" to automate this class wrapper generation step.

// ** Example Post Build Operation Header **
// post-build[unity-target: type=MonoBehaviour; filename=SplineFollow3D.cs; namespace=SplineExample]
// build target: "type SplineFollow3D struct" from SplineExample.go, line 15
// unity-target operation executed at 2021 January 03 23:13:04 UTC

// TODO: Determine if other imports are needed (maybe just use those from: "go2cs: inject-code[using")
using System.Collections;
using UnityEngine;
using go;
using GoUnity = go.GoUnity_package;
using static go.builtin;

namespace SplineExample
{
    // Simple MonoBehaviour-based class wrapper for Go SplineFollow3D structure
    public partial class SplineFollow3D : MonoBehaviour
    {
        // Heap allocated instance of converted Go structure
        private readonly ptr<GoUnity.SplineFollow3D> m_SplineFollow3D;
        
        // Go interface implementations representing optional UnityEngine message handlers
        // TODO: will need scan for all possible, could use an attribute marker
        private readonly GoUnity.IAwake m_Awake;
        private readonly GoUnity.IStartCoroutine m_StartCoroutine;

        SplineFollow3D()
        {
            // Create an instance of Go-based MonoBehaviour
            m_SplineFollow3D = addr(new GoUnity.SplineFollow3D());
            
            // Get an instance of each implemented interface
        #if NET5_0
            // C# 9.0 allows methods in an interface - Unity may not support this yet
            m_Awake = GoUnity.IAwake.As(m_SplineFollow3D);
            m_StartCoroutine = GoUnity.IStartCoroutine.As(m_SplineFollow3D);
        #else
            m_Awake = new GoUnity.IAwake<GoUnity.SplineFollow3D>(m_SplineFollow3D);
            m_StartCoroutine = new GoUnity.IStartCoroutine<GoUnity.SplineFollow3D>(m_SplineFollow3D);
        #endif
        }

        /* Public Script Fields -- exposed to, and serialized by, Unity editor */

        [SerializeField, GetSet("Segments")]
        private int m_Segments;

        [SerializeField, GetSet("DoLoop")]
        private bool m_DoLoop;

        [SerializeField, GetSet("Cube")]
        private Transform m_Cube;

        [SerializeField, GetSet("Speed")]
        private float m_Speed;

        /* Implemented Unity Message Handlers */

        public void Awake()
        {
            m_Awake.Awake();
            IntializeBackingFields();
        }

        public IEnumerator Start()
        {
            // Handle coroutine iterator-based message handler
            GoUnity.IEnumerator iterator = m_StartCoroutine.Start();
            
            while (iterator.MoveNext())
                yield return iterator.Current();
        }
    }
}
