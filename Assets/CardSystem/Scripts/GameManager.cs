using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<CardDisplay> deck = new List<CardDisplay>();
    public List<CardDisplay> discardPile = new List<CardDisplay>();
    public Transform[] cardSlots;
    public bool[] availableCardSlots;

    public TMP_Text deckSizeText;
    public TMP_Text discardPileSizeText;

    public void DrawCard()
    {
        if (deck.Count >= 1)
        {
            CardDisplay randCard = deck[Random.Range(0, deck.Count)];

            for (int i = 0; i < availableCardSlots.Length; i++)
            {
                if (availableCardSlots[i] == true)
                {
                    randCard.gameObject.SetActive(true);
                    randCard.handIndex = i;

                    randCard.transform.position = cardSlots[i].position;
                    randCard.hasBeenPlayed = false;

                    availableCardSlots[i] = false;
                    deck.Remove(randCard);
                    return;
                }
            }
        }
    }

    private void Update()
    {
        deckSizeText.text = deck.Count.ToString();
        discardPileSizeText.text = discardPile.Count.ToString();

        if (deck.Count == 0)
        {
            if (discardPile.Count > 1)
            {
                foreach (CardDisplay card in discardPile)
                {
                    deck.Add(card);
                }
                discardPile.Clear();
            }
        }
    }
}
