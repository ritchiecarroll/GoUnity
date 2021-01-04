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
        public partial interface OnApplicationPause
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnApplicationPause As<T>(in T target) => (OnApplicationPause<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnApplicationPause As<T>(ptr<T> target_ptr) => (OnApplicationPause<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static OnApplicationPause? As(object target) =>
                typeof(OnApplicationPause<>).CreateInterfaceHandler<OnApplicationPause>(target);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class OnApplicationPause<T> : OnApplicationPause
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

            public OnApplicationPause(in T target) => m_target = target;

            public OnApplicationPause(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate void OnApplicationPauseByPtr(ptr<T> value, bool pauseStatus);
            private delegate void OnApplicationPauseByVal(T value, bool pauseStatus);

            private static readonly OnApplicationPauseByPtr? s_OnApplicationPauseByPtr;
            private static readonly OnApplicationPauseByVal? s_OnApplicationPauseByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void OnApplicationPause(bool pauseStatus)
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_OnApplicationPauseByPtr is null || !m_target_is_ptr)
                {
                    s_OnApplicationPauseByVal!(target, pauseStatus);
                    return;
                }

                s_OnApplicationPauseByPtr(m_target_ptr, pauseStatus);
                return;
                
            }
            
            public string ToString(string? format, IFormatProvider? formatProvider) => format;

            [DebuggerStepperBoundary]
            static OnApplicationPause()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("OnApplicationPause");

                if (!(extensionMethod is null))
                    s_OnApplicationPauseByPtr = extensionMethod.CreateStaticDelegate(typeof(OnApplicationPauseByPtr)) as OnApplicationPauseByPtr;

                extensionMethod = targetType.GetExtensionMethod("OnApplicationPause");

                if (!(extensionMethod is null))
                    s_OnApplicationPauseByVal = extensionMethod.CreateStaticDelegate(typeof(OnApplicationPauseByVal)) as OnApplicationPauseByVal;

                if (s_OnApplicationPauseByPtr is null && s_OnApplicationPauseByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement OnApplicationPause.OnApplicationPause method", new Exception("OnApplicationPause"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator OnApplicationPause<T>(in ptr<T> target_ptr) => new OnApplicationPause<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator OnApplicationPause<T>(in T target) => new OnApplicationPause<T>(target);

            // Enable comparisons between nil and OnApplicationPause<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(OnApplicationPause<T> value, NilType nil) => Activator.CreateInstance<OnApplicationPause<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(OnApplicationPause<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, OnApplicationPause<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, OnApplicationPause<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class GoUnity_OnApplicationPauseExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.GoUnity_package.OnApplicationPause target)
        {
            try
            {
                return ((go.GoUnity_package.OnApplicationPause<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.GoUnity_package.OnApplicationPause target, out T result)
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
        public static object? _(this go.GoUnity_package.OnApplicationPause target, Type type)
        {
            try
            {
                MethodInfo? conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.GoUnity_package.OnApplicationPause<>).GetExplicitGenericConversionOperator(type));

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
        public static bool _(this go.GoUnity_package.OnApplicationPause target, Type type, out object? result)
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