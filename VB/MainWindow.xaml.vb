Imports System.Windows
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Services.Implementation
Imports DevExpress.XtraRichEdit.Commands

Namespace RichEditPreviewDocument
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim documentServer As New RichEditDocumentServer()
            documentServer.Text = "RichEditDocumentServer Print Preview."
            Dim link As New LegacyPrintableComponentLink(documentServer)
            Dim window As New DocumentPreviewWindow()
            window.PreviewControl.DocumentSource = link
            link.CreateDocument(False)
            window.ShowDialog()
        End Sub
    End Class
End Namespace