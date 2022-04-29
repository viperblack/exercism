using System;
using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        string[] greek_alphabet = { "α", "β", "γ", "δ", "ε", "ζ", "η", "θ", "ι", "κ", "λ", "μ", "ν", "ξ", "ο", "π", "ρ", "σ", "ς", "τ", "υ", "φ", "χ", "ψ", "ω" };
        string[] omit = {"0","1", "2", "3", "4", "5", "6", "7", "8", "9", "😀"};
        
        StringBuilder myStringBuilder = new StringBuilder(identifier);

        myStringBuilder.Replace(" ", "_");
        myStringBuilder.Replace("\0","CTRL");
        myStringBuilder.Replace("-ḃ", "Ḃ");
        myStringBuilder.Replace("-a", "A");

        foreach (string item in omit)
        {
          myStringBuilder.Replace(item, "");   
        }
    
        foreach (string letter in greek_alphabet)
        {
          myStringBuilder.Replace(letter, "");  
        }

        return myStringBuilder.ToString();
    }
}
