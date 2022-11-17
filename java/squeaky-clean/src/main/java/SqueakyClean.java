//import java.util.concurrent.LinkedTransferQueue;

class SqueakyClean {
    /**
     * @param identifier
     * @return
     */
    static String clean(String identifier) {
        StringBuilder myStringBuilder = new StringBuilder();

        for (int index = 0; index < identifier.length(); index++) {

            char letter = identifier.charAt(index);
            if (Character.isSpaceChar(letter))
                myStringBuilder.append("_");
            else if (Character.isISOControl(letter))
                myStringBuilder.append("CTRL");
            else if (letter == '-') {
                index++;
                if (Character.isDigit(identifier.charAt(index))) {
                    index++;
                    myStringBuilder.append(Character.toUpperCase(identifier.charAt(index)));
                } else {
                    myStringBuilder.append(Character.toUpperCase(identifier.charAt(index)));
                }
            } else if (Character.isLetter(letter) == false || (letter >= 'α' && letter <= 'ω'))
                myStringBuilder.append("");
            else
                myStringBuilder.append(letter);
        }
        return myStringBuilder.toString();
    }
}
