using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewWithActionButtons.ViewModels {
    public static class DataGenerator {
        public static ObservableCollection<Card> CreateCards() {
            ObservableCollection<Card> cards = new ObservableCollection<Card>();
            cards.Add(new Card("Security") {
                Items = new ObservableCollection<CardItem>() {
                    new CardItem(){ Name = "Change the password", Icon = ImageSource.FromFile("attention"), Subtitle = "Change the default password to protect your server", CreatedDate = DateTime.Now.AddDays(-1)},
                    new CardItem(){ Name = "FTPS should be required", Icon = ImageSource.FromFile("attention"), Subtitle = "Enable FTPS enforcement for enhanced security", CreatedDate = DateTime.Now.AddDays(-2) },
                    new CardItem(){ Name = "Use the HTTPS protocol", Icon = ImageSource.FromFile("info"), Subtitle = "API App should only be accessible over HTTPS", CreatedDate = DateTime.Now.AddDays(-3) },
                    new CardItem(){ Name = "Enable diagnostic logs", Icon = ImageSource.FromFile("info"), Subtitle = "This enables you to recreate activity trails for investigation purposes if a security incident occurs or your network is compromised", CreatedDate = DateTime.Now.AddDays(-4) },
                    new CardItem(){ Name = "Enable auditing on SQL server", Icon = ImageSource.FromFile("question"), Subtitle = "Track database activities across all databases", CreatedDate = DateTime.Now.AddDays(-5) },
                    new CardItem(){ Name = "Disable remote debugging", Icon = ImageSource.FromFile("question"), Subtitle = "Remote debugging requires inbound ports to be opened on", CreatedDate = DateTime.Now.AddDays(-6) },
                },
                PreviewItemsCount = 4,                
                AllowCommonActions = true,
                PrimaryActionName = "Dismiss All",
                SecondaryActionName = "Apply All"
            });
            cards.Add(new Card("Performance") {  
                Items = new ObservableCollection<CardItem>() {
                    new CardItem(){ Name = "Create indexes", Icon = ImageSource.FromFile("info"), Subtitle = "Create an index for the Orders table", CreatedDate = DateTime.Now.AddDays(-1)},
                    new CardItem(){ Name = "Parameterize queries", Icon = ImageSource.FromFile("info"), Subtitle = "Optimize queries with a similar execution plan", CreatedDate = DateTime.Now.AddDays(-2) },
                    new CardItem(){ Name = "Improve connection latency", Icon = ImageSource.FromFile("question"), Subtitle = "Connection redirection may improve your application latency", CreatedDate = DateTime.Now.AddDays(-3) },
                    new CardItem(){ Name = "Enable Query Analyzer", Icon = ImageSource.FromFile("question"), Subtitle = "Query Analyzer helps you to identify long queries at runtime", CreatedDate = DateTime.Now.AddDays(-4) },
                },
                PreviewItemsCount = 3,

            });
            cards.Add(new Card("Availability") {
                Items = new ObservableCollection<CardItem>() {
                    new CardItem(){ Name = "Enable virtual backups", Icon = ImageSource.FromFile("attention"), Subtitle = "Improve fault tolerance", CreatedDate = DateTime.Now.AddDays(-1) },
                    new CardItem(){ Name = "Add more virtual machines", Icon = ImageSource.FromFile("info"), Subtitle = "Improve data resilience & performance", CreatedDate = DateTime.Now.AddDays(-2) },
                    new CardItem(){ Name = "Use availability sets", Icon = ImageSource.FromFile("question"), Subtitle = "Ensure business cuntinuity with VM resilience", CreatedDate = DateTime.Now.AddDays(-3) }
                },
                PreviewItemsCount = 3
            });
            foreach (Card item in cards)
                PopulateTopItems(item);
            return cards;
        }
        static void PopulateTopItems(Card card) {
            for (int i = 0; i < card.PreviewItemsCount; i++) {
                card.TopItems.Add(card.Items[i]);
            }
        }
    }
}
