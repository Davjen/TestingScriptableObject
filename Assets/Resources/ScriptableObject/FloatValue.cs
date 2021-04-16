using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class FloatValue : ScriptableObject
{
    public float Value;

    public void SetValue(float value) => Value = value;
    public void SetValue(FloatValue value) => Value = value.Value;

    public void ApplyChange(float value) => Value += value;
    public void ApplyChange(FloatValue value) => Value += value.Value;
   
}
