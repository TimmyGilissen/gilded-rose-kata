using System;
using GildedRoseKata.Processors;

namespace GildedRoseKata.Extentions;

public static class ItemExtensions
{
    public static void DecreaseQuality(this Item item)
    {
        if (item.Quality > 0)
        {
            item.Quality -= 1;
        }
    }

    public static void DecreaseQualityTwice(this Item item)
    {
        item.DecreaseQuality();
        item.DecreaseQuality();
    }
    
    public static void IncreaseQuality(this Item item)
    {
        if (item.CanIncreaseQuality())
        {
            item.Quality += 1;
        }
    }

    public static void IncreaseQualityByTwo(this Item item)
    {
        item.IncreaseQuality();
        item.IncreaseQuality();
    }
    public static void IncreaseQualityByThree(this Item item)
    {
        item.IncreaseQuality();
        item.IncreaseQuality();
        item.IncreaseQuality();
    }
    
    private static bool CanIncreaseQuality(this Item item)
    {
        return item.Quality < 50;
    }
    
    public static void DecreaseSellIn(this Item item)
    {
        item.SellIn -= 1;
    }

    public static void DropQualityToZero(this Item item)
    {
        item.Quality = 0;
    }
    
    public static bool IsSulfuras(this Item item)
    {
        return item.Name.Equals("Sulfuras, Hand of Ragnaros", StringComparison.CurrentCultureIgnoreCase);
    }

    public static bool IsAgedBrie(this Item item)
    {
        return item.Name.Equals("Aged Brie", StringComparison.CurrentCultureIgnoreCase);
    }

    public static bool IsBackstagePasses(this Item item)
    {
        return item.Name.Equals("Backstage passes to a TAFKAL80ETC concert", StringComparison.CurrentCultureIgnoreCase);
    }
    
    public static bool IsConjuredItem(this Item item)
    {
        return item.Name.Contains("Conjured", StringComparison.CurrentCultureIgnoreCase);
    }
}