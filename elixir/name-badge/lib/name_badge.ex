defmodule NameBadge do
  def print(id, name, department) do
    ## Please implement the print/3 function
    if department do
      if id do
        #Return the badge label, with the department name in uppercase.
        "[#{id}] - #{name} - " <> String.upcase(department)
      else
        #Return the badge label, with the department name in uppercase without id.
        "#{name} - " <> String.upcase(department)
      end
    else
      if id do
        #Return the badge label, with the department name in uppercase for owner.
        "[#{id}] - #{name} - OWNER"
      else
        #Return the badge label, with the department name in uppercase without id for owner.
        "#{name} - OWNER"
      end
    end
  end
end
