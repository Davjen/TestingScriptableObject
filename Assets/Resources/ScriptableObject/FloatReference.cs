using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FloatReference
{
    public bool Costante = true;
    public float ConstantValue;
    public FloatValue Variable;

    public FloatReference()
    { }

    public FloatReference(float value)
    {
        Costante = true;
        ConstantValue = value;
    }

    public float Value
    {
        get { return Costante ? ConstantValue : Variable.Value; }
    }

    public static implicit operator float(FloatReference reference)
    {
        return reference.Value;
    }
}
