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
        public partial interface OnBecameVisible
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnBecameVisible As<T>(in T target) => (OnBecameVisible<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnBecameVisible As<T>(ptr<T> target_ptr) => (OnBecameVisible<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnBecameVisible? As(object target) =>
                typeof(OnBecameVisible<>).CreateInterfaceHandler<OnBecameVisible>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class OnBecameVisible<T> : OnBecameVisible
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

            public OnBecameVisible(in T target) => m_target = target;

            public OnBecameVisible(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void OnBecameVisibleByPtr(ptr<T> value);
            private delegate void OnBecameVisibleByVal(T value);

            private static readonly OnBecameVisibleByPtr? s_OnBecameVisibleByPtr;
            private static readonly OnBecameVisibleByVal? s_OnBecameVisibleByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void OnBecameVisible()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_OnBecameVisibleByPtr is null || !m_target_is_ptr)
                {
                    s_OnBecameVisibleByVal!(target);
                    return;
                }

                s_OnBecameVisibleByPtr(m_target_ptr);
                return;
                
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static OnBecameVisible()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("OnBecameVisible");

                if (!(extensionMethod is null))
                    s_OnBecameVisibleByPtr = extensionMethod.CreateStaticDelegate(typeof(OnBecameVisibleByPtr)) as OnBecameVisibleByPtr;

                extensionMethod = targetType.GetExtensionMethod("OnBecameVisible");

                if (!(extensionMethod is null))
                    s_OnBecameVisibleByVal = extensionMethod.CreateStaticDelegate(typeof(OnBecameVisibleByVal)) as OnBecameVisibleByVal;

                if (s_OnBecameVisibleByPtr is null && s_OnBecameVisibleByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement OnBecameVisible.OnBecameVisible method", new Exception("OnBecameVisible"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator OnBecameVisible<T>(in ptr<T> target_ptr) => new OnBecameVisible<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator OnBecameVisible<T>(in T target) => new OnBecameVisible<T>(target);

            // Enable comparisons between nil and OnBecameVisible<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(OnBecameVisible<T> value, NilType nil) => Activator.CreateInstance<OnBecameVisible<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(OnBecameVisible<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, OnBecameVisible<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, OnBecameVisible<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class GoUnity_OnBecameVisibleExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.GoUnity_package.OnBecameVisible target)
        {
            try
            {
                return ((go.GoUnity_package.OnBecameVisible<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.GoUnity_package.OnBecameVisible target, out T result)
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
        public static object? _(this go.GoUnity_package.OnBecameVisible target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.GoUnity_package.OnBecameVisible<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.GoUnity_package.OnBecameVisible target, Type type, out object? result)
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