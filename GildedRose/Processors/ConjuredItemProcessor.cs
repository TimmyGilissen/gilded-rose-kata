using GildedRoseKata.Extentions;

namespace GildedRoseKata.Processors;

public static class ConjuredItemProcessor
{
    public static void Process(Item item)
    {
        item.DecreaseSellIn();
        switch (item.SellIn)
        {
            case < 0:
                item.DecreaseQualityTwice();
                break;
        }

        item.DecreaseQualityTwice();
    }
}