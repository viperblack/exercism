import java.util.ArrayList;
import java.util.List;

public class LanguageList {
    private final List<String> languages = new ArrayList<>();

    /**
     * @return is empty?
     */
    public boolean isEmpty() {
        return languages.isEmpty() ? true : false;
    }

    /**
     * @param language
     */
    public void addLanguage(String language) {
        languages.add(language);
    }

    /**
     * @param language
     */
    public void removeLanguage(String language) {
        languages.remove(language);
    }

    /**
     * @return
     */
    public String firstLanguage() {
        return languages.get(0);
    }

    /**
     * @return
     */
    public int count() {
        return languages.size();
    }

    /**
     * @param language
     * @return
     */
    public boolean containsLanguage(String language) {
        return languages.contains(language) ? true : false;
    }

    /**
     * @return
     */
    public boolean isExciting() {
        return languages.contains("Java") || languages.contains("Kotlin") ? true : false;
    }
}
