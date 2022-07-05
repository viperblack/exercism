(module
  (func (export "steps") (param $number i32) (result i32) 
  (local $count i32)

  (i32.le_s (local.get $number) (i32.const 0))

    if i32.const -1
      return 
    end

  (block $block 
    (loop $loop 
      (i32.eq (local.get $number) (i32.const 1)) 
      br_if $block 
      (i32.rem_s (local.get $number) (i32.const 2))

      if  local.get $number 
          i32.const 3 
          i32.mul 
          i32.const 1 
          i32.add 
          local.set $number 
      else  local.get $number 
            i32.const 2 
            i32.div_s 
            local.set $number 
      end (
        local.set $count (i32.add (local.get $count) (i32.const 1))) 
        br $loop 
    ) 
  )
  (return (local.get $count))) 
)
