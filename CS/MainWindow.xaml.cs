using System.Windows;
using DevExpress.Xpf.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Services.Implementation;
using DevExpress.XtraRichEdit.Commands;

namespace RichEditPreviewDocument {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            RichEditDocumentServer documentServer = new RichEditDocumentServer();
            documentServer.Text = "RichEditDocumentServer Print Preview.";
            LegacyPrintableComponentLink link = new LegacyPrintableComponentLink(documentServer);
            DocumentPreviewWindow window = new DocumentPreviewWindow();
            window.PreviewControl.DocumentSource = link;
            link.CreateDocument(false);
            window.ShowDialog();
        }
    }
}