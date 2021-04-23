using System;

namespace csharpcore
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
    }

    public class BackStagePass : Item, IItem
    {
        public void UpdateQuantity()
        {
            SellIn -= 1;

            this.IncreaseQuality();

            if (SellIn < 10)
            {
                this.IncreaseQuality();
            }

            if (SellIn < 5)
            {
                this.IncreaseQuality();
            }

            if (SellIn < 0)
            {
                Quality = 0;
            }
        }
    }

    public class Sulfuras : Item, IItem
    {
        public void UpdateQuantity()
        {
            return;
        }
    }

    public class RegularItem : Item, IItem
    {
        public void UpdateQuantity()
        {
            this.DecreaseQuality();
            
            SellIn -= 1;

            if (SellIn < 0) this.DecreaseQuality();
        }
    }
    
    public class AgedBrie : Item, IItem
    {
        public void UpdateQuantity()
        {
            SellIn -= 1;

            this.IncreaseQuality();

            if (SellIn >= 0) return;

            this.IncreaseQuality();
        }
    }

    public interface IItem
    {
        void UpdateQuantity();
    }

    public static class ItemExtentions
    {
        public static bool IsAgedBrie(this Item item)
        {
            return item.Name.Equals("Aged Brie", StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsSulfuras(this Item item)
        {
            return item.Name.Equals("Sulfuras, Hand of Ragnaros", StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool IsBackStagePass(this Item item)
        {
            return item.Name.Equals("Backstage passes to a TAFKAL80ETC concert",
                StringComparison.CurrentCultureIgnoreCase);
        }

        public static void IncreaseQuality(this Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;
            }
        }

        public static void DecreaseQuality(this Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }
        }
    }
}