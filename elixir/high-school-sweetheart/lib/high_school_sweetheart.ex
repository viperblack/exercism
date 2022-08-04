defmodule HighSchoolSweetheart do
@moduledoc """
Help high school sweethearts profess their love on social media by generating an ASCII heart with their initials.
"""
  def first_letter(name) do
    ## Please implement the first_letter/1 function
    String.first(String.trim(name))
  end

  def initial(name) do
    ## Please implement the initial/1 function
    String.upcase(first_letter(name)) <> "."
  end

  def initials(full_name) do
    ## Please implement the initials/1 function
    [first_name | last_name] = String.split(full_name)
    initial(first_letter(to_string(first_name))) <> " " <> initial(first_letter(to_string(last_name)))
  end

  def pair(full_name1, full_name2) do
    #      ******       ******
    #    **      **   **      **
    #  **         ** **         **
    # **            *            **
    # **                         **
    # **     X. X.  +  X. X.     **
    #  **                       **
    #    **                   **
    #      **               **
    #        **           **
    #          **       **
    #            **   **
    #              ***
    #               *

    ## Please implement the pair/2 function
"""
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     #{initials(full_name1)}  +  #{initials(full_name2)}     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
""" 
  end
end
