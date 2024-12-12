using Aegis.Web.Models;
using Microsoft.AspNetCore.Components;

namespace Aegis.Web.Components.Pages;

public partial class Home
{
    [CascadingParameter] 
    protected bool IsDarkMode { get; set; }
    protected List<bool>? PanelStates { get; set; }
    protected List<Faq>? PanelContents { get; set; }
    protected string? HoveredQuarter { get; set; } = "2024 | Q1";
    protected int NewIdx = 0;
    protected int Count = 0;
    protected bool IsCooldown = false;
    protected bool IsTransitioning = false;

    protected List<Carousel> CarouselCards = new List<Carousel>
    {
        new Carousel (
            Image: "",
            Name: "Stake Your ADA and Receive sADA",
            Description: "When you stake your ADA through AEGIS, you'll receive SADA (shielded ADA) tokens in return."
        ),
        new Carousel (
            Image: "/images/icons/sada-circle.png",
            Name: "Unlock Liquidity with SADA",
            Description: "Unlike traditional staking, AEGIS allows you to unlock liquidity with your SADA tokens. Even while your original ADA remains staked and earning rewards, you can use sADA to trade, provide liquidity, or participate in Dex without sacrificing your staking rewards."
        ),
        new Carousel (
            Image: "/images/icons/sada-circle.png",
            Name: "Unlock Liquidity with SADA",
            Description: "Unlike traditional staking, AEGIS allows you to unlock liquidity with your SADA tokens. Even while your original ADA remains staked and earning rewards, you can use sADA to trade, provide liquidity, or participate in Dex without sacrificing your staking rewards."
        ),
        new Carousel (
            Image: "/images/icons/sada-circle.png",
            Name: "Unlock Liquidity with SADA",
            Description: "Unlike traditional staking, AEGIS allows you to unlock liquidity with your SADA tokens. Even while your original ADA remains staked and earning rewards, you can use sADA to trade, provide liquidity, or participate in Dex without sacrificing your staking rewards."
        ),
        new Carousel (
            Image: "/images/icons/sada-circle.png",
            Name: "Unlock Liquidity with SADA",
            Description: "Unlike traditional staking, AEGIS allows you to unlock liquidity with your SADA tokens. Even while your original ADA remains staked and earning rewards, you can use sADA to trade, provide liquidity, or participate in Dex without sacrificing your staking rewards."
        ),
    };
    protected List<Tokenomics> TokenomicList = new List<Tokenomics>
    {
        new Tokenomics (
            Percentage: "10%",
            Name: "Team",
            Description: "Lorem ipsum dolor sit amet.",
            Amount: "10,000,000",
            Color: "#0F3CAE"
        ),
        new Tokenomics (
            Percentage: "10%",
            Name: "Team",
            Description: "Lorem ipsum dolor sit amet.",
            Amount: "10,000,000",
            Color: "#517FF3"
        ),
        new Tokenomics (
            Percentage: "10%",
            Name: "Team",
            Description: "Lorem ipsum dolor sit amet.",
            Amount: "10,000,000",
            Color: "#A5D0E8"
        ),
        new Tokenomics (
            Percentage: "10%",
            Name: "Team",
            Description: "Lorem ipsum dolor sit amet.",
            Amount: "10,000,000",
            Color: "#E9DC94"
        ),
        new Tokenomics (
            Percentage: "10%",
            Name: "Team",
            Description: "Lorem ipsum dolor sit amet.",
            Amount: "10,000,000",
            Color: "#9747FF"
        ),
    };
    protected List<Timeline> Quarters { get; set; } = new List<Timeline>
    {
        new Timeline ( Year: "2024", Quarter: "Q1" ),
        new Timeline ( Year: "2024", Quarter: "Q2" ),
        new Timeline ( Year: "2024", Quarter: "Q3" ),
        new Timeline ( Year: "2024", Quarter: "Q4" ),
        new Timeline ( Year: "2025", Quarter: "Q1" ),
        new Timeline ( Year: "2025", Quarter: "Q2" ),
    };

    protected override void OnInitialized()
    {
        PanelStates = new List<bool> { false, false, false };

        PanelContents = new List<Faq>
        {
            new Faq(
                Question: "What is Sada?", 
                Answer: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque iaculis fringilla ligula, id finibus tortor. Ut in neque a lectus venenatis molestie. Suspendisse ullamcorper sapien turpis, ac dapibus mi maximus nec."
            ),
            new Faq(
                Question: "How does automated staking work?", 
                Answer: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque iaculis fringilla ligula, id finibus tortor. Ut in neque a lectus venenatis molestie. Suspendisse ullamcorper sapien turpis, ac dapibus mi maximus nec."
            ),
            new Faq(
                Question: "How does AEGIS improve the Cardano network?", 
                Answer: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque iaculis fringilla ligula, id finibus tortor. Ut in neque a lectus venenatis molestie. Suspendisse ullamcorper sapien turpis, ac dapibus mi maximus nec.")
        };
    }

    protected string GetHoverClass(Timeline quarter)
    {
        string displayText = $"{quarter.Year} | {quarter.Quarter}";
        return HoveredQuarter == displayText ? "text-2xl font-semibold" : "text-lg";
    }

        protected async Task CarouselTransition(int OldIDX, int NewIdx)
    {

        if (IsCooldown) return;
        Count = (OldIDX - NewIdx + 5) % 5;

        this.NewIdx = OldIDX;

        if (Count != 0)
        {
            List<Carousel> cardsToAppend = CarouselCards.Take(Count).ToList();
            CarouselCards.AddRange(cardsToAppend);
        }

        IsTransitioning = true;
        IsCooldown = true;

        await Task.Delay(300);

        CarouselCards = CarouselCards.Skip(Count).ToList();
        IsTransitioning = false;
        IsCooldown = false;

        StateHasChanged();
    }
}