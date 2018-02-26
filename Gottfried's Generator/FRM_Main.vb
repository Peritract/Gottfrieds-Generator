Imports System.ComponentModel

Public Class FRM_Main


    Private Sub BTN_Generate_Click(sender As Object, e As EventArgs) Handles BTN_Generate.Click
        'Takes the information from the form and sends it to the worksheet-generator module.
        If CLB_Topics.CheckedItems.Count = 0 Then 'If no topics were chosen
            CLB_Topics.SetItemChecked(0, True) 'choose the Binary conversion option as the default
        End If
        Dim allowed As ArrayList = New ArrayList
        For Each item In CLB_Topics.CheckedItems
            Dim str As String = item
            allowed.Add(item)
        Next
        MOD_Generate.Generate_worksheet(TXT_Title.Text, Convert.ToInt32(TXT_Highest.Text), allowed)
    End Sub

    Private Sub TXT_Highest_Validating(sender As Object, e As CancelEventArgs) Handles TXT_Highest.Validating
        'When validated, alerts the user if the value in the textbox is non-numeric
        If Not IsNumeric(TXT_Highest.Text) Or TXT_Highest.Text < 1 Then
            MsgBox("Please enter a valid highest value.")
            e.Cancel = True
        End If
    End Sub

    Private Sub TXT_Title_Validating(sender As Object, e As CancelEventArgs) Handles TXT_Title.Validating
        'When validated, checks if the textbox is empty and if it is, substitutes a placeholder value.
        If TXT_Title.Text.Length < 1 Then
            TXT_Title.Text = "Number Systems Worksheet"
        End If
    End Sub

    Private Sub FRM_Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MOD_Generate.wrap_up() 'Close it all down
    End Sub

End Class
