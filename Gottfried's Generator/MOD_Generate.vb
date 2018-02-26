Imports Word = Microsoft.Office.Interop.Word

Module MOD_Generate

    Public WordApp As Word.Application
    Public WordDoc As Word.Document

    Public rand As New Random 'random number generator
    Public Sub Generate_worksheet(ByVal title As String, ByVal highest As Integer, ByVal allowed As ArrayList)
        'Calls other functions to create questions, and then puts the whole thing into
        'a Word document by calling another function.
        Dim question_set(10) As Question_pair 'Prepares an array to hold ten questions
        For i As Integer = 0 To 9 'loops ten times.
            question_set(i) = Choose_question(highest, allowed) 'fills the array with questions
        Next
        Populate_worksheet(title, question_set) 'Call a function to fill the worksheet
    End Sub

    Private Sub Populate_worksheet(ByVal title As String, ByVal question_set As Array)
        WordApp = New Word.Application 'Open instance of word.
        WordDoc = New Word.Document 'Make a new document
        WordDoc = WordApp.Documents.Add(Application.StartupPath & "\Worksheet template.dotm") 'Apply the template
        WordApp.Options.Overtype = True
        Dim placeholders As Word.Bookmarks = WordDoc.Bookmarks 'Get all the placeholders
        placeholders("BK_Title1").Range.Text = title 'fill in the titles
        placeholders("BK_Title2").Range.Text = title & " " 'as above
        For i As Integer = 1 To 10 'loop through the questions and fill in the appropriate spaces on the worksheet.
            placeholders("Q" + Convert.ToString(i)).Range.Text = question_set(i - 1).question & vbCr
            placeholders("A" + Convert.ToString(i)).Range.Text = question_set(i - 1).answer
        Next
        WordApp.Visible = True
    End Sub

    Private Function Choose_question(ByVal highest As Integer, ByVal allowed As ArrayList)
        'Selects a question type from the allowed options, calls the specific function,
        'and returns the question-answer pair.
        Dim question As Question_pair
        question.question = "undefined"
        question.answer = "undefined"
        Dim choice As Integer = rand.Next(0, allowed.Count)
        If allowed(choice) = "Binary/Denary Conversion" Then
            question = Binary_conversion(highest)
        ElseIf allowed(choice) = "Binary Addition" Then
            question = Binary_addition(highest)
        ElseIf allowed(choice) = "Binary Subtraction" Then
            question = Binary_subtraction(highest)
        ElseIf allowed(choice) = "Logical Shifts" Then
            question = Binary_shift(highest)
        ElseIf allowed(choice) = "Hexadecimal/Denary Conversion" Then
            question = Hex_conversion(highest)
        ElseIf allowed(choice) = "Hexadecimal Addition" Then
            question = Hex_addition(highest)
        ElseIf allowed(choice) = "Hexadecimal Subtraction" Then
            question = Hex_subtraction(highest)
        ElseIf allowed(choice) = "Binary/Hexadecimal Conversion" Then
            question = Bin_Hex_conversion(highest)
        End If
        Return question
    End Function

    Public Sub wrap_up()
        'closes everything neatly
        WordDoc = Nothing
        WordApp = Nothing
    End Sub

End Module
