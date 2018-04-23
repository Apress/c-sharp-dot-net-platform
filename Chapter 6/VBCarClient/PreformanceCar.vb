Imports CarLibrary
Imports System.Windows.Forms


    ' This VB type is deriving from the C# SportsCar!
    Public Class PerformanceCar
        Inherits CarLibrary.SportsCar
    
        ' Inherited virtual method from Car.
        Overrides Sub TurboBoost()
            MessageBox.Show("Blistering speed", "VB PerformanceCar says")
        End Sub
    End Class
    
