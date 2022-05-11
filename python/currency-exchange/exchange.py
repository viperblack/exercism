'''Welcome to Currency Exchange on Exercism's Python Track.'''


def exchange_money(budget, exchange_rate):
    '''This function should return the value of the
    exchanged currency.'''
    return budget / exchange_rate


def get_change(budget, exchanging_value):
    '''This function should return the amount
    of money that *is left* from the budget.'''

    return budget - exchanging_value


def get_value_of_bills(denomination, number_of_bills):
    '''Your function should return only the total value of
    the bills (_excluding fractional amounts_) the booth would give back.'''
    return denomination * number_of_bills


def get_number_of_bills(budget, denomination):
    '''This function should return the _number of new currency bills_
    that you can receive within the given _budget_.'''
    # The '//' operator means "floor division", so it only calculates a natural number.
    return budget // denomination


def exchangeable_value(budget, exchange_rate, spread, denomination):
    '''This function should return the maximum value of the new currency
    after calculating the *exchange rate* plus the *spread*.'''

    actual_exchange_rate = exchange_rate * (1 + spread/100)
    exchanged_value = exchange_money(budget, actual_exchange_rate)
    bills_exchanged = get_number_of_bills(exchanged_value, denomination)

    return get_value_of_bills(denomination, bills_exchanged)


def non_exchangeable_value(budget, exchange_rate, spread, denomination):
    '''This function should return the value that is *not* exchangeable
    due to the *denomination* of the bills.'''
    actual_exchange_rate = exchange_rate * (1 + spread/100)
    exchanged_value = exchange_money(budget, actual_exchange_rate)
    value_of_bills = exchangeable_value(
        budget, exchange_rate, spread, denomination)
    non_exchanged_value = int(get_change(exchanged_value, value_of_bills))
    return non_exchanged_value
