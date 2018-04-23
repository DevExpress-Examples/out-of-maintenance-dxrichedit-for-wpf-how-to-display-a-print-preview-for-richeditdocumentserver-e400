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
            LegacyPrintableComponentLink link = new LegacyPrintableComponentLink(documentServer);
            LinkPreviewModel model = new RichEditLinkPreviewModel(link);
            DocumentPreviewWindow window = new DocumentPreviewWindow();

            model.Link = link;
            documentServer.Text = "RichEditDocumentServer Print Preview.";
            link.CreateDocument(false);
            window.Model = model;
            window.ShowDialog();
        }
    }
}