
module ArithmeticOperations

// 1. Қосу
let add a b =
    a + b

// 2. Азайту
let subtract a b =
    a - b

// 3. Көбейту
let multiply a b =
    a * b

// 4. Бөлу (нөлге бөлуді тексеру)
let divide a b =
    if b = 0 then
        failwith "Қате: нөлге бөлуге болмайды!"
    else
        a / b

// 5. Квадратқа көтеру
let square a =
    a * a
