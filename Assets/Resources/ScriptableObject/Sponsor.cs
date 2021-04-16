using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[CreateAssetMenu]
public class Sponsor : ScriptableObject
{
    public Sprite SponsorImage;
    public FloatReference MarketabilityCost;
    public FloatReference EndContractGold;
    public FloatReference EachTurnGold;
    public FloatReference StartDuration;
    public FloatValue Duration;
    public float durationFLoat;

    //public FloatValue ShortDuration, MediumDuration, LongDuration;
    //public FloatValue ShortMarketability, MediumMarketability, LongMarketability;

    public EventObj EndContract;

   
    public void ChangeDuration()
    {
        Duration.ApplyChange(-1);
        durationFLoat--;
        CheckDuration();
    }

    void CheckDuration()
    {
        if (Duration.Value <= 0)
        {
            ResetDuration();
            EndContract.Raise();
        }
    }

    public void ResetDuration()
    {
        Duration.Value = StartDuration.Value;
    }

    public void AddImage(Sprite image)
    {
        SponsorImage = image;
        ResetDuration();
    }
    /// <summary>
    /// 0 = short, 1=medium 2=long
    /// </summary>
    /// <param name="durationContract"></param>
    //public void SetStatsBasedOnDuration(int durationContract)
    //{
    //    if (durationContract == 2)
    //    {
    //        StartDuration.Value = LongDuration.Value;
    //        MarketabilityCost.Value = LongMarketability.Value;
    //    }
    //    else if(durationContract == 1)
    //    {
    //        StartDuration.Value = MediumDuration.Value;
    //        MarketabilityCost.Value = MediumMarketability.Value;
    //    }
    //    else if(durationContract == 0)
    //    {
    //        StartDuration.Value = ShortDuration.Value;
    //        MarketabilityCost.Value = ShortMarketability.Value;
    //    }
    //}
}
