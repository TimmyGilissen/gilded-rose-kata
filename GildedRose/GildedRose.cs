using System;
using System.Collections.Generic;
using GildedRoseKata.Extentions;
using GildedRoseKata.Processors;

namespace GildedRoseKata;

public class GildedRose(IList<Item> items)
{
    public void UpdateQuality()
    {
        foreach (var item in items)
        {
            if (item.IsSulfuras())
            {
                continue;
            }
            if (item.IsAgedBrie())
            {
                AgedBrieProcessor.Process(item);
            }
            else if (item.IsBackstagePasses())
            {
                BackStageProcessor.Process(item);
            }else if (item.IsConjuredItem())
            {
                ConjuredItemProcessor.Process(item);
            }
            else
            {
                ItemProcessor.Process(item);
            }
        }
    }
}