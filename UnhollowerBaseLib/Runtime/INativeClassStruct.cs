using System;

namespace UnhollowerBaseLib.Runtime
{
    public interface INativeClassStruct
    {
        IntPtr Pointer { get; }
        unsafe Il2CppClass* ClassPointer { get; }
        IntPtr VTable { get; }

        ref uint InstanceSize { get; }
        ref ushort VtableCount { get; }
        ref int NativeSize { get; }
        ref uint ActualSize { get; }
        ref ushort MethodCount { get; }
        ref ClassBitfield1 Bitfield1 { get; }
        ref ClassBitfield2 Bitfield2 { get; }
        ref Il2CppClassAttributes Flags { get; }
        
        ref IntPtr Name { get; }
        ref IntPtr Namespace { get; }
        
        ref Il2CppTypeStruct ByValArg { get; }
        ref Il2CppTypeStruct ThisArg { get; }
        
        unsafe ref Il2CppImage* Image { get; }
        unsafe ref Il2CppClass* Parent { get; }
        unsafe ref Il2CppClass* ElementClass { get; }
        unsafe ref Il2CppClass* CastClass { get; }
        unsafe ref Il2CppClass* Class { get; }
        
        unsafe ref Il2CppMethodInfo** Methods { get; }
    }
}