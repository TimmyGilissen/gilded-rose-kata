using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Processors;
using Xunit;

namespace GildedRoseTests;

public class AgedBrieShould
{
    [Fact]
    public void IncreaseQualityByOneAndDecreaseSellInByOne()
    {
        var agedBrie = new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
     
        AgedBrieProcessor.Process(agedBrie);
        
        Assert.Equal(1, agedBrie.Quality);
        Assert.Equal(1, agedBrie.SellIn);
    }
    [Fact]
    public void IncreaseQualityByTwoAndDecreaseSellInByOneEvenIfSellInIsNegative()
    {
        var agedBrie = new Item { Name = "Aged Brie", SellIn = -1, Quality = 0 };
        
        AgedBrieProcessor.Process(agedBrie);
        
        Assert.Equal(2, agedBrie.Quality);
        Assert.Equal(-2, agedBrie.SellIn);
    }

    [Fact]
    public void NeverHaveAQualityAbove50()
    {
        var agedBrie = new Item { Name = "Aged Brie", SellIn = 0, Quality = 50 };
        
        AgedBrieProcessor.Process(agedBrie);
        
        Assert.Equal(50, agedBrie.Quality);
        Assert.Equal(-1, agedBrie.SellIn);
    }
}