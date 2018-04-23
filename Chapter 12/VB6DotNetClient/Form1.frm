VERSION 5.00
Begin VB.Form Form1 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "VB .NET Client"
   ClientHeight    =   1275
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1275
   ScaleWidth      =   4680
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton btnDoEverything 
      Caption         =   "Use .NET Object"
      Height          =   615
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   4335
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub btnDoEverything_Click()
On Error GoTo OOPS:

    Dim o As New CSharpCalc
    MsgBox o.Add(30, 30), , "Adding"
    MsgBox o.ToString, , "To String"
    MsgBox o.GetHashCode, , "Hash code"
    
    Dim t As Object
    Set t = o.GetType()
    MsgBox t, , "Type"
    
    Dim i As IAdvancedMath
    Set i = o
    MsgBox i.Multiple(4, 22), , "Multiply"
    MsgBox i.Divide(20, 2), , "Divide"
    MsgBox i.Divide(20, 0)  ' Throw error.
OOPS:
    MsgBox Err.Description, , "Error!"
End Sub
