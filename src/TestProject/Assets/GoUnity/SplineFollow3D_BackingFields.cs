using System.Collections;
using UnityEngine;
using go;
using GoUnity = go.GoUnity_package;
using static go.builtin;

namespace SplineExample
{
    public partial class SplineFollow3D
    {
        private void IntializeBackingFields()
        {
            ref GoUnity.SplineFollow3D behaviour = ref m_SplineFollow3D.val;

            behaviour.Segments = m_Segments;
            behaviour.DoLoop = m_DoLoop;
            behaviour.Cube = m_Cube;
            behaviour.Speed = m_Speed;
        }

        public int Segments
        {
            get => m_Segments;
            set => m_Segments = m_SplineFollow3D.val.Segments = value;
        }

        public bool DoLoop
        {
            get => m_DoLoop;
            set
            {
                m_DoLoop = value;
                m_SplineFollow3D.val.DoLoop = value;
            }
        }

        public Transform Cube
        {
            get => m_Cube;
            set
            {
                m_Cube = value;
                m_SplineFollow3D.val.Cube = value;
            }
        }

        public float Speed
        {
            get => m_Speed;
            set
            {
                m_Speed = value;
                m_SplineFollow3D.val.Speed = value;
            }
        }
    }
}
