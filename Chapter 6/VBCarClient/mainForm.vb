Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

' Bring in the cars.
Imports CarLibrary

Public Class Form1
    Inherits System.Windows.Forms.Form
    
    Public Sub New()
        MyBase.New()
        
        Form1 = Me
        
        'This call is required by the Win Form Designer.
        InitializeComponent()
        CenterToScreen()
        
        'TODO: Add any initialization after the InitializeComponent() call
    End Sub
    
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

#Region " Windows Form Designer generated code "

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.Container
    Private WithEvents btnMiniVan As System.Windows.Forms.Button
    Private WithEvents btnCar As System.Windows.Forms.Button
    Private WithEvents btnPreCar As System.Windows.Forms.Button
    Private WithEvents btnPerfCar As System.Windows.Forms.Button
    Dim WithEvents Form1 As System.Windows.Forms.Form

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.btnPerfCar = New System.Windows.Forms.Button()
        Me.btnCar = New System.Windows.Forms.Button()
        Me.btnMiniVan = New System.Windows.Forms.Button()
        Me.btnPerfCar.Location = New System.Drawing.Point(48, 64)
        Me.btnPerfCar.Size = New System.Drawing.Size(232, 23)
        Me.btnPerfCar.TabIndex = 2
        Me.btnPerfCar.Text = "Play with Performance Car"
        Me.btnCar.Location = New System.Drawing.Point(16, 16)
        Me.btnCar.Size = New System.Drawing.Size(136, 23)
        Me.btnCar.TabIndex = 0
        Me.btnCar.Text = "Play with Car"
        Me.btnMiniVan.Location = New System.Drawing.Point(184, 16)
        Me.btnMiniVan.Size = New System.Drawing.Size(128, 23)
        Me.btnMiniVan.TabIndex = 1
        Me.btnMiniVan.Text = "Play with MiniVan"
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 117)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPerfCar, Me.btnMiniVan, Me.btnCar})
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB Car Client"

    End Sub

    Private Sub btnCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCar.Click        Dim sc As New SportsCar()
        sc.TurboBoost()
    End Sub

    Private Sub btnMiniVan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiniVan.Click        Dim sc As New MiniVan()
        sc.TurboBoost()
    End Sub

    Private Sub btnPerfCar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerfCar.Click        Dim pc As New PerformanceCar()

        pc.PetName = "Hank"  ' Inherited property.

        ' Display base class.
        MessageBox.Show(pc.GetType().BaseType.ToString(), "Base class of Perf car")

        ' Custom Implementation of Car.TurboBoost()
        pc.TurboBoost()
    End Sub

#End Region

End Class