let fizzbuzz maxNum =
    for i = 1 to maxNum do
        let fizz = if i % 3 = 0 then "Fizz" else ""
        let buzz = if i % 5 = 0 then "Buzz" else ""
        let number = if fizz = "" && buzz = "" then i.ToString() else ""
        printfn $"%s{fizz}%s{buzz}%s{number}"              
        
fizzbuzz 100

