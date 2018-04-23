Imports Microsoft.VisualBasic
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
			Dim model As LegacyLinkPreviewModel = New RichEditLinkPreviewModel()
			Dim link As New PrintableComponentLinkBase(New PrintingSystemBase())
			Dim window As New DocumentPreviewWindow()

			link.Component = documentServer
			model.Link = link
			documentServer.Text = "RichEditDocumentServer Print Preview."
			link.CreateDocument(False)
			window.Model = model
			window.ShowDialog()
		End Sub
	End Class
End Namespace