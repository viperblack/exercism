defmodule DNA do
  def encode_nucleotide(code_point) do
    # Please implement the encode_nucleotide/1 function
    case {:code_point, code_point} do
      {:code_point, ?A} -> 0b0001
      {:code_point, ?C} -> 0b0010
      {:code_point, ?G} -> 0b0100
      {:code_point, ?T} -> 0b1000
      _ -> 0b0000
    end
  end

  def decode_nucleotide(encoded_code) do
    # Please implement the decode_nucleotide/1 function
    case {:encoded_code, encoded_code} do
      {:encoded_code, 0b0001} -> ?A
      {:encoded_code, 0b0010} -> ?C
      {:encoded_code, 0b0100} -> ?G
      {:encoded_code, 0b1000} -> ?T
      _ -> ?\s
    end
  end

  def encode(dna) do
    # Please implement the encode/1 function
    do_encode(dna, <<0::size(0)>>)
  end

  defp do_encode([], result), do: result

  defp do_encode([head|tail], result) do
    do_encode(tail,<<result::bitstring, encode_nucleotide(head)::4>>)
  end

  def decode(dna) do
    # Please implement the decode/1 function
    do_decode(dna, '')
  end

  defp do_decode(<<0::0>>, accum), do: accum

  defp do_decode(<<head::4, rest::bitstring>>, accum) do
    do_decode(rest, accum ++ [decode_nucleotide(head)])
  end

end
