VERSION 5.00
Begin VB.Form mainForm 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "VB 6.0 ATL CoCar Client"
   ClientHeight    =   2490
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   5250
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2490
   ScaleWidth      =   5250
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton btnGetCarType 
      Caption         =   "Get Car Type"
      Height          =   495
      Left            =   120
      TabIndex        =   5
      Top             =   960
      Width           =   1695
   End
   Begin VB.CommandButton btnSpeedUp 
      Caption         =   "SpeedUp"
      Height          =   495
      Left            =   120
      TabIndex        =   3
      Top             =   1800
      Width           =   1695
   End
   Begin VB.ListBox lstCylinderList 
      Height          =   1035
      Left            =   2040
      TabIndex        =   1
      Top             =   600
      Width           =   3015
   End
   Begin VB.CommandButton btnGetCylinders 
      Caption         =   "Get all Cylinders"
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   1695
   End
   Begin VB.Label Label2 
      Caption         =   "Current Speed: 0"
      Height          =   375
      Left            =   2040
      TabIndex        =   4
      Top             =   1920
      Width           =   3135
   End
   Begin VB.Label Label1 
      Alignment       =   2  'Center
      Caption         =   "Pet names for your cylinders"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2040
      TabIndex        =   2
      Top             =   240
      Width           =   3015
   End
End
Attribute VB_Name = "mainForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit
Private WithEvents myCar As CoCar
Attribute myCar.VB_VarHelpID = -1

Private Sub btnGetCarType_Click()
    Dim i As CarType
    i = myCar.GetCarType
    
    Dim enumVals(4) As String
    enumVals(0) = "Jetta"
    enumVals(1) = "BMW"
    enumVals(2) = "Ford"
    enumVals(3) = "Colt"
    
    MsgBox enumVals(i), , "Car Type:"
    
End Sub


Private Sub btnGetCylinders_Click()
    lstCylinderList.Clear

    ' First we need to get the engine
    Dim q As CoEngine
    Set q = myCar.GetEngine
    
    ' Now get cylinders.
    Dim strs As Variant
    strs = q.GetCylinders
    
    ' Now get each name from SAFEARRAY.
    Dim upper As Integer
    Dim i As Integer
    upper = UBound(strs)
    For i = 0 To upper
            lstCylinderList.AddItem strs(i)
    Next i

End Sub

Private Sub btnSpeedUp_Click()
On Error GoTo OOPS
    
    myCar.SpeedUp 50
    Label2.Caption = "Current Speed: " & myCar.GetCurSpeed
    
Exit Sub
OOPS:
    MsgBox Err.Description, , "Error from car!"
    Resume Next
End Sub

Private Sub Form_Load()
    Set myCar = New CoCar
End Sub

Private Sub myCar_Exploded(ByVal deadMsg As String)
    MsgBox deadMsg, , "Message from CoCar!"
End Sub
