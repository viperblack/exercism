defmodule GuessingGame do
  @moduledoc """
  A trivial online game where a friend can guess a secret number. You want to give some feedback, but not give away the answer with a guess. You need to devise a function to provide different responses depending on how the guess relates to the secret number.
  """

  def compare(secret_number, guess \\ :no_guess)

  def compare(secret_number, guess) when secret_number == guess do
    ## Please implement the compare/2 function
    ## When the guess matches the secret number
    "Correct"
  end

  def compare(_secret_number, guess) when is_atom(guess) do
    "Make a guess"
  end

  def compare(secret_number, guess) when secret_number == guess + 1 or secret_number == guess - 1 do
    ## When the guess is one more or one less than the secret number
    "So close"
  end

  def compare(secret_number, guess) when secret_number < guess do
    # When the guess is greater secret number  
    "Too high"
  end

  def compare(secret_number, guess) when secret_number > guess do
    # When the guess is lesser secret number  
    "Too low"
  end  

end
