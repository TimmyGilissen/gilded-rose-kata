using System;
using GildedRoseKata.Extentions;

namespace GildedRoseKata.Processors;

public static class ItemProcessor
{
    public static void Process(Item item)
    {
        item.DecreaseSellIn();
        switch (item.SellIn)
        {
            case < 0:
                item.DecreaseQuality();
                break;
        }

        item.DecreaseQuality();
    }
}