using GildedRoseKata;
using GildedRoseKata.Processors;
using Xunit;

namespace GildedRoseTests;

public class ConjuredItemShould
{
    [Fact]
    public void DecreaseQualityTwice()
    {
        var item = new Item { Name = "Conjured +5 Dexterity Vest", SellIn = 10, Quality = 20 };
       
        ConjuredItemProcessor.Process(item);
        
        Assert.Equal(18, item.Quality);
        Assert.Equal(9, item.SellIn);
    }

    [Fact]
    public void DecreaseQualityByFourIfSellInIsLessThanZero()
    {
        var item = new Item { Name = "Conjured +5 Dexterity Vest", SellIn = 0, Quality = 20 };
       
        ConjuredItemProcessor.Process(item);
        
        Assert.Equal(16, item.Quality);
        Assert.Equal(-1, item.SellIn);
    }
    
    [Fact]
    public void NeverDecreaseQualityBelowZero()
    {
        var item = new Item { Name = "Conjured +5 Dexterity Vest", SellIn = 0, Quality = 0 };
        
        ConjuredItemProcessor.Process(item);

        Assert.Equal(0, item.Quality);
        Assert.Equal(-1, item.SellIn);
    }
}

public class ItemShould
{
    [Fact]
    public void DecreaseSellInByOneAndQualityByOne()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
       
        ItemProcessor.Process(item);
        
        Assert.Equal(19, item.Quality);
        Assert.Equal(9, item.SellIn);
    }

    [Fact]
    public void DecreaseQualityTwiceIfSellingLessThanZero()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 20 };

        ItemProcessor.Process(item);

        Assert.Equal(18, item.Quality);
        Assert.Equal(-1, item.SellIn);
    }

    [Fact]
    public void NeverDecreaseQualityBelowZero()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 0 };
        
        ItemProcessor.Process(item);

        Assert.Equal(0, item.Quality);
        Assert.Equal(-1, item.SellIn);
    }
}