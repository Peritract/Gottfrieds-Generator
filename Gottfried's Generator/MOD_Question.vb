Module MOD_Question

    Public rand As New Random 'random number generator

    Structure Question_pair
        'Structure for storing question-answer pairs
        Dim question As String
        Dim answer As String
    End Structure

    Public Function Binary_conversion(ByVal highest As Integer) As Question_pair
        Dim question As Question_pair
        Dim num As Integer = rand.Next(0, highest) 'Choose the number to be converted
        Dim str As String = Convert.ToString(num, 2) 'binary representation of the number
        If rand.Next(0, 2) = 1 Then
            question.question = "Convert the binary number " & str & " to Base 10."
            question.answer = Convert.ToString(num)
        Else
            question.question = "Convert the Base 10 number " & Convert.ToString(num) & " to binary."
            question.answer = str
        End If
        Return question
    End Function

    Public Function Hex_conversion(ByVal highest As Integer) As Question_pair
        Dim question As Question_pair
        Dim num As Integer = rand.Next(0, highest) 'Choose the number to be converted
        Dim str As String = Convert.ToString(num, 16).ToUpper() 'hex representation of the number
        If rand.Next(0, 2) = 1 Then
            question.question = "Convert the hexadecimal number " & str & " to Base 10."
            question.answer = Convert.ToString(num)
        Else
            question.question = "Convert the Base 10 number " & Convert.ToString(num) & " to hexadecimal."
            question.answer = str
        End If
        Return question
    End Function

    Public Function Bin_Hex_conversion(ByVal highest As Integer) As Question_pair
        Dim question As Question_pair
        Dim num As Integer = rand.Next(0, highest) 'Choose the number to be converted
        If rand.Next(0, 2) = 1 Then
            question.question = "Convert the hexadecimal number " & Convert.ToString(num, 16).ToUpper() & " to binary."
            question.answer = Convert.ToString(num, 2)
        Else
            question.question = "Convert the binary number " & Convert.ToString(num, 2) & " to hexadecimal."
            question.answer = Convert.ToString(num, 16).ToUpper()
        End If
        Return question
    End Function

    Public Function Binary_addition(ByVal highest As Integer)
        Dim question As Question_pair
        Dim num As Integer = rand.Next(1, highest) 'Choose the answer number
        question.answer = Convert.ToString(num, 2) 'binary representation of the number
        Dim num1 As Integer = rand.Next(0, num) 'Choose one of the numbers to be added
        question.question = "Add the binary numbers " & Convert.ToString(num1, 2) & " and " & Convert.ToString(num - num1, 2) & " together." 'create the question string
        Return question 'return the pair
    End Function

    Public Function Hex_addition(ByVal highest As Integer)
        Dim question As Question_pair
        Dim num As Integer = rand.Next(1, highest) 'Choose the answer number
        Dim num1 As Integer = rand.Next(1, num) 'Choose one of the numbers to be added
        question.answer = Convert.ToString(num, 16).ToUpper()
        question.question = "Add the hexadecimal numbers " & Convert.ToString(num1, 16).ToUpper() & " and " & Convert.ToString(num - num1, 16).ToUpper() & " together."
        Return question 'return the pair
    End Function

    Public Function Binary_subtraction(ByVal Highest As Integer)
        Dim question As Question_pair
        Dim num As Integer = rand.Next(0, Highest - 1) 'Choose the lower number
        Dim num1 As Integer = rand.Next(num, Highest) 'Choose the higher number
        question.question = "Subtract the binary number " & Convert.ToString(num, 2) & " from " & Convert.ToString(num1, 2) & "." 'create the question string
        question.answer = Convert.ToString(num1 - num, 2) 'Create the answer string
        Return question 'return the pair
    End Function

    Public Function Hex_subtraction(ByVal Highest As Integer)
        Dim question As Question_pair
        Dim num As Integer = rand.Next(0, Highest - 1) 'Choose the lower number
        Dim num1 As Integer = rand.Next(num, Highest) 'Choose the higher number
        question.question = "Subtract the hexadecimal number " & Convert.ToString(num, 16).ToUpper() & " from " & Convert.ToString(num1, 16).ToUpper() & "." 'create the question string
        question.answer = Convert.ToString(num1 - num, 16).ToUpper() 'Create the answer string
        Return question 'return the pair
    End Function


    Public Function Binary_shift(ByVal highest As Integer)
        Dim question As Question_pair

        Dim steps As Integer
        Dim num1 As Integer
        Dim num2 As Integer
        Dim valid As Boolean = False

        While valid = False 'run until a possible question is found

            steps = rand.Next(1, 4)
            num1 = rand.Next(1, highest)
            num2 = num1 * (2 ^ steps)

            If num2 Mod 1 = 0 AndAlso num2 < highest AndAlso num2 >= 0 Then
                valid = True
            End If
        End While

        Dim step_word As String = " places." 'grammar
        If steps = 1 Then
            step_word = " place."
        End If

        If rand.Next(0, 2) = 0 Then 'left shift
            question.answer = Convert.ToString(num2, 2)
            question.question = "Left logical shift " & Convert.ToString(num1, 2) & " by " & Convert.ToString(steps) & step_word
        Else
            question.answer = Convert.ToString(num1, 2)
            question.question = "Right logical shift " & Convert.ToString(num2, 2) & " by " & Convert.ToString(steps) & step_word
        End If


        Return question
    End Function

End Module
