//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2021 January 04 00:17:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

#nullable enable

namespace go
{
    public static partial class GoUnity_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(SplineFollow3D))]
        public partial struct SplineIterator
        {
            // SplineFollow3D structure promotion - sourced from value copy
            private readonly ptr<SplineFollow3D> m_SplineFollow3DRef;

            private ref SplineFollow3D SplineFollow3D_val => ref m_SplineFollow3DRef.val;

            public ref nint Segments => ref m_SplineFollow3DRef.val.Segments;

            public ref bool DoLoop => ref m_SplineFollow3DRef.val.DoLoop;

            public ref Transform Cube => ref m_SplineFollow3DRef.val.Cube;

            public ref float Speed => ref m_SplineFollow3DRef.val.Speed;

            // Constructors
            public SplineIterator(NilType _)
            {
                this.m_SplineFollow3DRef = new ptr<SplineFollow3D>(new SplineFollow3D(nil));
                this.line = default;
                this.dist = default;
            }

            public SplineIterator(SplineFollow3D SplineFollow3D = default, VectorLine line = default, float dist = default)
            {
                this.m_SplineFollow3DRef = new ptr<SplineFollow3D>(SplineFollow3D);
                this.line = line;
                this.dist = dist;
            }

            // Enable comparisons between nil and SplineIterator struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SplineIterator value, NilType nil) => value.Equals(default(SplineIterator));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SplineIterator value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SplineIterator value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SplineIterator value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SplineIterator(NilType nil) => default(SplineIterator);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SplineIterator SplineIterator_cast(dynamic value)
        {
            return new SplineIterator(value.SplineFollow3D, value.line, value.dist);
        }
    }
}
