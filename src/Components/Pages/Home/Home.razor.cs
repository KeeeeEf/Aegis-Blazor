namespace Aegis.Web.Components.Pages;

public partial class Home
{
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
