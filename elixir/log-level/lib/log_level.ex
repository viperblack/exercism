defmodule LogLevel do
  @moduledoc """
  Aggregate those logs and give them labels according to their severity level
  """

  def to_label(level, legacy?) do

    log_level = {:debug, :info, :warning, :error, :trace, :fatal}

    cond do
      level >= 1 && level <= 4 -> elem log_level, level - 1
      level == 0 && !legacy? -> :trace
      level == 5 && !legacy? -> :fatal
      true -> :unknown
    end

  end

  def alert_recipient(level, legacy?) do

    cond do
      to_label(level, legacy?) == :error || to_label(level, legacy?) == :fatal -> :ops
      to_label(level, legacy?) == :unknown && legacy? -> :dev1
      to_label(level, legacy?) == :unknown && !legacy? -> :dev2
      true -> false
    end
  end
end
