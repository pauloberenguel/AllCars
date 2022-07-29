
Option Strict On

Class StatusBarChild

    Public ChildControl As Control        ' The progressbar or any child control
    Public StatusBar As StatusBar        ' The statusbar
    Public Panel As Int16                ' The status panel
    Public Margin As Int32               ' The margin between the panel's edge and the progressbar


    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Int32, ByVal msg As Int32, ByVal wParam As Int32, ByRef lParam As RECT) As Long
    Public Const WM_USER As Long = &H400
    Public Const SB_GETRECT As Long = (WM_USER + 10)

    Public Structure RECT
        Public Left As Int32
        Public Top As Int32
        Public Right As Int32
        Public Bottom As Int32
    End Structure


    Public Sub New(ByRef obj As Control, ByRef sb As StatusBar, Optional ByRef intPanelNumber As Int16 = 0, Optional ByVal intMargin As Int32 = 2)
        ChildControl = obj
        StatusBar = sb
        Panel = intPanelNumber
        Margin = intMargin
        ChildControl.Parent = StatusBar
        Resize()
        ChildControl.Visible = True
    End Sub


    Public Sub Resize()
        Dim Rectangle As RECT
        SendMessage(StatusBar.Handle.ToInt32, SB_GETRECT, Panel, Rectangle)
        With ChildControl
            .Left = Rectangle.Left + Margin
            .Top = Rectangle.Top + Margin
            .Height = Rectangle.Bottom - Rectangle.Top - 2 * Margin
            .Width = Rectangle.Right - Rectangle.Left - 2 * Margin
        End With
    End Sub

End Class