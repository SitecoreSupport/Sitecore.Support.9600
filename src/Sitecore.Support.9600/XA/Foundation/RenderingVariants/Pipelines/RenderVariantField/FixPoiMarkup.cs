namespace Sitecore.Support.XA.Foundation.RenderingVariants.Pipelines.RenderVariantField
{
    using Sitecore.XA.Feature.Maps;
    using Sitecore.XA.Foundation.Variants.Abstractions.Models;
    using Sitecore.XA.Foundation.Variants.Abstractions.Pipelines.RenderVariantField;

    public class FixPoiMarkup
    {
        public void Process(RenderVariantFieldArgs args)
        {
            if (args.Item.Parent.TemplateID == Templates.PoiGroup.ID || args.Item.Parent.TemplateID == Templates.PoiGroupingItem.ID) // change RendererMode to Html if the item is a POI
            {
                args.RendererMode = RendererMode.Html;
            }
        }
    }
}