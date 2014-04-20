Module Module1
    Public dblSubPrice As Double
    Public dblTax As Double
    Public dblTotal As Double
    Public Const dblTaxRate As Double = 0.06D

    Public intMenu(20) As Integer
    Public intCurrIndex As Integer = 0
    Public intEntreeCount As Integer = 8
    Public intAppitizerCount As Integer = 4
    Public intDessertCount As Integer = 4

    Public bolEntreeUpdate As Boolean = False
    Public bolAppUpdate As Boolean = False
    Public bolDessertUpdate As Boolean = False

    Public strLastName As String
    Public strFirstName As String
    Public strAddress As String
    Public strCity As String
    Public strState As String
    Public strZip As String
    Public strCountry As String
    Public strPhone As String

    Function getStrMenu(intMenuNum As Integer)
        If intMenuNum = 0 Then
            Return ("Speghetti and Meatballs (11.90)")
        ElseIf intMenuNum = 1 Then
            Return ("Steak (15.00)")
        ElseIf intMenuNum = 2 Then
            Return ("Peperoni Pizza (12.50)")
        ElseIf intMenuNum = 3 Then
            Return ("Pizza Margeherita (11.50)")
        ElseIf intMenuNum = 4 Then
            Return ("Lobster (23.95)")
        ElseIf intMenuNum = 5 Then
            Return ("Linguine (9.50)")
        ElseIf intMenuNum = 6 Then
            Return ("Pesto Pasta (13.50)")
        ElseIf intMenuNum = 7 Then
            Return ("Pasta Alfredo (14.00)")
        ElseIf intMenuNum = 8 Then
            Return ("Tortellini Soup (8.00)")
        ElseIf intMenuNum = 9 Then
            Return ("Bruschetta (7.50)")
        ElseIf intMenuNum = 10 Then
            Return ("Garlic Bread (5.00)")
        ElseIf intMenuNum = 11 Then
            Return ("Caprese Salad (8.00)")
        ElseIf intMenuNum = 12 Then
            Return ("Gelato (9.00)")
        ElseIf intMenuNum = 13 Then
            Return ("Chocolate Cake (10.50)")
        ElseIf intMenuNum = 14 Then
            Return ("Profiteroles (11.50)")
        Else
            Return ("Creme Brulee (14.00)")
        End If
    End Function

    Function getPriceMenu(intMenuNum As Integer)
        If intMenuNum = 0 Then
            Return (11.9D)
        ElseIf intMenuNum = 1 Then
            Return (15D)
        ElseIf intMenuNum = 2 Then
            Return (12.5D)
        ElseIf intMenuNum = 3 Then
            Return (11.5D)
        ElseIf intMenuNum = 4 Then
            Return (23.95D)
        ElseIf intMenuNum = 5 Then
            Return (9.5D)
        ElseIf intMenuNum = 6 Then
            Return (13.5D)
        ElseIf intMenuNum = 7 Then
            Return (14D)
        ElseIf intMenuNum = 8 Then
            Return (8D)
        ElseIf intMenuNum = 9 Then
            Return (7.5D)
        ElseIf intMenuNum = 10 Then
            Return (5D)
        ElseIf intMenuNum = 11 Then
            Return (8D)
        ElseIf intMenuNum = 12 Then
            Return (9D)
        ElseIf intMenuNum = 13 Then
            Return (10.5D)
        ElseIf intMenuNum = 14 Then
            Return (11.5D)
        Else
            Return (14D)
        End If
    End Function

    Function Remove(intIndexRemove As Integer)
        Dim intMenuTemp(20) As Integer
        Dim x As Integer = 0
        Dim intTempIndex As Integer = 0
        While x < intCurrIndex
            If x = intIndexRemove Then
            Else
                intMenuTemp(intTempIndex) = intMenu(x)
                intTempIndex = intTempIndex + 1
            End If
            x = x + 1
        End While
        intCurrIndex = intCurrIndex - 1
        Dim z As Integer = 0
        While z < intCurrIndex
            intMenu(z) = intMenuTemp(z)
            z = z + 1
        End While
        Return True
    End Function
End Module