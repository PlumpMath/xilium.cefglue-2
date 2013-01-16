//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_task_runner_t
    {
        internal cef_base_t _base;
        internal IntPtr _is_same;
        internal IntPtr _belongs_to_current_thread;
        internal IntPtr _belongs_to_thread;
        internal IntPtr _post_task;
        internal IntPtr _post_delayed_task;
        
        // GetForCurrentThread
        [DllImport(libcef.DllName, EntryPoint = "cef_task_runner_get_for_current_thread", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_task_runner_t* get_for_current_thread();
        
        // GetForThread
        [DllImport(libcef.DllName, EntryPoint = "cef_task_runner_get_for_thread", CallingConvention = libcef.CEF_CALL)]
        public static extern cef_task_runner_t* get_for_thread(CefThreadId threadId);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int add_ref_delegate(cef_task_runner_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int release_delegate(cef_task_runner_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int get_refct_delegate(cef_task_runner_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int is_same_delegate(cef_task_runner_t* self, cef_task_runner_t* that);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int belongs_to_current_thread_delegate(cef_task_runner_t* self);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int belongs_to_thread_delegate(cef_task_runner_t* self, CefThreadId threadId);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int post_task_delegate(cef_task_runner_t* self, cef_task_t* task);
        
        [UnmanagedFunctionPointer(libcef.CEF_CALLBACK)]
        #if !DEBUG
        [SuppressUnmanagedCodeSecurity]
        #endif
        private delegate int post_delayed_task_delegate(cef_task_runner_t* self, cef_task_t* task, long delay_ms);
        
        // AddRef
        private static IntPtr _p0;
        private static add_ref_delegate _d0;
        
        public static int add_ref(cef_task_runner_t* self)
        {
            add_ref_delegate d;
            var p = self->_base._add_ref;
            if (p == _p0) { d = _d0; }
            else
            {
                d = (add_ref_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(add_ref_delegate));
                if (_p0 == IntPtr.Zero) { _d0 = d; _p0 = p; }
            }
            return d(self);
        }
        
        // Release
        private static IntPtr _p1;
        private static release_delegate _d1;
        
        public static int release(cef_task_runner_t* self)
        {
            release_delegate d;
            var p = self->_base._release;
            if (p == _p1) { d = _d1; }
            else
            {
                d = (release_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(release_delegate));
                if (_p1 == IntPtr.Zero) { _d1 = d; _p1 = p; }
            }
            return d(self);
        }
        
        // GetRefCt
        private static IntPtr _p2;
        private static get_refct_delegate _d2;
        
        public static int get_refct(cef_task_runner_t* self)
        {
            get_refct_delegate d;
            var p = self->_base._get_refct;
            if (p == _p2) { d = _d2; }
            else
            {
                d = (get_refct_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(get_refct_delegate));
                if (_p2 == IntPtr.Zero) { _d2 = d; _p2 = p; }
            }
            return d(self);
        }
        
        // IsSame
        private static IntPtr _p3;
        private static is_same_delegate _d3;
        
        public static int is_same(cef_task_runner_t* self, cef_task_runner_t* that)
        {
            is_same_delegate d;
            var p = self->_is_same;
            if (p == _p3) { d = _d3; }
            else
            {
                d = (is_same_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(is_same_delegate));
                if (_p3 == IntPtr.Zero) { _d3 = d; _p3 = p; }
            }
            return d(self, that);
        }
        
        // BelongsToCurrentThread
        private static IntPtr _p4;
        private static belongs_to_current_thread_delegate _d4;
        
        public static int belongs_to_current_thread(cef_task_runner_t* self)
        {
            belongs_to_current_thread_delegate d;
            var p = self->_belongs_to_current_thread;
            if (p == _p4) { d = _d4; }
            else
            {
                d = (belongs_to_current_thread_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(belongs_to_current_thread_delegate));
                if (_p4 == IntPtr.Zero) { _d4 = d; _p4 = p; }
            }
            return d(self);
        }
        
        // BelongsToThread
        private static IntPtr _p5;
        private static belongs_to_thread_delegate _d5;
        
        public static int belongs_to_thread(cef_task_runner_t* self, CefThreadId threadId)
        {
            belongs_to_thread_delegate d;
            var p = self->_belongs_to_thread;
            if (p == _p5) { d = _d5; }
            else
            {
                d = (belongs_to_thread_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(belongs_to_thread_delegate));
                if (_p5 == IntPtr.Zero) { _d5 = d; _p5 = p; }
            }
            return d(self, threadId);
        }
        
        // PostTask
        private static IntPtr _p6;
        private static post_task_delegate _d6;
        
        public static int post_task(cef_task_runner_t* self, cef_task_t* task)
        {
            post_task_delegate d;
            var p = self->_post_task;
            if (p == _p6) { d = _d6; }
            else
            {
                d = (post_task_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(post_task_delegate));
                if (_p6 == IntPtr.Zero) { _d6 = d; _p6 = p; }
            }
            return d(self, task);
        }
        
        // PostDelayedTask
        private static IntPtr _p7;
        private static post_delayed_task_delegate _d7;
        
        public static int post_delayed_task(cef_task_runner_t* self, cef_task_t* task, long delay_ms)
        {
            post_delayed_task_delegate d;
            var p = self->_post_delayed_task;
            if (p == _p7) { d = _d7; }
            else
            {
                d = (post_delayed_task_delegate)Marshal.GetDelegateForFunctionPointer(p, typeof(post_delayed_task_delegate));
                if (_p7 == IntPtr.Zero) { _d7 = d; _p7 = p; }
            }
            return d(self, task, delay_ms);
        }
        
    }
}
