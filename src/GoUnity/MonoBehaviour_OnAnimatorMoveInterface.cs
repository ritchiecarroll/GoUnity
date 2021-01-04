//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2021 January 04 00:17:04 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class GoUnity_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface OnAnimatorMove
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnAnimatorMove As<T>(in T target) => (OnAnimatorMove<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnAnimatorMove As<T>(ptr<T> target_ptr) => (OnAnimatorMove<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnAnimatorMove? As(object target) =>
                typeof(OnAnimatorMove<>).CreateInterfaceHandler<OnAnimatorMove>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class OnAnimatorMove<T> : OnAnimatorMove
        {
            private T m_target = default!;
            private readonly ptr<T>? m_target_ptr;
            private readonly bool m_target_is_ptr;

            public ref T Target
            {
                get
                {
                    if (m_target_is_ptr && !(m_target_ptr is null))
                        return ref m_target_ptr.val;

                    return ref m_target;
                }
            }

            public OnAnimatorMove(in T target) => m_target = target;

            public OnAnimatorMove(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void OnAnimatorMoveByPtr(ptr<T> value);
            private delegate void OnAnimatorMoveByVal(T value);

            private static readonly OnAnimatorMoveByPtr? s_OnAnimatorMoveByPtr;
            private static readonly OnAnimatorMoveByVal? s_OnAnimatorMoveByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void OnAnimatorMove()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_OnAnimatorMoveByPtr is null || !m_target_is_ptr)
                {
                    s_OnAnimatorMoveByVal!(target);
                    return;
                }

                s_OnAnimatorMoveByPtr(m_target_ptr);
                return;
                
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static OnAnimatorMove()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("OnAnimatorMove");

                if (!(extensionMethod is null))
                    s_OnAnimatorMoveByPtr = extensionMethod.CreateStaticDelegate(typeof(OnAnimatorMoveByPtr)) as OnAnimatorMoveByPtr;

                extensionMethod = targetType.GetExtensionMethod("OnAnimatorMove");

                if (!(extensionMethod is null))
                    s_OnAnimatorMoveByVal = extensionMethod.CreateStaticDelegate(typeof(OnAnimatorMoveByVal)) as OnAnimatorMoveByVal;

                if (s_OnAnimatorMoveByPtr is null && s_OnAnimatorMoveByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement OnAnimatorMove.OnAnimatorMove method", new Exception("OnAnimatorMove"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator OnAnimatorMove<T>(in ptr<T> target_ptr) => new OnAnimatorMove<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator OnAnimatorMove<T>(in T target) => new OnAnimatorMove<T>(target);

            // Enable comparisons between nil and OnAnimatorMove<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(OnAnimatorMove<T> value, NilType nil) => Activator.CreateInstance<OnAnimatorMove<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(OnAnimatorMove<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, OnAnimatorMove<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, OnAnimatorMove<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class GoUnity_OnAnimatorMoveExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.GoUnity_package.OnAnimatorMove target)
        {
            try
            {
                return ((go.GoUnity_package.OnAnimatorMove<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.GoUnity_package.OnAnimatorMove target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default!;
                return false;
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static object? _(this go.GoUnity_package.OnAnimatorMove target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.GoUnity_package.OnAnimatorMove<>).GetExplicitGenericConversionOperator(type));

                if (conversionOperator is null)
                    throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

                dynamic? result = conversionOperator.Invoke(null, new object[] { target });
                return result?.Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _(this go.GoUnity_package.OnAnimatorMove target, Type type, out object? result)
        {
            try
            {
                result = target._(type);
                return true;
            }
            catch (PanicException)
            {
                result = type.IsValueType ? Activator.CreateInstance(type) : null;
                return false;
            }
        }
    }
}