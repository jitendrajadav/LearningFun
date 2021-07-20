using LearningFun.ContentViews;
using LearningFun.Enums;
using LearningFun.Models;
using Xamarin.Forms;

namespace LearningFun.Templates
{
    public class StoreItemDataTemplate : DataTemplateSelector
    {
        private readonly DataTemplate _sell;
        private readonly DataTemplate _ads;
        private readonly DataTemplate _normal;

        public StoreItemDataTemplate()
        {
            _sell = new DataTemplate(typeof(StoreItemSellContentView));
            _ads = new DataTemplate(typeof(StoreItemAdsContentView));
            _normal = new DataTemplate(typeof(StoreItemNormalContentView));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return item is StoreItem storeItem
                ? storeItem.Type == StoreItemType.Sell
                    ? _sell
                    : storeItem.Type == StoreItemType.Ads ? _ads : storeItem.Type == StoreItemType.Normal ? _normal : null
                : null;
        }
    }
}
