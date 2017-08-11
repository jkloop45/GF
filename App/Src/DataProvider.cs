using App.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Src
{
    public class DataProvider
    {
        private static T[] MapToArray<T>(IntPtr ptr, int count)
            where T : struct
        {
            T[] buffer = new T[count];
            for (int i = 0; i < count; i++)
            {
                buffer[i] = MapTo<T>(new IntPtr(ptr.ToInt32() + Marshal.SizeOf(typeof(T)) * i));
            }
            return buffer;
        }
        private static T MapTo<T>(IntPtr ptr) where T : struct
        {
            return (T)Marshal.PtrToStructure(ptr, typeof(T));
        }

        public static PInfo[] getProcesses()
        {
            int count = 0;
            IntPtr ptr = getProcesses(ref count);
            return MapToArray<PInfo>(ptr, count);
        }

        [DllImport("Providers.dll", EntryPoint = "getProcesses", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        private extern static IntPtr getProcesses(ref int count);

        [DllImport("Providers.dll", EntryPoint = "gggg", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr getMemoryInfo(long pid, int addr, int length);

        //[DllImport("Providers.dll", EntryPoint = "getCount", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
        //public extern static int* getCount(ref int[] aaa);
    }
}
