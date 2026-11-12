module ArithmeticOperations =

    // 1. Қосу
    (function (a, b) -> a + b)

    // 2. Азайту
    (function (a, b) -> a - b)

    // 3. Көбейту
    (function (a, b) -> a * b)

    // 4. Бөлу
    (function (a, b) ->
        if b = 0 then
            failwith "Қате: нөлге бөлуге болмайды!"
        else
            a / b)

    // 5. Квадрат
    (function a -> a * a)