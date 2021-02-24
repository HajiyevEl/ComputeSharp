﻿using System.Diagnostics;
using System.Runtime.InteropServices;
using ComputeSharp.Exceptions;

namespace ComputeSharp
{
    /// <summary>
    /// A <see langword="struct"/> that maps the <see langword="double2"/> HLSL type.
    /// </summary>
    [DebuggerDisplay("({X}, {Y})")]
    [StructLayout(LayoutKind.Sequential, Size = sizeof(double) * 2)]
    public partial struct Double2
    {
        /// <summary>
        /// Gets an <see cref="Double2"/> value with all components set to 0.
        /// </summary>
        public static Double2 Zero => 0;

        /// <summary>
        /// Gets an <see cref="Double2"/> value with all components set to 1.
        /// </summary>
        public static Double2 One => 1;

        /// <summary>
        /// Gets an <see cref="Double2"/> value with the <see cref="X"/> component set to 1, and the others to 0.
        /// </summary>
        public static Double2 UnitX => new(1, 0);

        /// <summary>
        /// Gets an <see cref="Double2"/> value with the <see cref="Y"/> component set to 1, and the others to 0.
        /// </summary>
        public static Double2 UnitY => new(0, 1);

        /// <summary>
        /// Creates a new <see cref="Double2"/> instance with the specified parameters.
        /// </summary>
        /// <param name="x">The value to assign to the first vector component.</param>
        /// <param name="y">The value to assign to the second vector component.</param>
        public Double2(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets or sets the value of the first vector component.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the value of the second vector component.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Gets or sets the value of the first color component.
        /// </summary>
        public double R
        {
            get => throw new InvalidExecutionContextException($"{nameof(Double2)}.{nameof(R)}");
            set => throw new InvalidExecutionContextException($"{nameof(Double2)}.{nameof(R)}");
        }

        /// <summary>
        /// Gets or sets the value of the second color component.
        /// </summary>
        public double G
        {
            get => throw new InvalidExecutionContextException($"{nameof(Double2)}.{nameof(G)}");
            set => throw new InvalidExecutionContextException($"{nameof(Double2)}.{nameof(G)}");
        }

        /// <summary>
        /// Gets or sets a specific component in the current <see cref="Double2"/> instance.
        /// </summary>
        /// <param name="i">The index of the component to access.</param>
        public double this[int i]
        {
            get => throw new InvalidExecutionContextException($"{nameof(Double2)}[int]");
            set => throw new InvalidExecutionContextException($"{nameof(Double2)}[int]");
        }

        /// <summary>
        /// Creates a new <see cref="Double2"/> value with the same value for all its components.
        /// </summary>
        /// <param name="x">The value to use for the components of the new <see cref="Double2"/> instance.</param>
        public static implicit operator Double2(double x) => new(x, x);

        /// <summary>
        /// Casts a <see cref="Double2"/> value to a <see cref="Int2"/> one.
        /// </summary>
        /// <param name="xy">The input <see cref="Double2"/> value to cast.</param>
        public static explicit operator Int2(Double2 xy) => throw new InvalidExecutionContextException($"{nameof(Double2)}.({nameof(Int2)})");

        /// <summary>
        /// Casts a <see cref="Double2"/> value to a <see cref="UInt2"/> one.
        /// </summary>
        /// <param name="xy">The input <see cref="Double2"/> value to cast.</param>
        public static explicit operator UInt2(Double2 xy) => throw new InvalidExecutionContextException($"{nameof(Double2)}.({nameof(UInt2)})");

        /// <summary>
        /// Casts a <see cref="Double2"/> value to a <see cref="Float2"/> one.
        /// </summary>
        /// <param name="xy">The input <see cref="Double2"/> value to cast.</param>
        public static explicit operator Float2(Double2 xy) => throw new InvalidExecutionContextException($"{nameof(Double2)}.({nameof(Float2)})");

        /// <summary>
        /// Negates a <see cref="Double2"/> value.
        /// </summary>
        /// <param name="xy">The <see cref="Double2"/> value to negate.</param>
        public static Double2 operator -(Double2 xy) => throw new InvalidExecutionContextException($"{nameof(Double2)}.-");

        /// <summary>
        /// Sums two <see cref="Double2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Double2"/> value to sum.</param>
        /// <param name="right">The second <see cref="Double2"/> value to sum.</param>
        public static Double2 operator +(Double2 left, Double2 right) => throw new InvalidExecutionContextException($"{nameof(Double2)}.+");

        /// <summary>
        /// Divides two <see cref="Double2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Double2"/> value to divide.</param>
        /// <param name="right">The second <see cref="Double2"/> value to divide.</param>
        public static Double2 operator /(Double2 left, Double2 right) => throw new InvalidExecutionContextException($"{nameof(Double2)}./");

        /// <summary>
        /// Multiplies two <see cref="Double2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Double2"/> value to multiply.</param>
        /// <param name="right">The second <see cref="Double2"/> value to multiply.</param>
        public static Double2 operator *(Double2 left, Double2 right) => throw new InvalidExecutionContextException($"{nameof(Double2)}.*");

        /// <summary>
        /// Subtracts two <see cref="Double2"/> values.
        /// </summary>
        /// <param name="left">The first <see cref="Double2"/> value to subtract.</param>
        /// <param name="right">The second <see cref="Double2"/> value to subtract.</param>
        public static Double2 operator -(Double2 left, Double2 right) => throw new InvalidExecutionContextException($"{nameof(Double2)}.-");
    }
}
