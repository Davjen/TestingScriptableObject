using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SponsorFiller : MonoBehaviour
{
    public Sponsor sponsor;

    public Image sponsorImage;

    public Text Marketability;
    public Text Duration;
    public Text MoneyEachTurn;
    public Text MoneyEndTurn;

    // Start is called before the first frame update
    private void OnEnable()
    {
        Debug.Log("attivo");
        sponsorImage.sprite = sponsor.SponsorImage;
        Marketability.text = sponsor.MarketabilityCost.Value.ToString();
        Duration.text = sponsor.Duration.Value.ToString();
        MoneyEachTurn.text = sponsor.EachTurnGold.Value.ToString();
        MoneyEndTurn.text = sponsor.EndContractGold.Value.ToString();
    }

    public void UpdateGraphic()
    {

        Duration.text = sponsor.Duration.Value.ToString();

    }
    // Update is called once per frame

}
