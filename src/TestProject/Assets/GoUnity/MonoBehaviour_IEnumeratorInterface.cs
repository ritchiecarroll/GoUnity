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
using static go.builtin;

//#nullable enable
#pragma warning disable CS0660, CS0661

namespace go
{
    public static partial class GoUnity_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial interface IEnumerator
        {
        #if NET5_0
            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static IEnumerator As<T>(in T target) => (IEnumerator<T>)target!;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static IEnumerator As<T>(ptr<T> target_ptr) => (IEnumerator<T>)target_ptr;

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static IEnumerator? As(object target) =>
                typeof(IEnumerator<>).CreateInterfaceHandler<IEnumerator>(target);
        #endif
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public class IEnumerator<T> : IEnumerator
        {
            private T m_target = default;
            private readonly ptr<T> m_target_ptr;
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

            public IEnumerator(in T target) => m_target = target;

            public IEnumerator(ptr<T> target_ptr)
            {
                m_target_ptr = target_ptr;
                m_target_is_ptr = true;
            }

            private delegate object CurrentByPtr(ptr<T> value);
            private delegate object CurrentByVal(T value);

            private static readonly CurrentByPtr s_CurrentByPtr;
            private static readonly CurrentByVal s_CurrentByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public object Current()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_CurrentByPtr is null || !m_target_is_ptr)
                    return s_CurrentByVal(target);

                return s_CurrentByPtr(m_target_ptr);
            }

            private delegate bool MoveNextByPtr(ptr<T> value);
            private delegate bool MoveNextByVal(T value);

            private static readonly MoveNextByPtr s_MoveNextByPtr;
            private static readonly MoveNextByVal s_MoveNextByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool MoveNext()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_MoveNextByPtr is null || !m_target_is_ptr)
                    return s_MoveNextByVal(target);

                return s_MoveNextByPtr(m_target_ptr);
            }

            private delegate void ResetByPtr(ptr<T> value);
            private delegate void ResetByVal(T value);

            private static readonly ResetByPtr s_ResetByPtr;
            private static readonly ResetByVal s_ResetByVal;

            [DebuggerNonUserCode, MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void Reset()
            {
                T target = m_target;

                if (m_target_is_ptr && !(m_target_ptr is null))
                    target = m_target_ptr.val;

                if (s_ResetByPtr is null || !m_target_is_ptr)
                {
                    s_ResetByVal(target);
                    return;
                }

                s_ResetByPtr(m_target_ptr);
            }
            
            public string ToString(string format, IFormatProvider formatProvider) => format;

            [DebuggerStepperBoundary]
            static IEnumerator()
            {
                Type targetType = typeof(T);
                Type targetTypeByPtr = typeof(ptr<T>);
                MethodInfo extensionMethod;

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Current");

                if (!(extensionMethod is null))
                    s_CurrentByPtr = extensionMethod.CreateStaticDelegate(typeof(CurrentByPtr)) as CurrentByPtr;

                extensionMethod = targetType.GetExtensionMethod("Current");

                if (!(extensionMethod is null))
                    s_CurrentByVal = extensionMethod.CreateStaticDelegate(typeof(CurrentByVal)) as CurrentByVal;

                if (s_CurrentByPtr is null && s_CurrentByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement IEnumerator.Current method", new Exception("Current"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("MoveNext");

                if (!(extensionMethod is null))
                    s_MoveNextByPtr = extensionMethod.CreateStaticDelegate(typeof(MoveNextByPtr)) as MoveNextByPtr;

                extensionMethod = targetType.GetExtensionMethod("MoveNext");

                if (!(extensionMethod is null))
                    s_MoveNextByVal = extensionMethod.CreateStaticDelegate(typeof(MoveNextByVal)) as MoveNextByVal;

                if (s_MoveNextByPtr is null && s_MoveNextByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement IEnumerator.MoveNext method", new Exception("MoveNext"));

               extensionMethod = targetTypeByPtr.GetExtensionMethod("Reset");

                if (!(extensionMethod is null))
                    s_ResetByPtr = extensionMethod.CreateStaticDelegate(typeof(ResetByPtr)) as ResetByPtr;

                extensionMethod = targetType.GetExtensionMethod("Reset");

                if (!(extensionMethod is null))
                    s_ResetByVal = extensionMethod.CreateStaticDelegate(typeof(ResetByVal)) as ResetByVal;

                if (s_ResetByPtr is null && s_ResetByVal is null)
                    throw new NotImplementedException($"{targetType.FullName} does not implement IEnumerator.Reset method", new Exception("Reset"));
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator IEnumerator<T>(in ptr<T> target_ptr) => new IEnumerator<T>(target_ptr);

            [MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
            public static explicit operator IEnumerator<T>(in T target) => new IEnumerator<T>(target);

            // Enable comparisons between nil and IEnumerator<T> interface instance
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(IEnumerator<T> value, NilType nil) => Activator.CreateInstance<IEnumerator<T>>().Equals(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(IEnumerator<T> value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, IEnumerator<T> value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, IEnumerator<T> value) => value != nil;
        }
    }
}

namespace go
{
    public static class GoUnity_IEnumeratorExtensions
    {
        private static readonly ConcurrentDictionary<Type, MethodInfo> s_conversionOperators = new ConcurrentDictionary<Type, MethodInfo>();

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static T _<T>(this go.GoUnity_package.IEnumerator target)
        {
            try
            {
                return ((go.GoUnity_package.IEnumerator<T>)target).Target;
            }
            catch (NotImplementedException ex)
            {
                throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(typeof(T))}: missing method {ex.InnerException?.Message}");
            }
        }

        [GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        public static bool _<T>(this go.GoUnity_package.IEnumerator target, out T result)
        {
            try
            {
                result = target._<T>();
                return true;
            }
            catch (PanicException)
            {
                result = default;
                return false;
            }
        }

        //[GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        //public static object _(this go.GoUnity_package.IEnumerator target, Type type)
        //{
        //    try
        //    {
        //        MethodInfo conversionOperator = s_conversionOperators.GetOrAdd(type, _ => typeof(go.GoUnity_package.IEnumerator<>).GetExplicitGenericConversionOperator(type));

        //        if (conversionOperator is null)
        //            throw new PanicException($"interface conversion: failed to create converter for {GetGoTypeName(target.GetType())} to {GetGoTypeName(type)}");

        //        dynamic result = conversionOperator.Invoke(null, new object[] { target });
        //        return result?.Target;
        //    }
        //    catch (NotImplementedException ex)
        //    {
        //        throw new PanicException($"interface conversion: {GetGoTypeName(target.GetType())} is not {GetGoTypeName(type)}: missing method {ex.InnerException?.Message}");
        //    }
        //}

        //[GeneratedCode("go2cs", "0.1.0.0"), MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]
        //public static bool _(this go.GoUnity_package.IEnumerator target, Type type, out object result)
        //{
        //    try
        //    {
        //        result = target._(type);
        //        return true;
        //    }
        //    catch (PanicException)
        //    {
        //        result = type.IsValueType ? Activator.CreateInstance(type) : null;
        //        return false;
        //    }
        //}
    }
}