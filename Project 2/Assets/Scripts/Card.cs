using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    // Name of the card
    public string cardName;

    // The card's value
    public int cardValue;

    // The picture on the card
    public RawImage cardPic;

    // Has the card been used?
    public bool used;

}
