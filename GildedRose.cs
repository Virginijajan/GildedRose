using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                if(item.Name != "Sulfuras, Hand of Ragnaros")
                {
                    if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert" && item.Quality > 0)
                    {
                        item.Quality--;

                        if (item.Name == "Conjured Mana Cake" && item.Quality > 0)
                        {
                            item.Quality--;
                        }
                    }                    
                    else if (item.Quality < 50)
                    {
                        item.Quality++;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11 && item.Quality < 50)
                            {
                                item.Quality++;
                            }
                            if (item.SellIn < 6 && item.Quality < 50)
                            {
                                item.Quality++;
                            }
                        }
                    }

                    if (--item.SellIn < 0)
                    {
                        if (item.Name == "Aged Brie" && item.Quality++ < 50)
                        {                           
                        }
                        else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")                                                 
                        {
                            item.Quality = 0;                                                              
                        }
                        else if (item.Quality > 0)
                        {
                            item.Quality--;
                        }                                                                       
                    }
                }               
            }
        }
    }
}

