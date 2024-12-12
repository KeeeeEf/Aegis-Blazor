using Microsoft.AspNetCore.Components;

namespace Aegis.Web.Components.Pages;

public partial class Home
{
    [CascadingParameter] protected bool IsDarkMode { get; set; }
    protected int NewIdx = 0;
    protected int Count = 0;
    protected bool IsCooldown = false;
    protected bool IsTransitioning = false;

    public async Task CarouselTransition(int OldIDX, int NewIdx) {
        
        if (IsCooldown) return;
        Count = (OldIDX - NewIdx + 5) % 5;

        this.NewIdx = OldIDX; 
        
        // Append Carousel based on count
        if (Count != 0) 
        {
            var cardsToAppend = Carousel.Cards.Take(Count).ToList();
            Carousel.Cards.AddRange(cardsToAppend);
        }

        IsTransitioning = true;
        IsCooldown = true;

        // After 3 seconds, delete the pushed cards
        await Task.Delay(300);
        
        Carousel.Cards = Carousel.Cards.Skip(Count).ToList();
        IsTransitioning = false;
        IsCooldown = false;

        StateHasChanged();
    }

    public class CarouselCardDetails
    {
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }

    public class CarouselItems
    {
        public List<CarouselCardDetails> Cards { get; set; } = new List<CarouselCardDetails>();

        public CarouselItems()
        {
            Cards = new List<CarouselCardDetails>
            {
                new CarouselCardDetails { Image = "", Name = "Stake Your ADA and Receive sADA", Description = "When you stake your ADA through AEGIS, you'll receive SADA (shielded ADA) tokens in return." },
                new CarouselCardDetails { Image = "/images/icons/sada-circle.png", Name = "Unlock Liquidity with SADA", Description = "Unlike traditional staking, AEGIS allows you to unlock liquidity with your SADA tokens. Even while your original ADA remains staked and earning rewards, you can use sADA to trade, provide liquidity, or participate in Dex without sacrificing your staking rewards." },
                new CarouselCardDetails { Image = "/images/icons/sada-circle.png", Name = "Unlock Liquidity with SADA", Description = "Unlike traditional staking, AEGIS allows you to unlock liquidity with your SADA tokens. Even while your original ADA remains staked and earning rewards, you can use sADA to trade, provide liquidity, or participate in Dex without sacrificing your staking rewards." },
                new CarouselCardDetails { Image = "/images/icons/sada-circle.png", Name = "Unlock Liquidity with SADA", Description = "Unlike traditional staking, AEGIS allows you to unlock liquidity with your SADA tokens. Even while your original ADA remains staked and earning rewards, you can use sADA to trade, provide liquidity, or participate in Dex without sacrificing your staking rewards." },
                new CarouselCardDetails { Image = "/images/icons/sada-circle.png", Name = "Unlock Liquidity with SADA", Description = "Unlike traditional staking, AEGIS allows you to unlock liquidity with your SADA tokens. Even while your original ADA remains staked and earning rewards, you can use sADA to trade, provide liquidity, or participate in Dex without sacrificing your staking rewards." }
            };
        }
    }

    public CarouselItems Carousel = new CarouselItems();
    protected List<bool>? PanelStates { get; set; }

    protected List<(string Title, string Content)>? PanelContents { get; set; }

    //Reminder: Create Separate Directory for types
    public class TokenomicData
    {
        public string Percentage { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Amount { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }

    public class Quarter
    {
        public string Year { get; set; } = string.Empty;
        public string QuarterName { get; set; } = string.Empty;
    }

    public List<TokenomicData> TokenomicList = new List<TokenomicData>
    {
        new TokenomicData { 
            Percentage = "10%", 
            Name = "Team", 
            Description = "Lorem ipsum dolor sit amet.", 
            Amount = "10,000,000",
            Color = "#0F3CAE"
        },
        new TokenomicData { 
            Percentage = "10%", 
            Name = "Team", 
            Description = "Lorem ipsum dolor sit amet.", 
            Amount = "10,000,000",
            Color = "#517FF3"
        },
        new TokenomicData { 
            Percentage = "10%", 
            Name = "Team", 
            Description = "Lorem ipsum dolor sit amet.", 
            Amount = "10,000,000",
            Color = "#A5D0E8"
        },
        new TokenomicData { 
            Percentage = "10%", 
            Name = "Team", 
            Description = "Lorem ipsum dolor sit amet.", 
            Amount = "10,000,000",
            Color = "#E9DC94"
        },
        new TokenomicData { 
            Percentage = "10%", 
            Name = "Team", 
            Description = "Lorem ipsum dolor sit amet.", 
            Amount = "10,000,000",
            Color = "#9747FF"
        },
    };

    protected string? HoveredQuarter { get; set; } = "2024 | Q1";

    protected List<Quarter> Quarters { get; set; } = new List<Quarter>
    {
        new Quarter { Year = "2024", QuarterName = "Q1" },
        new Quarter { Year = "2024", QuarterName = "Q2" },
        new Quarter { Year = "2024", QuarterName = "Q3" },
        new Quarter { Year = "2024", QuarterName = "Q4" },
        new Quarter { Year = "2025", QuarterName = "Q1" },
        new Quarter { Year = "2025", QuarterName = "Q2" }
    };

    protected string GetHoverClass(Quarter quarter)
    {
        string displayText = $"{quarter.Year} | {quarter.QuarterName}";
        return HoveredQuarter == displayText ? "text-2xl font-semibold" : "text-lg";
    }

    protected override void OnInitialized()
    {
        PanelStates = new List<bool> { false, false, false };

        PanelContents = new List<(string Title, string Content)>
        {
            ("What is Sada?", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque iaculis fringilla ligula, id finibus tortor."),
            ("How does automated staking work?", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque iaculis fringilla ligula, id finibus tortor."),
            ("How does AEGIS improve the Cardano network?", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque iaculis fringilla ligula, id finibus tortor.")
        };
    }
}
