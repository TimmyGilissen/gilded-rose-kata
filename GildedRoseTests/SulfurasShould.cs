using System.Collections.Generic;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests;

public class SulfurasShould
{
    [Fact]
    public void NeverChangeQuality()
    {
        var sulfuras = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
        List<Item> items = [sulfuras];

        var sut = new GildedRose(items);
        
        sut.UpdateQuality();
        
        Assert.Equal(80, sulfuras.Quality);
    }

    [Fact]
    public void NeverChangeSellIn()
    {
        var sulfuras = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
        List<Item> items = [sulfuras];

        var sut = new GildedRose(items);
        
        sut.UpdateQuality();
        
        Assert.Equal(0, sulfuras.SellIn);
    }
}