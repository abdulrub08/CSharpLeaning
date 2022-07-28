Module Module1
    Public Sub CBin(ByVal n As Integer)
        Dim bin() As Integer, index As Integer = 0
        Dim num As Integer, i As Integer, binstr As String
        
        num = n
        Do While num <> 0
            ReDim Preserve bin(index)
            bin(index) = num Mod 2
            num = num \ 2
            index = index + 1
        Loop
        binstr = ""
        For i = index - 1 To 0 Step -1
            binstr = binstr & bin(i)
        Next
        MessageBox.Show("Binary Conversion of " & n & " is " & binstr)

    End Sub
End Module
