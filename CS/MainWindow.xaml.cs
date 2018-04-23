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
            LegacyLinkPreviewModel model = new RichEditLinkPreviewModel();
            PrintableComponentLinkBase link = new PrintableComponentLinkBase(new PrintingSystemBase());
            DocumentPreviewWindow window = new DocumentPreviewWindow();

            link.Component = documentServer;
            model.Link = link;
            documentServer.Text = "RichEditDocumentServer Print Preview.";
            link.CreateDocument(false);
            window.Model = model;
            window.ShowDialog();
        }
    }
}