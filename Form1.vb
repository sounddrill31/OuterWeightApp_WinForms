Public Class Form1

    Dim RatioEarth As Double = 1D
    Dim RatioMercury As Double = 0.38D
    Dim RatioMars As Double = 0.38D
    Dim RatioJupiter As Double = 2.36D
    Dim RatioSaturn As Double = 0.92D
    Dim RatioVenus As Double = 0.9D
    Dim RatioUranus As Double = 0.89D
    Dim RatioNeptune As Double = 1.12D
    Dim RatioMoon As Double = 0.17D


    Function CalcWeight(ByVal WeightEarth As Double, ByVal PlanetRatio As Double) As Double
        ' local variable declaration */
        Dim result As Double

        result = (WeightEarth * PlanetRatio)
        Dim FindMax = result
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WeightEntered.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim weightEarth As Double = WeightEntered.Text
        TextBox1.Text = CalcWeight(weightEarth, RatioMercury)
        TextBox2.Text = CalcWeight(weightEarth, RatioVenus)
        TextBox3.Text = WeightEntered.Text
        TextBox4.Text = CalcWeight(weightEarth, RatioMars)
        TextBox5.Text = CalcWeight(weightEarth, RatioJupiter)
        TextBox6.Text = CalcWeight(weightEarth, RatioSaturn)
        TextBox7.Text = CalcWeight(weightEarth, RatioUranus)
        TextBox8.Text = CalcWeight(weightEarth, RatioNeptune)
    End Sub
End Class
