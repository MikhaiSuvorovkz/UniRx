﻿using System;
using System.Collections.Generic;

using UniRx.InternalUtil;

using UnityEngine;

namespace UniRx
{
	/// <summary>
	/// Inspectable ReactiveProperty.
	/// </summary>
	[Serializable]
	public class IntReactiveProperty : ReactiveProperty<int>
	{
		public IntReactiveProperty() : base() { }

		public IntReactiveProperty(int initialValue) : base(initialValue) { }

		public static implicit operator int(IntReactiveProperty property) => property.Value;
	}

	/// <summary>
	/// Inspectable ReactiveProperty.
	/// </summary>
	[Serializable]
	public class LongReactiveProperty : ReactiveProperty<long>
	{
		public LongReactiveProperty() : base() { }

		public LongReactiveProperty(long initialValue) : base(initialValue) { }
		public static implicit operator long(LongReactiveProperty property) => property.Value;
	}

	/// <summary>
	/// Inspectable ReactiveProperty.
	/// </summary>
	[Serializable]
	public class ByteReactiveProperty : ReactiveProperty<byte>
	{
		public ByteReactiveProperty() : base() { }

		public ByteReactiveProperty(byte initialValue) : base(initialValue) { }
		public static implicit operator byte(ByteReactiveProperty property) => property.Value;
	}

	/// <summary>
	/// Inspectable ReactiveProperty.
	/// </summary>
	[Serializable]
	public class FloatReactiveProperty : ReactiveProperty<float>
	{
		public FloatReactiveProperty() : base() { }

		public FloatReactiveProperty(float initialValue) : base(initialValue) { }
		public static implicit operator float(FloatReactiveProperty property) => property.Value;
	}

	/// <summary>
	/// Inspectable ReactiveProperty.
	/// </summary>
	[Serializable]
	public class DoubleReactiveProperty : ReactiveProperty<double>
	{
		public DoubleReactiveProperty() : base() { }

		public DoubleReactiveProperty(double initialValue) : base(initialValue) { }
		public static implicit operator double(DoubleReactiveProperty property) => property.Value;
	}

	/// <summary>
	/// Inspectable ReactiveProperty.
	/// </summary>
	[Serializable]
	public class StringReactiveProperty : ReactiveProperty<string>
	{
		public StringReactiveProperty() : base() { }

		public StringReactiveProperty(string initialValue) : base(initialValue) { }
		public static implicit operator string(StringReactiveProperty property) => property.Value;
	}

	/// <summary>
	/// Inspectable ReactiveProperty.
	/// </summary>
	[Serializable]
	public class BoolReactiveProperty : ReactiveProperty<bool>
	{
		public BoolReactiveProperty() : base() { }

		public BoolReactiveProperty(bool initialValue) : base(initialValue) { }
		public static implicit operator bool(BoolReactiveProperty property) => property.Value;
	}

	/// <summary>Inspectable ReactiveProperty.</summary>
	[Serializable]
	public class Vector2ReactiveProperty : ReactiveProperty<Vector2>
	{
		public Vector2ReactiveProperty() { }

		public Vector2ReactiveProperty(Vector2 initialValue) : base(initialValue) { }
		public static implicit operator Vector2(Vector2ReactiveProperty property) => property.Value;

		protected override IEqualityComparer<Vector2> EqualityComparer { get { return UnityEqualityComparer.Vector2; } }
	}

	/// <summary>Inspectable ReactiveProperty.</summary>
	[Serializable]
	public class Vector3ReactiveProperty : ReactiveProperty<Vector3>
	{
		public Vector3ReactiveProperty() { }

		public Vector3ReactiveProperty(Vector3 initialValue) : base(initialValue) { }

		protected override IEqualityComparer<Vector3> EqualityComparer => UnityEqualityComparer.Vector3;
		public static implicit operator Vector3(Vector3ReactiveProperty property) => property.Value;
	}

	/// <summary>Inspectable ReactiveProperty.</summary>
	[Serializable]
	public class Vector4ReactiveProperty : ReactiveProperty<Vector4>
	{
		public Vector4ReactiveProperty() { }

		public Vector4ReactiveProperty(Vector4 initialValue) : base(initialValue) { }

		protected override IEqualityComparer<Vector4> EqualityComparer => UnityEqualityComparer.Vector4;
		public static implicit operator Vector4(Vector4ReactiveProperty property) => property.Value;
	}

	/// <summary>Inspectable ReactiveProperty.</summary>
	[Serializable]
	public class ColorReactiveProperty : ReactiveProperty<Color>
	{
		public ColorReactiveProperty() { }

		public ColorReactiveProperty(Color initialValue) : base(initialValue) { }

		protected override IEqualityComparer<Color> EqualityComparer => UnityEqualityComparer.Color;
		public static implicit operator Color(ColorReactiveProperty property) => property.Value;
	}

	/// <summary>Inspectable ReactiveProperty.</summary>
	[Serializable]
	public class RectReactiveProperty : ReactiveProperty<Rect>
	{
		public RectReactiveProperty() { }

		public RectReactiveProperty(Rect initialValue) : base(initialValue) { }

		protected override IEqualityComparer<Rect> EqualityComparer => UnityEqualityComparer.Rect;
		public static implicit operator Rect(RectReactiveProperty property) => property.Value;
	}

	/// <summary>Inspectable ReactiveProperty.</summary>
	[Serializable]
	public class AnimationCurveReactiveProperty : ReactiveProperty<AnimationCurve>
	{
		public AnimationCurveReactiveProperty() { }

		public AnimationCurveReactiveProperty(AnimationCurve initialValue) : base(initialValue) { }
		public static implicit operator AnimationCurve(AnimationCurveReactiveProperty property) => property.Value;
	}

	/// <summary>Inspectable ReactiveProperty.</summary>
	[Serializable]
	public class BoundsReactiveProperty : ReactiveProperty<Bounds>
	{
		public BoundsReactiveProperty() { }

		public BoundsReactiveProperty(Bounds initialValue) : base(initialValue) { }

		protected override IEqualityComparer<Bounds> EqualityComparer => UnityEqualityComparer.Bounds;
		public static implicit operator Bounds(BoundsReactiveProperty property) => property.Value;
	}

	/// <summary>Inspectable ReactiveProperty.</summary>
	[Serializable]
	public class QuaternionReactiveProperty : ReactiveProperty<Quaternion>
	{
		public QuaternionReactiveProperty() { }

		public QuaternionReactiveProperty(Quaternion initialValue) : base(initialValue) { }

		protected override IEqualityComparer<Quaternion> EqualityComparer => UnityEqualityComparer.Quaternion;
		public static implicit operator Quaternion(QuaternionReactiveProperty property) => property.Value;
	}
}