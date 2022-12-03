public class Blackjack {

    /**
     * @param card
     * @return a card value
     */
    public int parseCard(String card) {
        switch (card) {
            case "two":
                return 2;
            case "three":
                return 3;
            case "four":
                return 4;
            case "five":
                return 5;
            case "six":
                return 6;
            case "seven":
                return 7;
            case "eight":
                return 8;
            case "nine":
                return 9;
            case "ten":
            case "jack":
            case "queen":
            case "king":
                return 10;
            case "ace":
                return 11;
            default:
                return 0;
        }
    }

    /**
     * @param card1
     * @param card2
     * @return is blackjack?
     */
    public boolean isBlackjack(String card1, String card2) {
        if (parseCard(card1) + parseCard(card2) == 21) {
            return true;
        }
        return false;
    }

    /**
     * @param isBlackjack
     * @param dealerScore
     * @return
     */
    public String largeHand(boolean isBlackjack, int dealerScore) {
        if (isBlackjack && dealerScore != 11 && dealerScore != 10) {
            return "W";
        }
        if (!isBlackjack && dealerScore == 11) {
            return "P";
        }
        return "S";
    }

    public String smallHand(int handScore, int dealerScore) {
        if (handScore >= 17) {
            return "S";
        }

        if (handScore <= 11) {
            return "H";
        }

        if (handScore >= 12 && handScore <= 16 && dealerScore >= 7) {
            return "H";
        } else {
            return "S";
        }
    }

    // FirstTurn returns the semi-optimal decision for the first turn, given the
    // cards of the player and the dealer.
    // This function is already implemented and does not need to be edited. It pulls
    // the other functions together in a
    // complete decision tree for the first turn.
    public String firstTurn(String card1, String card2, String dealerCard) {
        int handScore = parseCard(card1) + parseCard(card2);
        int dealerScore = parseCard(dealerCard);

        if (20 < handScore) {
            return largeHand(isBlackjack(card1, card2), dealerScore);
        } else {
            return smallHand(handScore, dealerScore);
        }
    }
}
