using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DotnetCrawler.Data.Attributes;
using DotnetCrawler.Data.Repository;

namespace DotnetCrawler.Data.Models
{
    [DotnetCrawlerEntity(XPath = "//*[@id='LeftSummaryPanel']/div[1]")]
    public partial class Catalog: IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [DotnetCrawlerField(Expression = "1", SelectorType = SelectorType.FixedValue)]
        public int CatalogBrandId { get; set; }
    
        [DotnetCrawlerField(Expression = "1", SelectorType = SelectorType.FixedValue)]
        public int CatalogTypeId { get; set; }        
        
        public string Description { get; set; }
        
        [DotnetCrawlerField(Expression = "//*[@id='itemTitle']/text()", SelectorType = SelectorType.XPath)]
        public string Name { get; set; }
    
        public string PictureUri { get; set; }        
        public decimal Price { get; set; }

        public virtual CatalogBrand CatalogBrand { get; set; }
        public virtual CatalogType CatalogType { get; set; }
    }
}
