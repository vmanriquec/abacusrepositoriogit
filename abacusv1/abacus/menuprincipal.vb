Imports System.Runtime.InteropServices
Public Class menuprincipal

    Private Const WM_SYSCOMMAND As Integer = 274
    Private Const SC_MAXIMIZE As Integer = 61488
    Declare Auto Function SetParent Lib "user32.dll" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Integer
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim cf As New Form1
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        Dim cf As New gestionclientes
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Dim cf As New Gestionproveedores
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX6.Click
        Dim cf As New gestionfamilia
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX5.Click
        Dim cf As New categoriasdeproductos
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX4.Click
        Dim cf As New gestionproductos
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX10.Click
        Dim cf As New gestiondeingresos2
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX9.Click
        Dim cf As New registrorutas
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX7.Click
        Dim cf As New clientedireccionruta
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX8.Click
        Dim cf As New ProgramacionVisitasaclientes
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub RibbonTabItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RibbonTabItem5.Click

    End Sub

    Private Sub ButtonX11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX11.Click
        Dim cf As New mapas
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub ButtonX12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX12.Click
        Dim proc1 As Process = Process.Start("C:\Users\Cesar\Desktop\sistemas\ConsultasPeru\TestLibSunat\bin\Debug\testlibsunat.exe")
        proc1.WaitForInputIdle()
        SetParent(proc1.MainWindowHandle, Me.PanelEx1.Handle)
        SendMessage(proc1.MainWindowHandle, WM_SYSCOMMAND, SC_MAXIMIZE, 0)

    End Sub

    Private Sub RibbonTabItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ButtonX13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX13.Click
        Dim cf As New gestionguias
        cf.TopLevel = False
        cf.Parent = Me.PanelEx1
        cf.StartPosition = FormStartPosition.CenterParent
        cf.Show()
    End Sub

    Private Sub PanelEx2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class