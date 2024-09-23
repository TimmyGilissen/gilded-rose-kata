using System.Collections.Generic;
using GildedRoseKata;
using GildedRoseKata.Processors;
using Xunit;

namespace GildedRoseTests;

public class BackstagePassShould
{
    [Fact]
    public void IncreaseQualityByTwoWhenItIsABackstagePassAndTheSellinIsTenDaysOrLess()
    {
        var backstagePass = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 10 };
       
        BackStageProcessor.Process(backstagePass);
        
        Assert.Equal(12, backstagePass.Quality);
        Assert.Equal(9, backstagePass.SellIn);
    }

    [Fact]
    public void IncreaseQualityByThreeWhenItIsABackstagePassAndTheSellinIsFiveDaysOrLess()
    {
        var backstagePass = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 10 }; 
        
        BackStageProcessor.Process(backstagePass);

        
        Assert.Equal(13, backstagePass.Quality);
        Assert.Equal(4, backstagePass.SellIn);
    }

    [Fact]
    public void NeverHaveAQualityAbove50()
    {
        var backstagePass = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 49 }; 
        
        BackStageProcessor.Process(backstagePass);

        
        Assert.Equal(50, backstagePass.Quality);
        Assert.Equal(4, backstagePass.SellIn);
    }

    [Fact]
    public void SetQualityToZeroWhenTheSellinIsZero()
    {
        var backstagePass = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 10 };
        BackStageProcessor.Process(backstagePass);

        
        Assert.Equal(0, backstagePass.Quality);
        Assert.Equal(-1, backstagePass.SellIn);
    }
}