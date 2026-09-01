Imports System.ComponentModel.DataAnnotations

Public Class Form1
    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        Dim length As Double
        Dim width As Double
        Dim area As Double
        Dim perimeter As Double

        length = Convert.ToDouble(txtlength.Text)
        width = Convert.ToDouble(txtwidth.Text)
        area = length * width
        perimeter = 2 * (length + width)

        MessageBox.Show("Area: " & area & vbCrLf & "Perimeter: " & perimeter)
    End Sub
End Class
