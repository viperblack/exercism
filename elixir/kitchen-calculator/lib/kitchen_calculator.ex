defmodule KitchenCalculator do
@moduledoc """
You have found that you have to convert some of the measurements used in the recipe. Being only familiar with the metric system, you need to come up with a way to convert common US baking measurements to milliliters (mL) for your own ease.
"""
  def get_volume(volume_pair) do
    ## Please implement the get_volume/1 function
    elem(volume_pair, 1)
  end

  def to_milliliter({:cup, value}) do
    ## Please implement the to_milliliter/1 functions
    {:milliliter, value * 240}
  end

  def to_milliliter({:fluid_ounce, value}) do
    ## Please implement the to_milliliter/1 functions
    {:milliliter, value * 30}
  end

  def to_milliliter({:teaspoon, value}) do
    ## Please implement the to_milliliter/1 functions
    {:milliliter, value * 5}
  end

  def to_milliliter({:tablespoon, value}) do
    ## Please implement the to_milliliter/1 functions
    {:milliliter, value * 15}
  end

  def to_milliliter(volume_pair) do
    ## Please implement the to_milliliter/1 functions
    {elem(volume_pair, 0), get_volume(volume_pair)}
  end

  def from_milliliter({_, value}, :cup) do
    ## Please implement the from_milliliter/2 functions
    {:cup, value / 240}
  end

  def from_milliliter({_, value}, :fluid_ounce) do
    ## Please implement the from_milliliter/2 functions
    {:fluid_ounce, value / 30}
  end

  def from_milliliter({_, value}, :teaspoon) do
    ## Please implement the from_milliliter/2 functions
    {:teaspoon, value / 5}
  end

  def from_milliliter({_, value}, :tablespoon) do
    ## Please implement the from_milliliter/2 functions
    {:tablespoon, value / 15}
  end

  def from_milliliter(volume_pair, unit) do
    ## Please implement the from_milliliter/2 functions
    {unit, get_volume(volume_pair)}
  end

  def convert(volume_pair, unit) do
    ## Please implement the convert/2 function
    from_milliliter(to_milliliter(volume_pair), unit)
  end
end
