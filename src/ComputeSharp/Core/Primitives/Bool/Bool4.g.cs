﻿using System.Runtime.InteropServices;
using ComputeSharp.Exceptions;

namespace ComputeSharp
{
    /// <inheritdoc cref="Bool4"/>
    [StructLayout(LayoutKind.Explicit, Size = 16, Pack = 4)]
    public partial struct Bool4
    {
        [FieldOffset(0)]
        private bool x;

        [FieldOffset(4)]
        private bool y;

        [FieldOffset(8)]
        private bool z;

        [FieldOffset(12)]
        private bool w;

        /// <summary>
        /// Gets a reference to a specific component in the current <see cref="Bool4"/> instance.
        /// </summary>
        /// <param name="i">The index of the component to access.</param>
        public ref bool this[int i] => throw new InvalidExecutionContextException($"{typeof(Bool4)}[{typeof(int)}]");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the <c>X</c> component.
        /// </summary>
        public ref bool X => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(X)}");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the <c>Y</c> component.
        /// </summary>
        public ref bool Y => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(Y)}");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the <c>Z</c> component.
        /// </summary>
        public ref bool Z => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(Z)}");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the <c>W</c> component.
        /// </summary>
        public ref bool W => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(W)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool2 XX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool2 XY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool2 XZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool2 XW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool2 YX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool2 YY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool2 YZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool2 YW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool2 ZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool2 ZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool2 ZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool2 ZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool2 WX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool2 WY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool2 WZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool2 WW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 XXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 XXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 XXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 XXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 XYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 XYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool3 XYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool3 XYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 XZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool3 XZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 XZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool3 XZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 XWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool3 XWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool3 XWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 XWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 YXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 YXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool3 YXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool3 YXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 YYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 YYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 YYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 YYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool3 YZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 YZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 YZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool3 YZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool3 YWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 YWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool3 YWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 YWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 ZXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool3 ZXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 ZXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool3 ZXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool3 ZYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 ZYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 ZYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool3 ZYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 ZZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 ZZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 ZZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 ZZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool3 ZWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool3 ZWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 ZWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 ZWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 WXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool3 WXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool3 WXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 WXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool3 WYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 WYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool3 WYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 WYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool3 WZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool3 WZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 WZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 WZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool3 WWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool3 WWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool3 WWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool3 WWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XXXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XXXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XXXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XXXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XXYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XXYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XXYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XXYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XXZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XXZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XXZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XXZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XXWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XXWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XXWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XXWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XXWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XYXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XYXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XYXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XYXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XYYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XYYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XYYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XYYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XYZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XYZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XYZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYZZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool4 XYZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XYWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XYWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYWY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool4 XYWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XYWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XYWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XZXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XZXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XZXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XZXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XZYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XZYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XZYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZYZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool4 XZYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XZZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XZZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XZZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XZZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XZWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZWX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool4 XZWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XZWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XZWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XZWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XWXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XWXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XWXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XWXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XWYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XWYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWYY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool4 XWYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XWYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XWZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWZX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool4 XWZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XWZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XWZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 XWWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 XWWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 XWWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="X"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 XWWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(XWWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YXXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YXXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YXXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YXXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YXYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YXYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YXYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YXYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YXZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YXZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YXZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXZZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool4 YXZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YXWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YXWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXWY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool4 YXWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YXWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YXWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YYXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YYXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YYXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YYXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YYYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YYYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YYYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YYYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YYZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YYZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YYZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YYZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YYWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YYWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YYWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YYWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YYWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YZXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YZXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YZXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZXZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool4 YZXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YZYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YZYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YZYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YZYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YZZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YZZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YZZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YZZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZZW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool4 YZWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YZWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YZWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YZWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YZWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YWXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YWXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWXY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool4 YWXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YWXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YWYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YWYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YWYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YWYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWYW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool4 YWZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YWZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YWZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YWZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 YWWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 YWWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 YWWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 YWWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(YWWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZXXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZXXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZXXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZXXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZXYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZXYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZXYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXYZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool4 ZXYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZXZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZXZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZXZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZXZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZXWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXWX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool4 ZXWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZXWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZXWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZXWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZYXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZYXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZYXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYXZ)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref Bool4 ZYXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZYYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZYYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZYYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZYYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZYZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZYZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZYZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZYZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYZW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool4 ZYWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZYWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZYWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZYWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZYWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZZXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZZXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZZXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZZXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZZYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZZYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZZYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZZYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZZZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZZZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZZZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZZZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZZWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZZWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZZWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZZWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZZWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZWXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWXX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool4 ZWXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZWXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZWXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWXW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool4 ZWYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZWYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZWYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZWYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZWZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZWZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZWZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZWZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 ZWWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 ZWWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 ZWWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 ZWWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ZWWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WXXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WXXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WXXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WXXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WXYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WXYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXYY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool4 WXYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WXYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WXZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXZX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool4 WXZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WXZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WXZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WXWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WXWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WXWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="X"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WXWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WXWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WYXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WYXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYXY)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref Bool4 WYXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WYXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WYYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WYYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WYYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WYYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYYW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool4 WYZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WYZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WYZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WYZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WYWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WYWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WYWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WYWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WYWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WZXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZXX)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref Bool4 WZXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WZXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WZXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZXW)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref Bool4 WZYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WZYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WZYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WZYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WZZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WZZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WZZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WZZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WZWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WZWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WZWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WZWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WZWW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WWXX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWXX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WWXY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWXY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WWXZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWXZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="X"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WWXW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWXW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WWYX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWYX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WWYY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWYY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WWYZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWYZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WWYW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWYW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WWZX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWZX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WWZY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWZY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WWZZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWZZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WWZW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWZW)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="X"/>.
        /// </summary>
        public ref readonly Bool4 WWWX => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWWX)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Y"/>.
        /// </summary>
        public ref readonly Bool4 WWWY => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWWY)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="Z"/>.
        /// </summary>
        public ref readonly Bool4 WWWZ => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWWZ)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="W"/>, <see cref="W"/>, <see cref="W"/>, <see cref="W"/>.
        /// </summary>
        public ref readonly Bool4 WWWW => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(WWWW)}");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the <c>R</c> component.
        /// </summary>
        public ref bool R => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(R)}");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the <c>G</c> component.
        /// </summary>
        public ref bool G => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(G)}");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the <c>B</c> component.
        /// </summary>
        public ref bool B => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(B)}");

        /// <summary>
        /// Gets a reference to the <see cref="bool"/> value representing the <c>A</c> component.
        /// </summary>
        public ref bool A => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(A)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool2 RR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool2 RG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool2 RB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool2 RA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool2 GR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool2 GG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool2 GB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool2 GA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool2 BR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool2 BG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool2 BB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool2 BA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool2 AR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool2 AG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool2"/> value with the components <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool2 AB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool2"/> value with the components <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool2 AA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 RRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 RRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 RRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 RRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 RGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 RGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool3 RGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool3 RGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 RBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool3 RBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 RBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool3 RBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 RAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool3 RAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool3 RAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 RAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 GRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 GRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool3 GRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool3 GRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 GGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 GGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 GGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 GGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool3 GBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 GBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 GBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool3 GBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool3 GAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 GAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool3 GAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 GAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 BRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool3 BRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 BRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool3 BRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool3 BGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 BGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 BGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool3 BGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 BBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 BBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 BBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 BBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool3 BAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool3 BAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 BAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 BAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 ARR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool3 ARG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool3 ARB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 ARA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool3 AGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 AGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool3 AGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 AGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool3 ABR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool3 ABG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 ABB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 ABA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool3 AAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool3 AAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool3 AAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool3"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool3 AAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RRRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RRRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RRRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RRRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RRGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RRGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RRGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RRGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RRBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RRBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RRBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RRBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RRAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RRAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RRAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RRAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RRAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RGRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RGRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RGRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RGRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RGGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RGGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RGGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RGGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RGBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RGBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RGBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGBB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool4 RGBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RGAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RGAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGAG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool4 RGAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RGAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RGAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RBRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RBRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RBRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RBRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RBGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RBGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RBGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBGB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool4 RBGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RBBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RBBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RBBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RBBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RBAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBAR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool4 RBAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RBAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RBAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RBAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RARR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RARR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RARG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RARG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RARB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RARB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RARA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RARA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RAGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RAGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAGG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool4 RAGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RAGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RABR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RABR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool4 RABG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RABG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RABB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RABB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RABA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RABA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 RAAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 RAAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 RAAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="R"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 RAAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(RAAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GRRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GRRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GRRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GRRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GRGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GRGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GRGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GRGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GRBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GRBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GRBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRBB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool4 GRBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GRAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GRAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRAG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool4 GRAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GRAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GRAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GGRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GGRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GGRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GGRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GGGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GGGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GGGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GGGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GGBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GGBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GGBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GGBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GGAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GGAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GGAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GGAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GGAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GBRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GBRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GBRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBRB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool4 GBRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GBGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GBGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GBGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GBGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GBBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GBBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GBBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GBBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBBA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool4 GBAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GBAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GBAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GBAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GBAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GARR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GARR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GARG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GARG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool4 GARB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GARB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GARA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GARA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GAGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GAGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GAGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GAGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAGA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool4 GABR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GABR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GABG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GABG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GABB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GABB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GABA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GABA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 GAAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 GAAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 GAAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="G"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 GAAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(GAAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BRRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BRRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BRRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BRRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BRGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BRGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BRGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRGB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool4 BRGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BRBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BRBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BRBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BRBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BRAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRAR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool4 BRAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BRAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BRAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BRAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BGRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BGRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BGRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGRB)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref Bool4 BGRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BGGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BGGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BGGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BGGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BGBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BGBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BGBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BGBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGBA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool4 BGAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BGAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BGAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BGAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BGAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BBRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BBRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BBRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BBRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BBGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BBGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BBGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BBGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BBBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BBBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BBBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BBBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BBAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BBAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BBAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BBAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BBAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BARR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BARR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool4 BARG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BARG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BARB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BARB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BARA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BARA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool4 BAGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BAGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BAGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BAGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BABR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BABR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BABG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BABG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BABB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BABB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BABA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BABA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 BAAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 BAAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 BAAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="B"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 BAAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(BAAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 ARRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 ARRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 ARRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 ARRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 ARGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 ARGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARGG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool4 ARGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 ARGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 ARBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARBR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool4 ARBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 ARBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 ARBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 ARAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 ARAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 ARAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="R"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 ARAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ARAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 AGRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGRR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 AGRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGRG)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref Bool4 AGRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 AGRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGRA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 AGGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 AGGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 AGGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 AGGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGGA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool4 AGBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 AGBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 AGBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 AGBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 AGAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 AGAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 AGAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="G"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 AGAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AGAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 ABRR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABRR)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref Bool4 ABRG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABRG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 ABRB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABRB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 ABRA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABRA)}");

        /// <summary>
        /// Gets a reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref Bool4 ABGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 ABGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 ABGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 ABGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 ABBR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABBR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 ABBG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABBG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 ABBB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABBB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 ABBA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABBA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 ABAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 ABAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 ABAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="B"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 ABAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(ABAA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 AARR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AARR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 AARG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AARG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 AARB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AARB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="R"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 AARA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AARA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 AAGR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAGR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 AAGG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAGG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 AAGB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAGB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="G"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 AAGA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAGA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 AABR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AABR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 AABG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AABG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 AABB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AABB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="B"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 AABA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AABA)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="R"/>.
        /// </summary>
        public ref readonly Bool4 AAAR => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAAR)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="G"/>.
        /// </summary>
        public ref readonly Bool4 AAAG => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAAG)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="B"/>.
        /// </summary>
        public ref readonly Bool4 AAAB => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAAB)}");

        /// <summary>
        /// Gets a readonly reference to the <see cref="Bool4"/> value with the components <see cref="A"/>, <see cref="A"/>, <see cref="A"/>, <see cref="A"/>.
        /// </summary>
        public ref readonly Bool4 AAAA => throw new InvalidExecutionContextException($"{typeof(Bool4)}.{nameof(AAAA)}");
    }
}