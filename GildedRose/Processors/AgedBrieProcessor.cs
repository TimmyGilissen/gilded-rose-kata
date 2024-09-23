using GildedRoseKata.Extentions;

namespace GildedRoseKata.Processors;

public static class AgedBrieProcessor
{

    public static void Process(Item item)
    {
        item.DecreaseSellIn();
        switch (item.SellIn)
        {
            case < 0:
                item.IncreaseQualityByTwo();
                break;
            default:
                item.IncreaseQuality();
                break;
        }
    }
    
}