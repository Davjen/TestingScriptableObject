using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Player/Stats")]
public class PlayerSTats : ScriptableObject
{
    public int strenght, constitution, endurance;


    public void IncreaseStats()
    {
        strenght++;
    }
}
