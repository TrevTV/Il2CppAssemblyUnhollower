using System;
using UnhollowerBaseLib.Runtime.VersionSpecific.Type;

namespace UnhollowerBaseLib.Runtime.VersionSpecific.Class
{
    public interface INativeClassStructHandler : INativeStructHandler
    {
        INativeClassStruct CreateNewClassStruct(int vTableSlots);
        unsafe INativeClassStruct Wrap(Il2CppClass* classPointer);
#if DEBUG
        string GetName();
#endif
    }

    public interface INativeClassStruct : INativeStruct
    {
        unsafe Il2CppClass* ClassPointer { get; }
        IntPtr VTable { get; }

        ref uint InstanceSize { get; }
        ref ushort VtableCount { get; }
        ref ushort InterfaceCount { get; }
        ref ushort InterfaceOffsetsCount { get; }
        ref byte TypeHierarchyDepth { get; }
        ref int NativeSize { get; }
        ref uint ActualSize { get; }
        ref ushort MethodCount { get; }
        ref Il2CppClassAttributes Flags { get; }

        bool ValueType { get; set; }
        bool EnumType { get; set; }
        bool IsGeneric { get; set; }
        bool Initialized { get; set; }
        bool InitializedAndNoError { get; set; }
        bool SizeInited { get; set; }
        bool HasFinalize { get; set; }
        bool IsVtableInitialized { get; set; }

        ref IntPtr Name { get; }
        ref IntPtr Namespace { get; }

        INativeTypeStruct ByValArg { get; }
        INativeTypeStruct ThisArg { get; }

        ref byte Rank { get; }
        
        unsafe ref Il2CppImage* Image { get; }
        unsafe ref Il2CppClass* Parent { get; }
        unsafe ref Il2CppClass* ElementClass { get; }
        unsafe ref Il2CppClass* CastClass { get; }
        unsafe ref Il2CppClass* Class { get; }

        unsafe ref Il2CppMethodInfo** Methods { get; }
        unsafe ref Il2CppClass** ImplementedInterfaces { get; }
        unsafe ref Il2CppRuntimeInterfaceOffsetPair* InterfaceOffsets { get; }
        unsafe ref Il2CppClass** TypeHierarchy { get; }
    }
}