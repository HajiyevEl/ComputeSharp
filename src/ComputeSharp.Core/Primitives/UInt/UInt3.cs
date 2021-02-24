﻿using System.Diagnostics;
using System.Runtime.InteropServices;
using ComputeSharp.Exceptions;

namespace ComputeSharp
{
    /// <summary>
    /// A <see langword="struct"/> that maps the <see langword="uint3"/> HLSL type.
    /// </summary>
    [DebuggerDisplay("({X}, {Y}, {Z})")]
    [StructLayout(LayoutKind.Sequential, Size = sizeof(uint) * 3)]
    public partial struct UInt3
    {
        /// <summary>
        /// Gets an <see cref="UInt3"/> value with all components set to 0.
        /// </summary>
        public static UInt3 Zero => 0;

        /// <summary>
        /// Gets an <see cref="UInt3"/> value with all components set to 1.
        /// </summary>
        public static UInt3 One => 1;

        /// <summary>
        /// Gets an <see cref="UInt3"/> value with the <see cref="X"/> component set to 1, and the others to 0.
        /// </summary>
        public static UInt3 UnitX => new(1, 0, 0);

        /// <summary>
        /// Gets an <see cref="UInt3"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
        /// </summary>
        public static UInt3 UnitY => new(0, 1, 0);

        /// <summary>
        /// Gets an <see cref="UInt3"/> value with the <see cref="Z"/> component set to 1, and the others to 0.
        /// </summary>
        public static UInt3 UnitZ => new(0, 0, 1);

        /// <summary>
        /// Creates a new <see cref="UInt3"/> instance with the specified parameters.
        /// </summary>
        /// <param name="x">The value to assign to the first vector component.</param>
        /// <param name="y">The value to assign to the second vector component.</param>
        /// <param name="z">The value to assign to the third vector component.</param>
        public UInt3(uint x, uint y, uint z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Gets or sets the value of the first vector component.
        /// </summary>
        public uint X { get; set; }

        /// <summary>
        /// Gets or sets the value of the second vector component.
        /// </summary>
        public uint Y { get; set; }

        /// <summary>
        /// Gets or sets the value of the third vector component.
        /// </summary>
        public uint Z { get; set; }

        /// <summary>
        /// Gets or sets the value of the first color component.
        /// </summary>
        public uint R
        {
            get => throw new InvalidExecutionContextException($"{nameof(UInt3)}.{nameof(R)}");
            set => throw new InvalidExecutionContextException($"{nameof(UInt3)}.{nameof(R)}");
        }

        /// <summary>
        /// Gets or sets the value of the second color component.
        /// </summary>
        public uint G
        {
            get => throw new InvalidExecutionContextException($"{nameof(UInt3)}.{nameof(G)}");
            set => throw new InvalidExecutionContextException($"{nameof(UInt3)}.{nameof(G)}");
        }

        /// <summary>
        /// Gets or sets the value of the third color component.
        /// </summary>
        public uint B
        {
            get => throw new InvalidExecutionContextException($"{nameof(UInt3)}.{nameof(B)}");
            set => throw new InvalidExecutionContextException($"{nameof(UInt3)}.{nameof(B)}");
        }

        /// <summary>
        /// Gets or sets a specific component in the current <see cref="UInt3"/> instance.
        /// </summary>
        /// <param name="i">The index of the component to access.</param>
        public uint this[int i]
        {
            get => throw new InvalidExecutionContextException($"{nameof(UInt3)}[int]");
            set => throw new InvalidExecutionContextException($"{nameof(UInt3)}[int]");
        }

        /// <summary>
        /// Creates a new <see cref="UInt3"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="UInt3"/> instance.</param>
        public static implicit operator UInt3(uint x) => new(x, x, x);

        /// <summary>
        /// Casts a <see cref="UInt3"/> value to a <see cref="Int3"/> one.
        /// </summary>
        /// <param name="xyz">The input <see cref="UInt3"/> value to cast.</param>
        public static explicit operator Int3(UInt3 xyz) => throw new InvalidExecutionContextException($"{nameof(UInt3)}.({nameof(Int3)})");

        /// <summary>
        /// Casts a <see cref="UInt3"/> value to a <see cref="Float3"/> one.
        /// </summary>
        /// <param name="xyz">The input <see cref="UInt3"/> value to cast.</param>
        public static implicit operator Float3(UInt3 xyz) => throw new InvalidExecutionContextException($"{nameof(UInt3)}.({nameof(Float3)})");

        /// <summary>
        /// Casts a <see cref="UInt3"/> value to a <see cref="Double3"/> one.
        /// </summary>
        /// <param name="xyz">The input <see cref="UInt3"/> value to cast.</param>
        public static implicit operator Double3(UInt3 xyz) => throw new InvalidExecutionContextException($"{nameof(UInt3)}.({nameof(Double3)})");

        /// <summary>
        /// Sums two <see cref="UInt3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="UInt3"/> value to sum.</param>
        /// <param name="right">The second <see cref="UInt3"/> value to sum.</param>
        public static UInt3 operator +(UInt3 left, UInt3 right) => throw new InvalidExecutionContextException($"{nameof(UInt3)}.+");

        /// <summary>
        /// Divides two <see cref="UInt3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="UInt3"/> value to divide.</param>
        /// <param name="right">The second <see cref="UInt3"/> value to divide.</param>
        public static UInt3 operator /(UInt3 left, UInt3 right) => throw new InvalidExecutionContextException($"{nameof(UInt3)}./");

        /// <summary>
        /// Multiplies two <see cref="UInt3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="UInt3"/> value to multiply.</param>
        /// <param name="right">The second <see cref="UInt3"/> value to multiply.</param>
        public static UInt3 operator *(UInt3 left, UInt3 right) => throw new InvalidExecutionContextException($"{nameof(UInt3)}.*");

        /// <summary>
        /// Subtracts two <see cref="UInt3"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="UInt3"/> value to subtract.</param>
        /// <param name="right">The second <see cref="UInt3"/> value to subtract.</param>
        public static UInt3 operator -(UInt3 left, UInt3 right) => throw new InvalidExecutionContextException($"{nameof(UInt3)}.-");
    }
}
