using DevExpress.XtraReports.UI;
using GenerateurLicences.data.Cmd;
using GenerateurLicences.Localisation;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GenerateurLicences
{
    public partial class FrmDetails : DevExpress.XtraEditors.XtraForm
    {
        public string ClientCode = string.Empty;
        public bool Dialog = false;
        public FrmDetails()
        {
            InitializeComponent();
        }
        private void FrmDetails_Shown(object sender, EventArgs e)
        {
            CodeClientDetails.Text = ClientCode;
            try
            {
                if (Dialog)
                {
                    DetailsRepository.DefractionnerObjetReaderDetails(ProgramManager.RecupDataDetails(CodeClientDetails.Text),
                        PicLicence1, PicLicence2, PicLicence3, DateExpirationDelais, DebutLicenceDetails, GropLicences, NumeroLicnceDetails, JourRestant, NomClientDetail, txtZipeCode, JourRestant);
                    LicenceDelaisManager.CodeCouleurDetails(JourRestant); Dialog = false;
                }
                else
                {
                    CodeClientDetails.Enabled = true;
                    return;
                }

            }
            catch
            {
                MsgBox.Show(this, MessagesSystem.ErreurConsulterDetails);
                this.Close();
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BtnRefresh.PerformClick();
                ProgramManager.InserstionData(CmdLicenceLoad.LoadDataToDataBase(DebutLicenceDetails.Text, DateExpirationDelais.Text, NumeroLicnceDetails.Text, JourRestant.Text, CodeClientDetails.Text, GropLicences.Properties.Items[GropLicences.SelectedIndex].Description));
                MsgBox.Show(this, MessagesSystem.ModifSaved);
            }
            catch (Exception ex)
            {
                MsgBox.Show(this, ex.Message);
            }
            BtnSave.Enabled = false;
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            NumeroLicnceDetails.Text = GetLicences.GetSeriale(NomClientDetail, CodeClientDetails, txtZipeCode, GropLicences);
            LicenceDelaisManager.Recalcule(this, DebutLicenceDetails, DateExpirationDelais, JourRestant);
            LicenceDelaisManager.CodeCouleurDetails(JourRestant);
            BtnSave.Enabled = true;
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnImprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DSImprimer ds = new DSImprimer();
                DataTable table = new DataTable()
                {
                    TableName = "DTImprimer"
                };
                table = ds.DTImprimer;
                table.Clear();
                DataRow row = table.NewRow();
                row["ClName"] = NomClientDetail.Text;
                row["ClZipe"] = txtZipeCode.Text;
                row["ClCode"] = CodeClientDetails.Text;
                row["LicType"] = NumeroLicnceDetails.Text;
                row["LicStart"] = Convert.ToDateTime(DebutLicenceDetails.Text).ToString("dd-MM-yyyy");
                row["LicEnd"] = Convert.ToDateTime(DateExpirationDelais.Text).ToString("dd-MM-yyyy");
                row["Liclong"] = JourRestant.Text;
                row["LicName"] = GropLicences.Properties.Items[GropLicences.SelectedIndex].Description;
                ds.DTImprimer.Rows.Add(row);
                RptImprimer report = new RptImprimer()
                {
                    ShowPrintMarginsWarning = false,
                    DataSource = ds
                };
                using (SaveFileDialog SFDialog = new SaveFileDialog())
                {
                    SFDialog.Title = MessagesSystem.MessageTitleImprimer;
                    SFDialog.Filter = MessagesSystem.MessageSaveAS;
                    if (SFDialog.ShowDialog() == DialogResult.OK)
                    {
                        report.ExportToPdf(SFDialog.FileName);
                    }
                }
                using (ReportPrintTool printtool = new ReportPrintTool(report))
                {
                    printtool.ShowPreviewDialog();
                }

            }
            catch (Exception ex)
            {

                MsgBox.Show(this, ex.Message);
            }
        }
        private void GropLicences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GropLicences.Properties.Items[GropLicences.SelectedIndex].Description == "Licence1")
            {
                GropLicences.Properties.Appearance.BackColor = Color.Lime;
                GropLicences.Properties.AppearanceDisabled.BackColor = Color.Lime;
                PicLicence1.BackColor = Color.Lime;
                GropLicences.Properties.AppearanceFocused.BackColor = Color.Lime;
                PicLicence2.BackColor = Color.Lime;
                GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Lime;
                PicLicence3.BackColor = Color.Lime;
            }
            else if (GropLicences.Properties.Items[GropLicences.SelectedIndex].Description == "Licence2")
            {
                GropLicences.Properties.Appearance.BackColor = Color.Gold;
                GropLicences.Properties.AppearanceDisabled.BackColor = Color.Gold;
                PicLicence1.BackColor = Color.Gold;
                GropLicences.Properties.AppearanceFocused.BackColor = Color.Gold;
                PicLicence2.BackColor = Color.Gold;
                GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Gold;
                PicLicence3.BackColor = Color.Gold;
            }
            else if (GropLicences.Properties.Items[GropLicences.SelectedIndex].Description == "Licence3")
            {
                GropLicences.Properties.Appearance.BackColor = Color.Aqua;
                GropLicences.Properties.AppearanceDisabled.BackColor = Color.Aqua;
                PicLicence1.BackColor = Color.Aqua;
                GropLicences.Properties.AppearanceFocused.BackColor = Color.Aqua;
                PicLicence2.BackColor = Color.Aqua;
                GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Aqua;
                PicLicence3.BackColor = Color.Aqua;
            }

        }
        private void BtnRenew_Click(object sender, EventArgs e)
        {
            NumeroLicnceDetails.Text = GetLicences.GetSeriale(NomClientDetail, CodeClientDetails, txtZipeCode, GropLicences);
            LicenceDelaisManager.Recalcule(this, GropLicences, DebutLicenceDetails, DateExpirationDelais, JourRestant);
            LicenceDelaisManager.CodeCouleurDetails(JourRestant);
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (CodeClientDetails.Text != string.Empty)
            {
                DetailsRepository.DefractionnerObjetReaderDetails(ProgramManager.RecupDataDetails(CodeClientDetails.Text),
                    PicLicence1, PicLicence2, PicLicence3, DateExpirationDelais, DebutLicenceDetails, GropLicences, NumeroLicnceDetails, 
                    JourRestant, NomClientDetail, txtZipeCode, JourRestant);
                LicenceDelaisManager.CodeCouleurDetails(JourRestant);
            }
        }
    }
}