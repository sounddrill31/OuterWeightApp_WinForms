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
        return result
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WeightEntered.Text = ""
        MercuryWeight.Text = ""
        VenusWeight.Text = ""
        EarthWeight.Text = ""
        MarsWeight.Text = ""
        JupiterWeight.Text = ""
        SaturnWeight.Text = ""
        UranusWeight.Text = ""
        NeptuneWeight.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim weightEarth As Double = WeightEntered.Text
        MercuryWeight.Text = CalcWeight(weightEarth, RatioMercury)
        VenusWeight.Text = CalcWeight(weightEarth, RatioVenus)
        EarthWeight.Text = WeightEntered.Text
        MarsWeight.Text = CalcWeight(weightEarth, RatioMars)
        JupiterWeight.Text = CalcWeight(weightEarth, RatioJupiter)
        SaturnWeight.Text = CalcWeight(weightEarth, RatioSaturn)
        UranusWeight.Text = CalcWeight(weightEarth, RatioUranus)
        NeptuneWeight.Text = CalcWeight(weightEarth, RatioNeptune)
    End Sub
End Class
