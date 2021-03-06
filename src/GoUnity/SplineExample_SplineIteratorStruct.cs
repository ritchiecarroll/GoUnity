//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2021 January 04 10:02:35 UTC
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
        public partial struct SplineIterator
        {
            // Constructors
            public SplineIterator(NilType _)
            {
                this.source = default;
                this.line = default;
                this.dist = default;
            }

            public SplineIterator(ref ptr<SplineFollow3D> source = default, VectorLine line = default, float dist = default)
            {
                this.source = source;
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
            return new SplineIterator(ref value.source, value.line, value.dist);
        }
    }
}