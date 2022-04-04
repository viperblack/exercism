using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        List<string> languages = new List<string>() {"C#", "Clojure", "Elm"};
        return languages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Exists(x => x == language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse(0, languages.Count);
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {

        if ((languages.FindIndex(0, languages.Count, x => x == "C#") > -1) && (languages.Count <= 3)){
            return true;
        }else{
            return false ;
        }
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        /**<summary> 
        1. Create an empty list using NewList() implemented above; 
        2. Verify if a language had exist on New List() using HasLanguage() implemented above;
        3. If not exists add a new language on NewList if exists do nothing;
        4. if original size list greater than NewList() any language is not unique.
        </summary>
        **/
        var unique = NewList();

        
        foreach(string language in languages){
            if (!HasLanguage(unique, language)){
                AddLanguage(unique,language);
            }
        }

        if ( CountLanguages(languages) == CountLanguages(unique)){
            return true;
        }else{
            return false;
        }
    }
}
