using GildedRoseKata.Extentions;

namespace GildedRoseKata.Processors;

public static class BackStageProcessor
{
    public static void Process(Item item)
    {
        item.DecreaseSellIn();
        switch (item.SellIn)
        {
            case < 0:
                item.DropQualityToZero();
                break;
            case < 5:
                item.IncreaseQualityByThree();
                break;
            case < 10:
                item.IncreaseQualityByTwo();
                break;
            default:
                item.IncreaseQuality();
                break;
        }
    }
}