using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Src.Models
{
    [StructLayoutAttribute(LayoutKind.Sequential)]
    public struct PInfo
    {
        public uint pid;
        [MarshalAs(UnmanagedType.LPStr, SizeConst = 255)]
        public string pname;

        //public string name
        //{
        //    get
        //    {
        //        return new string((sbyte*)pname, 0, 255, Encoding.UTF8);
        //    }
        //}
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        //public char[] pname;
        //[System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst =255, ArraySubType = System.Runtime.InteropServices.UnmanagedType.SysUInt)]
        //public System.IntPtr[] lpData;
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
        //public char[] pname;
    }
}
