'Sehaj Kohli
'2022/12/01
'This is a math game when the start button is pressed then the program will select a number from 0 to 1000
'the user have to use the options on the side to make the random number to 100 and then the user will win
'The program will also count how many time you press the button

Public Class Frmmakethenumberto100
    'these are the variables that are decleared for the whole program and can be used anywhere
    Dim intcounter As Integer
    Dim newNum As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdstart.Click
        'Chose a number from 0 to 1000 that is a whole not in decimal
        lbloriginalnumber.Text = Int(Rnd() * 1000)
        'tells that this to variable is connected to the label which will display the original number.
        newNum = lbloriginalnumber.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmddone.Click
        'end this program
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdagain.Click
        'this button is displaying "Again" which will set
        'where original number how many times you calculated and where the new number is displayed
        'to null properties
        lbloriginalnumber.Text = ""
        lblcounternumber.Text = ""
        lblnewnumber.Text = ""
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblcounternumber.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cmdapplythemath.Click

        'this is the counter for how many times you pressed the button to apply the math
        intcounter = intcounter + 1
        lblcounternumber.Text = intcounter

        'when selected the original number will get added after that the number will get added to the new number
        If RadioButton1.Checked = True Then
            newNum = newNum + 2
            lblnewnumber.Text = newNum
        End If

        'when selected the original number will get subtracted after that the number will get subtracted to the new number
        If RadioButton2.Checked = True Then
            newNum = newNum - 2
            lblnewnumber.Text = newNum
        End If

        'when selected the original number will get multiply after that the number will get multiply to the new number
        If rdbmultiply.Checked = True Then
            newNum = newNum * 2
            lblnewnumber.Text = newNum
        End If

        'when selected the original number will get divided after that the number will get divided to the new number
        If rdbdivide.Checked = True Then
            newNum = newNum / 2
            lblnewnumber.Text = newNum
        End If

        'when selected the original number will get square wiht that number after that it will get square to that new number
        If rdbsquare.Checked = True Then
            newNum = newNum ^ 2
            lblnewnumber.Text = newNum
        End If

        'when selected the original number will get squareroot after that the number will get squareroot to the new number
        If rdbsquareroot.Checked = True Then
            newNum = Math.Sqrt(lbloriginalnumber.Text)
            lblnewnumber.Text = newNum
        End If

        'this is button will promp a window saying you won the gane you made the new number to 100
        Dim intcreatnumber As Integer 'declear the variable to integer and connected it to where the new number will be shown and tell it to only read the text
        Dim intfinalnumber As Integer = 100 'this is the variable which tells the program that the final number is 100 
        'links the variable to lblnewnumer to the text in the new number u are calculating to 100
        intcreatnumber = lblnewnumber.Text
        'compares the textbox to the value 100 if they are equal then the message will display in a new window
        If intcreatnumber = intfinalnumber Then
            'this will check the statemenrt then show this message
            'this command is used to make the new window apper to tell that to display the message below
            MsgBox("You Did it you got to 100")

        End If

    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblnewnumber.Click

    End Sub

    Private Sub lblinstruction_Click(sender As Object, e As EventArgs) Handles lblinstruction.Click

    End Sub
End Class
