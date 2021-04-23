using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        
        [Theory]
        [InlineData("foo",0,10)]
        [InlineData("Aged Brie",0,0)]
        [InlineData("Elixir of the Mongoose",0,0)]
        [InlineData("Sulfuras, Hand of Ragnaros",0,0)]
        [InlineData("Backstage passes to a TAFKAL80ETC concert",0,0)]
        public void Quality_can_never_decrease_below_0(string name, int sellIn, int quality)
        {
            var item = new Item { Name = name, SellIn = sellIn, Quality = quality } ;
            // GildedRose.UpdateQuality(item);
            Assert.True(item.Quality >= 0);
        }
        
        [Theory]
        [InlineData("foo", 5, 10, 9)]
        [InlineData("foo", 5, 9, 8)]
        [InlineData("foo", 0, 10, 8)]
        public void Quality_should_decrease(string name, int sellIn, int quality, int expectedQuality)
        {
            var item = new Item { Name = name, SellIn = sellIn, Quality = quality } ;
            // GildedRose.UpdateQuality(item);
            Assert.Equal(expectedQuality, item.Quality);
        }

        [Theory]
        [InlineData(5, 10, 11)]
        [InlineData(4, 11, 12)]
        [InlineData(3, 12, 13)]
        public void Quality_of_agedbrie_increases_the_older_it_gets(int sellIn, int quality, int expectedQuality)
        {
            var item = new Item { Name = "Aged Brie", SellIn = sellIn, Quality = quality } ;
            // GildedRose.UpdateQuality(item);
            Assert.Equal(expectedQuality, item.Quality);
        }
    }
}