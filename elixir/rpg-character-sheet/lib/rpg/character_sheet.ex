defmodule RPG.CharacterSheet do

  @moduledoc """
  You and your friends love to play pen-and-paper
  role-playing games, but you noticed that it's
  difficult to get new people to join your group.
  They often struggle with character creation.
  They don't know where to start.
  To help new players out, you decided to write
  a small program that will guide them through the process.
  """

  @spec welcome() :: String.t()
  def welcome() do
    ## Please implement the welcome/0 function
    IO.puts("Welcome! Let's fill out your character sheet together.")
  end

  @spec ask_name() :: String.t()
  def ask_name() do
    ## Please implement the ask_name/0 function
    name = IO.gets("What is your character's name?\n")
    String.trim(name)

  end

  @spec ask_class() :: String.t()
  def ask_class() do
    ## Please implement the ask_class/0 function
    class = IO.gets("What is your character's class?\n")
    String.trim(class)
  end

  @spec ask_level() :: non_neg_integer()
  def ask_level() do
    ## Please implement the ask_level/0 function
    level = IO.gets("What is your character's level?\n")
    String.to_integer(String.trim(level))
  end

  def run() do
    ## Please implement the run/0 function
    welcome()
    name = ask_name()
    class = ask_class()
    level = ask_level()
    %{:class => class, :level => level, :name => name}
    |> IO.inspect(label: "Your character")
  end
end
