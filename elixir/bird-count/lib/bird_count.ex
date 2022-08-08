defmodule BirdCount do
@moduledoc """
Keeps track of how many birds have visited your garden on any given day.
You decided to bring your bird watching to a new level and implement a few tools that will help you track and process the data.
You have chosen to store the data as a list of integers. The first number in the list is the number of birds that visited your garden today, the second yesterday, and so on.
"""

  def today([]), do: nil

  def today(list) do
    ## Please implement the today/1 function
    [today | _other_days] = list
    today
  end

  def increment_day_count([]), do: [1]

  def increment_day_count(list) do
    ## Please implement the increment_day_count/1 function
    [today | tail] = list
    [today + 1 | tail]
  end

  def has_day_without_birds?(list) do
    ## Please implement the has_day_without_birds?/1 function
    0 in list
  end

  def total([]), do: 0

  def total(list) do
    ## Please implement the total/1 function
    [head | tail] = list
    head + total(tail)
  end

  def busy_days([]), do: 0

  def busy_days([head | tail]) when head >= 5, do: 1 + busy_days(tail)

  def busy_days([_ | tail]) do
    ## Please implement the busy_days/1 function
    busy_days(tail)
  end
end
