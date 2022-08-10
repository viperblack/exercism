defmodule Username do
@moduledoc """
You have been hearing complaints from people saying they are unable to write emails to Mr. Müller. You quickly realize that most of the company uses an old email client that doesn't recognize müller@firma.de as a valid email address because of the non-Latin character.
Telling people to give up their favorite old email client is a lost battle, so you decide to create sanitized aliases for all email accounts.
"""
  def sanitize(''), do: ''

  def sanitize([head | tail]) do
    # ä becomes ae
    # ö becomes oe
    # ü becomes ue
    # ß becomes ss

    ## Please implement the sanitize/1 function
    sanitized =
      case head do
      head when head >= ?a and head <= ?z -> [head]
      ?_ -> '_'
      ?ä -> 'ae'
      ?ö -> 'oe'
      ?ü -> 'ue'
      ?ß -> 'ss'
      _ -> []

    end
    sanitized ++ sanitize(tail)
  end

end
