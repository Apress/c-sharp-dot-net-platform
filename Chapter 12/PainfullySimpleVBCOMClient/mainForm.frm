VERSION 5.00
Begin VB.Form mainForm 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Calculator Client"
   ClientHeight    =   1380
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1380
   ScaleWidth      =   4680
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton btnAdd 
      Caption         =   "Add"
      Height          =   495
      Left            =   3000
      TabIndex        =   4
      Top             =   360
      Width           =   1455
   End
   Begin VB.TextBox txtNumb2 
      Height          =   375
      Left            =   1560
      TabIndex        =   2
      Text            =   "0"
      Top             =   720
      Width           =   1215
   End
   Begin VB.TextBox txtNumb1 
      Height          =   375
      Left            =   1560
      TabIndex        =   0
      Text            =   "0"
      Top             =   240
      Width           =   1215
   End
   Begin VB.Label Label2 
      Caption         =   "Number 2"
      Height          =   375
      Left            =   120
      TabIndex        =   3
      Top             =   720
      Width           =   855
   End
   Begin VB.Label Label1 
      Caption         =   "Number 1"
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   240
      Width           =   855
   End
End
Attribute VB_Name = "mainForm"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub btnAdd_Click()
    Dim c As New CoCalc
    MsgBox c.Add(txtNumb1, txtNumb2)
End Sub

