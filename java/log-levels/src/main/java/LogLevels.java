public class LogLevels {
    
    /**
     * @param logLine
     * @return
     */
    public static String message(String logLine) {
        return logLine.substring(logLine.indexOf(":") + 1).trim();
    }

    /**
     * @param logLine
     * @return
     */
    public static String logLevel(String logLine) {
        return logLine.substring(1, logLine.indexOf("]")).trim().toLowerCase();
    }

    /**
     * @param logLine
     * @return
     */
    public static String reformat(String logLine) {
        return message(logLine) + " " + "(" + logLevel(logLine) + ")";
     }
}
