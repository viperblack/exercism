using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
            return "goalie";
            case 2:
            return "left back";
            case 3:
            case 4:
            return "center back";
            case 6:
            case 7:
            case 8:
            return "midfielder";
            case 9:
            return "left wing";
            case 10: 
            return "striker";
            case 11:
            return "right wing";
            default:
            throw new ArgumentOutOfRangeException("number outside the range 1-11 is processed");
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch(report)
        {
            case int:
                return $"There are {report} supporters at the match.";
            case string:
                return report.ToString();
             case Injury injury:
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
            case Foul foul: 
                return "The referee deemed a foul.";
            case Incident incident:
                return "An incident happened.";
            case Manager manager when manager.Club != null:
                return $"{manager.Name} ({manager.Club})";
            case Manager manager when manager.Club == null:
                return $"{manager.Name}";

            default:
                throw new ArgumentException();
        }
    }
}
