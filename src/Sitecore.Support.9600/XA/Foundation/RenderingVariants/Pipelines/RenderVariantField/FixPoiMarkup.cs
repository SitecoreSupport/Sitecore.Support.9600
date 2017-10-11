namespace Sitecore.Support.XA.Foundation.RenderingVariants.Pipelines.RenderVariantField
{
    using Sitecore.XA.Foundation.Geospatial;
    using Sitecore.XA.Foundation.SitecoreExtensions.Extensions;
    using Sitecore.XA.Foundation.Variants.Abstractions.Models;
    using Sitecore.XA.Foundation.Variants.Abstractions.Pipelines.RenderVariantField;

    public class FixPoiMarkup
    {
        public void Process(RenderVariantFieldArgs args)
        {
            if (args.Item.DoesItemInheritFrom(Templates.IPoi.ID)) // change RendererMode to Html if the item is a POI
            {
                args.RendererMode = RendererMode.Html;
            }
        }
    }
}