defmodule TakeANumber do
  def start() do
    ## Please implement the start/0 function
    spawn(fn -> machine() end)
  end

  def machine(state \\ 0) do
    receive do
      :stop ->
        :stopped

      {:report_state, sender_pid} ->
        send(sender_pid, state)
        machine(state)

      {:take_a_number, sender_pid} ->
        send(sender_pid, state + 1)
        machine(state + 1)

      _ ->
        machine(state)
    end
  end
end
