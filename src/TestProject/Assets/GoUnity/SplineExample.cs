// package GoUnity -- go2cs converted at 2021 January 03 23:49:24 UTC
// import "GoUnity" ==> using GoUnity = go.GoUnity_package
// Original source: C:\Projects\GoUnity\src\GoUnity\SplineExample.go
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

using fmt = go.fmt_package;
using static go.builtin;

#pragma warning disable CS0660, CS0661, CS0282

namespace go
{
    public static partial class GoUnity_package
    {
        //go2cs: post-build[unity-target.exe type=MonoBehaviour filename=SplineFollow3D.cs namespace=SplineExample]
        public partial struct SplineFollow3D
        {
            public int Segments; // <- these public fields will be exposed to Unity editor
            public bool DoLoop;
            public Transform Cube;
            public float Speed;
        }

        public partial struct SplineIterator
        {
            public ptr<SplineFollow3D> source;
            public VectorLine line;
            public float dist;
        }

        private static void Awake(this ptr<SplineFollow3D> _addr_behaviour)
        {
            ref SplineFollow3D behaviour = ref _addr_behaviour.val;
 
            // Set initial default values, Unity will serialize changes made in editor
            if (behaviour.Segments == 0)
            {
                behaviour.Segments = 250;
                behaviour.DoLoop = true;
                behaviour.Speed = 0.05F;
            }
        }

        private static IEnumerator Start(this ptr<SplineFollow3D> _addr_behaviour)
        {
            ref SplineFollow3D behaviour = ref _addr_behaviour.val;
 
            // Note that VectorLine expects a .NET List of Vector3 objects - this does not need
            // to exist here in Go (not compiling here), it just needs to be valid Go syntax for
            // the go2cs conversion process. Unity will compile translated C# version of code.
            List<Vector3> points = new List<Vector3>(behaviour.Segments+1);

            slice<Vector3> splinePoints = default;
            int i = 1;

            var obj = GameObject.Find(fmt.Sprintf("Sphere{0}", i));
            i += 1;

            while ((obj != null))
            {
                splinePoints = append(splinePoints, obj.transform.position);
                obj = GameObject.Find(fmt.Sprintf("Sphere{0}", i));
                i += 1;
            }

            VectorLine line = new VectorLine("Spline",points,2.0F,LineType.Continuous);
            line.MakeSpline(splinePoints.ToArray(), behaviour.Segments, behaviour.DoLoop);
            line.Draw3D();

            return new IEnumerator<SplineIterator>(addr(new SplineIterator(ref _addr_behaviour, line,0.0F)));
        }

        private static bool MoveNext(this ptr<SplineIterator> _addr_iterator)
        {
            ref SplineIterator iterator = ref _addr_iterator.val;

            ref SplineFollow3D behaviour = ref iterator.source.val;

            // Make the cube "ride" the spline at a constant speed
            if (iterator.dist < 1.0F)
            {
                iterator.dist += Time.deltaTime * behaviour.Speed;
                behaviour.Cube.position = iterator.line.GetPoint3D01(iterator.dist);
            }
            else if (behaviour.DoLoop)
            {
                _addr_iterator.Reset();
            }
            else
            {
                return false;
            }
            return true;
        }

        private static void Reset(this ptr<SplineIterator> _addr_iterator)
        {
            ref SplineIterator iterator = ref _addr_iterator.val;

            iterator.dist = 0.0F;
        }

        private static object Current(this ptr<SplineIterator> _addr_iterator)
        {
            ref SplineIterator iterator = ref _addr_iterator.val;

            return null;
        }
    }
}
